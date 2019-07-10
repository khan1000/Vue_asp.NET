using System.Threading.Tasks;
using BionicalTechTest.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BionicalTechTest.Features.Users
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly BionicalContext _db;

        public UsersController(BionicalContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _db.Users.ToListAsync());
        }
    }
}
