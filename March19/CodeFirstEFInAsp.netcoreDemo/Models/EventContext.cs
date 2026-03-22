using Microsoft.EntityFrameworkCore;

namespace CodeFirstEFInAsp.netcoreDemo.Models
{
    public class EventContext:DbContext
    {
        public EventContext(DbContextOptions<EventContext> dbContextOptions) : base(dbContextOptions) 
        { 
        
        }

        public DbSet<Author>authors { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Author1> authors1 { get; set; }
        public DbSet<Course1> courses1 { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<UserDetail> userdetails { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Post>posts { get; set; }

    }
}
