using april6.Models;
using Microsoft.EntityFrameworkCore;

namespace april6.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; } = null!;
    }
}
