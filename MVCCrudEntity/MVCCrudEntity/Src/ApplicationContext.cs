using Microsoft.EntityFrameworkCore;
using MVCCrudEntity.Models;

namespace MVCCrudEntity.Src
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options) : base(options) { }
       
        public DbSet<Employee> Employees { get; set; }
    }
}
