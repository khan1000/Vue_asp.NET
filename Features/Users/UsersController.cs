using System.Threading.Tasks;
using BionicalTechTest.Data;
using BionicalTechTest.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BionicalTechTest.Features.Users
{
    [ApiController]
    public class UsersController : Controller
    {
        private readonly BionicalContext _db;

        public UsersController(BionicalContext db)
        {
            _db = db;
        }

        [Route("api/Users")]

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _db.Users.ToListAsync());
        }

        [Route("api/Users/FindUser/{id}")]
        [HttpGet]
        public ActionResult FindUser(int? id)
        {
            return Ok(_db.Users.Find(id));
        }

        [Route("api/Users/EditUser/{id}")]
        [HttpPost]
        public ActionResult EditUser(int id, [FromBody]Form form)
        {
            var user = _db.Users.Find(id);

            user.FirstName = form.Name;
            user.LastName = form.LastName;
            user.Email = form.Email;

            _db.SaveChanges();

            return Ok();

        }

        [Route("api/Users/AddUser")]
        [HttpPost]
        public ActionResult AddUser([FromBody] Form form)
        {
            User newuser = new User();

            newuser.FirstName = form.Name;
            newuser.LastName = form.LastName;
            newuser.Email = form.Email;
  
            _db.Users.Add(newuser);
            _db.SaveChanges();

            return Ok();

        }

    }

    public class Form 
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

   

}
