using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach.DataSrc
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {
            
        }
    }
}
