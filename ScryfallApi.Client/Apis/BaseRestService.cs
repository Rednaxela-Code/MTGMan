﻿using Microsoft.Extensions.Caching.Memory;
using ScryfallApi.Client.Models;
using System.Text.Json;

namespace ScryfallApi.Client.Apis;

internal sealed class BaseRestService
{
    private readonly HttpClient _httpClient;
    private readonly ScryfallApiClientConfig _clientConfig;
    private readonly IMemoryCache _cache;
    private readonly MemoryCacheEntryOptions _cacheOptions;

    public BaseRestService(HttpClient httpClient, ScryfallApiClientConfig clientConfig, IMemoryCache cache)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        if (_httpClient.BaseAddress is null)
            _httpClient.BaseAddress = clientConfig.ScryfallApiBaseAddress;
        _clientConfig = clientConfig;
        _cache = cache;

        if (clientConfig.EnableCaching)
        {
            _cacheOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = _clientConfig.UseSlidingCacheExpiration ? null : _clientConfig.CacheDuration,
                SlidingExpiration = _clientConfig.UseSlidingCacheExpiration ? _clientConfig.CacheDuration : null,
            };
        }
    }

    public async Task<T> GetAsync<T>(string resourceUrl, bool useCache = true) where T : BaseItem
    {
        if (string.IsNullOrWhiteSpace(resourceUrl))
            throw new ArgumentNullException(nameof(resourceUrl));

        var cacheKey = _httpClient.BaseAddress.AbsoluteUri + resourceUrl;

        if (useCache && _cache != null && _cache.TryGetValue(cacheKey, out T cached))
            return cached;

        var response = await _httpClient.GetAsync(resourceUrl).ConfigureAwait(false);
        var jsonStream = await response.Content.ReadAsStreamAsync();
        var obj = await JsonSerializer.DeserializeAsync<T>(jsonStream);

        if (obj.ObjectType.Equals("error", StringComparison.OrdinalIgnoreCase))
        {
            jsonStream.Position = 0;
            var error = await JsonSerializer.DeserializeAsync<Error>(jsonStream);
            throw new ScryfallApiException(error.Details)
            {
                ResponseStatusCode = response.StatusCode,
                RequestUri = response.RequestMessage.RequestUri,
                RequestMethod = response.RequestMessage.Method,
                ScryfallError = error
            };
        }

        if (useCache) _cache?.Set(cacheKey, obj, _cacheOptions);

        return obj;
    }
}
