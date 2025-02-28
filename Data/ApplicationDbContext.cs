using Microsoft.EntityFrameworkCore;
using CrudDemo.Models;

namespace CrudDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
