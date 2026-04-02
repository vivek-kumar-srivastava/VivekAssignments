using Microsoft.EntityFrameworkCore;

namespace WebApiInAsp.netcoreMvcDemo.Models
{
    public class EmpContext:DbContext
    {
        public EmpContext(DbContextOptions<EmpContext>options):base(options) { }

        public DbSet<Employee> employees { get; set; } 
    }
}