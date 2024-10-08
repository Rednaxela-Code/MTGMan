using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MTGManager.Shared.Models
{
    public class Card
    {
        [Required]
        public int CardId { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("oracle_id")]
        public string? OracleId { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("lang")]
        public string? Lang { get; set; }

        [JsonPropertyName("released_at")]
        public DateTime? ReleasedAt { get; set; }

        [JsonPropertyName("uri")]
        public string? Uri { get; set; }

        [JsonPropertyName("scryfall_uri")]
        public string? ScryfallUri { get; set; }

        [JsonPropertyName("layout")]
        public string? Layout { get; set; }

        [JsonPropertyName("highres_image")]
        public bool? HighresImage { get; set; }

        [JsonPropertyName("image_status")]
        public string? ImageStatus { get; set; }

        [JsonPropertyName("mana_cost")]
        public string? ManaCost { get; set; }

        [JsonPropertyName("cmc")]
        public double? Cmc { get; set; }

        [JsonPropertyName("type_line")]
        public string? TypeLine { get; set; }

        [JsonPropertyName("oracle_text")]
        public string? OracleText { get; set; }

        [JsonPropertyName("colors")]
        public List<string>? Colors { get; set; }

        [JsonPropertyName("color_identity")]
        public List<string>? ColorIdentity { get; set; }

        [JsonPropertyName("keywords")]
        public List<string>? Keywords { get; set; }

        [JsonPropertyName("games")]
        public List<string>? Games { get; set; }

        [JsonPropertyName("reserved")]
        public bool? Reserved { get; set; }

        [JsonPropertyName("set_id")]
        public string? SetId { get; set; }

        [JsonPropertyName("set")]
        public string? Set { get; set; }

        [JsonPropertyName("set_name")]
        public string? SetName { get; set; }

        [JsonPropertyName("set_type")]
        public string? SetType { get; set; }

        [JsonPropertyName("set_uri")]
        public string? SetUri { get; set; }

        [JsonPropertyName("set_search_uri")]
        public string? SetSearchUri { get; set; }

        [JsonPropertyName("scryfall_set_uri")]
        public string? ScryfallSetUri { get; set; }

        [JsonPropertyName("rulings_uri")]
        public string? RulingsUri { get; set; }

        [JsonPropertyName("prints_search_uri")]
        public string? PrintsSearchUri { get; set; }

        [JsonPropertyName("collector_number")]
        public string? CollectorNumber { get; set; }

        [JsonPropertyName("digital")]
        public bool? Digital { get; set; }

        [JsonPropertyName("rarity")]
        public string? Rarity { get; set; }

        [JsonPropertyName("card_back_id")]
        public string? CardBackId { get; set; }

        [JsonPropertyName("artist")]
        public string? Artist { get; set; }

        [JsonPropertyName("artist_ids")]
        public List<string>? ArtistIds { get; set; }

        [JsonPropertyName("illustration_id")]
        public string? IllustrationId { get; set; }

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
    }
}
