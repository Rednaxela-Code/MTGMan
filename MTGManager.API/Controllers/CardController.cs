using Microsoft.AspNetCore.Mvc;
using MTGManager.Shared.Models;

namespace MTGManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : Controller
    {
        // This is a mock list of cards. In a real application, you'd get this from a database or service.
        private static List<Card> cards = new List<Card>
        {
            new Card { Id = "5f3af1f2-8581-4e5d-b128-d74a0a9eaf12", Name = "Prohibit" },
            new Card { Id = "f83af122-4581-4a3b-a528-d73b0b2ba1b3", Name = "Lightning Bolt" }
        };

        // GET: api/card
        [HttpGet]
        public IActionResult GetAllCards()
        {
            return Ok(cards);
        }

        // GET: api/card/{id}
        [HttpGet("{id}")]
        public IActionResult GetCardById(string id)
        {
            var card = cards.Find(c => c.Id == id);
            if (card == null)
            {
                return NotFound();
            }
            return Ok(card);
        }

        // POST: api/card
        [HttpPost]
        public IActionResult AddCard([FromBody] Card newCard)
        {
            if (newCard == null || string.IsNullOrWhiteSpace(newCard.Id))
            {
                return BadRequest("Invalid card data.");
            }

            cards.Add(newCard);
            return CreatedAtAction(nameof(GetCardById), new { id = newCard.Id }, newCard);
        }

        // PUT: api/card/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateCard(string id, [FromBody] Card updatedCard)
        {
            var card = cards.Find(c => c.Id == id);
            if (card == null)
            {
                return NotFound();
            }

            card.Name = updatedCard.Name;
            card.OracleId = updatedCard.OracleId;
            // Update other properties as needed

            return NoContent(); // 204 status code
        }

        // DELETE: api/card/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteCard(string id)
        {
            var card = cards.Find(c => c.Id == id);
            if (card == null)
            {
                return NotFound();
            }

            cards.Remove(card);
            return NoContent();
        }
    }
}

