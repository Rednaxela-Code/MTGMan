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
    }
}
