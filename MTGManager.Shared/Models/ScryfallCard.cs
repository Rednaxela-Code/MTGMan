using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace MTGManager.Shared.Models
{
    public class ScryfallCard
    {
        [JsonPropertyName("object")]
        public string? Object { get; set; }

        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("oracle_id")]
        public Guid? OracleId { get; set; }

        [JsonPropertyName("multiverse_ids")]
        public int[]? MultiverseIds { get; set; }

        [JsonPropertyName("mtgo_id")]
        public int? MtgoId { get; set; }

        [JsonPropertyName("mtgo_foil_id")]
        public int? MtgoFoilId { get; set; }

        [JsonPropertyName("tcgplayer_id")]
        public int? TcgplayerId { get; set; }

        [JsonPropertyName("cardmarket_id")]
        public int? CardMarketId { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("lang")]
        public string? Language { get; set; }

        [JsonPropertyName("released_at")]
        public DateTime? ReleasedAt { get; set; }

        [JsonPropertyName("uri")]
        public Uri? Uri { get; set; }

        [JsonPropertyName("scryfall_uri")]
        public Uri? ScryfallUri { get; set; }

        [JsonPropertyName("layout")]
        public string? Layout { get; set; }

        [JsonPropertyName("highres_image")]
        public bool? HighresImage { get; set; }

        [JsonPropertyName("image_status")]
        public string? ImageStatus { get; set; }
        // Foreign key for Legalities
        public int? ImageUrisId { get; set; }

        [JsonPropertyName("image_uris")]
        public ImageUris? ImageUris { get; set; }

        [JsonPropertyName("mana_cost")]
        public string? ManaCost { get; set; }

        [JsonPropertyName("cmc")]
        public decimal? Cmc { get; set; }

        [JsonPropertyName("type_line")]
        public string? TypeLine { get; set; }

        [JsonPropertyName("oracle_text")]
        public string? OracleText { get; set; }

        [JsonPropertyName("power")]
        public string? Power { get; set; }

        [JsonPropertyName("toughness")]
        public string? Toughness { get; set; }

        [JsonPropertyName("colors")]
        public string[]? Colors { get; set; }

        [JsonPropertyName("color_identity")]
        public string[]? ColorIdentity { get; set; }
        // Foreign key for Legalities
        public int? LegalitiesId { get; set; }

        [JsonPropertyName("legalities")]
        public Legalities? Legalities { get; set; }

        [JsonPropertyName("games")]
        public string[]? Games { get; set; }

        [JsonPropertyName("reserved")]
        public bool? Reserved { get; set; }

        [JsonPropertyName("foil")]
        public bool? Foil { get; set; }

        [JsonPropertyName("nonfoil")]
        public bool? NonFoil { get; set; }

        [JsonPropertyName("finishes")]
        public string[]? Finishes { get; set; }

        [JsonPropertyName("oversized")]
        public bool? Oversized { get; set; }

        [JsonPropertyName("promo")]
        public bool? Promo { get; set; }

        [JsonPropertyName("reprint")]
        public bool? Reprint { get; set; }

        [JsonPropertyName("set_id")]
        public Guid? SetId { get; set; }

        [JsonPropertyName("set")]
        public string? Set { get; set; }

        [JsonPropertyName("set_name")]
        public string? SetName { get; set; }

        [JsonPropertyName("set_type")]
        public string? SetType { get; set; }

        [JsonPropertyName("set_uri")]
        public Uri? SetUri { get; set; }

        [JsonPropertyName("set_search_uri")]
        public Uri? SetSearchUri { get; set; }

        [JsonPropertyName("scryfall_set_uri")]
        public Uri? ScryfallSetUri { get; set; }

        [JsonPropertyName("rulings_uri")]
        public Uri? RulingsUri { get; set; }

        [JsonPropertyName("prints_search_uri")]
        public Uri? PrintsSearchUri { get; set; }

        [JsonPropertyName("collector_number")]
        public string? CollectorNumber { get; set; }

        [JsonPropertyName("digital")]
        public bool? Digital { get; set; }

        [JsonPropertyName("rarity")]
        public string? Rarity { get; set; }

        [JsonPropertyName("flavor_text")]
        public string? FlavorText { get; set; }

        [JsonPropertyName("card_back_id")]
        public Guid? CardBackId { get; set; }

        [JsonPropertyName("artist")]
        public string? Artist { get; set; }

        [JsonPropertyName("artist_ids")]
        public string[]? ArtistIds { get; set; }

        [JsonPropertyName("illustration_id")]
        public Guid? IllustrationId { get; set; }

        [JsonPropertyName("border_color")]
        public string? BorderColor { get; set; }

        [JsonPropertyName("frame")]
        public string? Frame { get; set; }

        [JsonPropertyName("full_art")]
        public bool? FullArt { get; set; }

        [JsonPropertyName("textless")]
        public bool? Textless { get; set; }

        [JsonPropertyName("booster")]
        public bool? Booster { get; set; }

        [JsonPropertyName("story_spotlight")]
        public bool? StorySpotlight { get; set; }

        [JsonPropertyName("edhrec_rank")]
        public int? EdhrecRank { get; set; }

        [JsonPropertyName("penny_rank")]
        public int? PennyRank { get; set; }

        // Foreign key for Prices
        //public int? PricesId { get; set; }
        //[JsonPropertyName("prices")]
        //public Prices? Prices { get; set; }

        // Foreign key for RelatedUris
        public int? RelatedUrisId { get; set; }
        [JsonPropertyName("related_uris")]
        public RelatedUris? RelatedUris { get; set; }

        // Foreign key for PurchaseUris
        public int? PurchaseUrisId { get; set; }
        [JsonPropertyName("purchase_uris")]
        public PurchaseUris? PurchaseUris { get; set; }


    }

    public class ImageUris
    {
        public int Id { get; set; }
        [JsonPropertyName("small")]
        public string? Small { get; set; }

        [JsonPropertyName("normal")]
        public string? Normal { get; set; }

        [JsonPropertyName("large")]
        public string? Large { get; set; }

        [JsonPropertyName("png")]
        public string? Png { get; set; }

        [JsonPropertyName("art_crop")]
        public string? ArtCrop { get; set; }

        [JsonPropertyName("border_crop")]
        public string? BorderCrop { get; set; }
    }

    public class Legalities
    {
        public int Id { get; set; }
        [JsonPropertyName("standard")]
        public string? Standard { get; set; }

        [JsonPropertyName("future")]
        public string? Future { get; set; }

        [JsonPropertyName("historic")]
        public string? Historic { get; set; }

        [JsonPropertyName("gladiator")]
        public string? Gladiator { get; set; }

        [JsonPropertyName("pioneer")]
        public string? Pioneer { get; set; }

        [JsonPropertyName("explorer")]
        public string? Explorer { get; set; }

        [JsonPropertyName("modern")]
        public string? Modern { get; set; }

        [JsonPropertyName("legacy")]
        public string? Legacy { get; set; }

        [JsonPropertyName("pauper")]
        public string? Pauper { get; set; }

        [JsonPropertyName("vintage")]
        public string? Vintage { get; set; }

        [JsonPropertyName("penny")]
        public string? Penny { get; set; }

        [JsonPropertyName("commander")]
        public string? Commander { get; set; }

        [JsonPropertyName("oathbreaker")]
        public string? Oathbreaker { get; set; }

        [JsonPropertyName("paupercommander")]
        public string? Paupercommander { get; set; }

        [JsonPropertyName("duel")]
        public string? Duel { get; set; }

        [JsonPropertyName("oldschool")]
        public string? Oldschool { get; set; }

        [JsonPropertyName("premodern")]
        public string? Premodern { get; set; }

        [JsonPropertyName("predh")]
        public string? Predh { get; set; }
    }

    public class Prices
    {
        public int Id { get; set; }
        [JsonPropertyName("usd")]
        public decimal? Usd { get; set; }

        [JsonPropertyName("usd_foil")]
        public decimal? UsdFoil { get; set; }

        [JsonPropertyName("usd_etched")]
        public decimal? UsdEtched { get; set; }

        [JsonPropertyName("eur")]
        public decimal? Eur { get; set; }

        [JsonPropertyName("eur_foil")]
        public decimal? EurFoil { get; set; }

        [JsonPropertyName("tix")]
        public decimal? Tix { get; set; }
    }

    public class RelatedUris
    {
        public int Id { get; set; }
        [JsonPropertyName("gatherer")]
        public string? Gatherer { get; set; }

        [JsonPropertyName("tcgplayer_infinite_articles")]
        public string? TcgplayerInfiniteArticles { get; set; }

        [JsonPropertyName("tcgplayer_infinite_decks")]
        public string? TcgplayerInfiniteDecks { get; set; }

        [JsonPropertyName("edhrec")]
        public string? Edhrec { get; set; }
    }

    public class PurchaseUris
    {
        public int Id { get; set; }
        [JsonPropertyName("tcgplayer")]
        public string? Tcgplayer { get; set; }

        [JsonPropertyName("cardmarket")]
        public string? Cardmarket { get; set; }

        [JsonPropertyName("cardhoarder")]
        public string? Cardhoarder { get; set; }
    }
}
