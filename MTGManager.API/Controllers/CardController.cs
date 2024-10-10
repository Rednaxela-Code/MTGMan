using Microsoft.AspNetCore.Mvc;
using MTGManager.Shared.Models;
using ScryfallApi.Client;

namespace MTGManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardController : ControllerBase
    {
        private readonly ScryfallApiClient _scryfallApi;

        public CardController(ScryfallApiClient scryfallApi)
        {
            _scryfallApi = scryfallApi;
        }

        [HttpGet("cardsearch")]
        public async Task<IActionResult> GetCardByFuzzy([FromQuery] string fuzzy)
        {
            var card = await _scryfallApi.Cards.Search(fuzzy, 0, ScryfallApi.Client.Models.SearchOptions.CardSort.Name);
            ScryfallCard myCard = (ScryfallCard)card.Data;
            return Ok(myCard);
        }
    }
}
