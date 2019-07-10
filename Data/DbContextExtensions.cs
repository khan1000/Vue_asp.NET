using System.Collections.Generic;
using System.Linq;
using BionicalTechTest.Data.Entities;

namespace BionicalTechTest.Data
{
    public static class DbContextExtensions
    {
        public static void EnsureSeeded(this BionicalContext context)
        {
            if (context.Users.Any())
                return;

            //seed stuff
            context.Users.AddRange(new List<User>
            {
                new User
                {
                    Email = "stuart.ratcliffe@bionical.com",
                    FirstName = "Stu",
                    LastName = "Ratcliffe"
                },
                new User
                {
                    Email = "simon.higginbotham@bionical.com",
                    FirstName = "Simon",
                    LastName = "Higginbotham"
                }
            });

            context.SaveChanges();
        }
    }
}