﻿using Azure;
using Microsoft.AspNetCore.Mvc;
using MTGManager.DataAccess.Repository.IRepository;
using MTGManager.Shared.Models;
using System.Text.Json;

namespace MTGManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CardController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddCard([FromBody] JsonElement jsonCard)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true, // Allow case-insensitive property matching
                };

                var card = JsonSerializer.Deserialize<ScryfallCard>(jsonCard.GetRawText(), options);

                if (card == null)
                {
                    return BadRequest("Unable to parse the card data.");
                }

                await _unitOfWork.Card.Add(card);
                await Task.FromResult(_unitOfWork.Save());

                return Ok();
            }
            catch (JsonException ex)
            {
                return BadRequest($"JSON Parsing Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [HttpGet("Get")]
        public async Task<IActionResult> GetCard([FromQuery] Guid id)
        {
            var card = _unitOfWork.Card.GetFirstOrDefault(x => x.Id == id);
            return Ok(card);
        }
    }
}
