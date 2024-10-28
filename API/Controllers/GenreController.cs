using API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly ApplicationDb _db;

        public GenreController(ApplicationDb db)
        {
            _db = db;
        }

        [HttpGet("get-all")]

        public IActionResult GetAll()
        {
            return Ok(_db.Genres.ToList());
        }
    }
}
