using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstApproach.SrcData
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarBrand>().HasData(
             new CarBrand()
             {
                 BrandID = 1,
                 BrandName = "Honda",
                 Country = "Japan",
                 CreatedAt = new DateTime(1955, 12, 30)
             }
             );
              modelBuilder.Entity<CarType>().HasData(
             new CarType()
             {
                 TypeID = 1,
                 TypeName = "OffRoaded",
                 Description="The Car Is 4*4",
                 CreateAt = new DateTime(2000,6,27)
             }


             );

        }

        public DbSet<CarBrand> CarBrand { get; set; }
        public DbSet<CarDetails> CarDetails { get; set; }
        public DbSet<CarOwner> CarOwner { get; set; }
        public DbSet<CarType> CarType { get; set; }
    }
}
