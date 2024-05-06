using GenericRepoPattern.Modal;
using Microsoft.EntityFrameworkCore;

namespace GenericRepoPattern.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Departments> Departments { get; set; }
    }
}
