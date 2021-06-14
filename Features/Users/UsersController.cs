using System;
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

            user.AddressLine1 = form.AddressLine1;
            user.AddressLine2 = form.AddressLine2;
            user.City = form.City;
            user.County = form.County;
            user.Postcode = form.Postcode;
            
            try 
            { 
                _db.SaveChanges(); 
            }
            catch (Exception e) 
            {
                return BadRequest(e);
            }
            

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

            newuser.AddressLine1 = form.AddressLine1;
            newuser.AddressLine2 = form.AddressLine2;
            newuser.City = form.City;
            newuser.County = form.County;
            newuser.Postcode = form.Postcode;

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

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        
        public string City { get; set; }
       
        public string County { get; set; }
       
        public string Postcode { get; set; }
    }

   

}
