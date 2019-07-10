using BionicalTechTest.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BionicalTechTest.Data
{
    public class BionicalContext : DbContext
    {
        public BionicalContext(DbContextOptions<BionicalContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
    }
}