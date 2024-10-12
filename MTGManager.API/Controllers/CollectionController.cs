using Microsoft.AspNetCore.Mvc;
using MTGManager.DataAccess.Repository.IRepository;
using MTGManager.Shared.Models;
using System.Text.Json;

namespace MTGManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CollectionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CollectionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddCollection([FromBody] Collection collection)
        {
            try
            {
                if (collection != null)
                {
                    await _unitOfWork.Collection.Add(collection);
                    await _unitOfWork.Save();
                }

                return Ok(collection);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetCollection([FromQuery] Guid id)
        {
            try
            {
                var collection = await _unitOfWork.Collection.GetFirstOrDefault(c => c.Id == id);
                if (collection != null)
                {
                    return Ok();
                }
                return BadRequest($"Collection with ID: {id} was not found.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }
    }
}
