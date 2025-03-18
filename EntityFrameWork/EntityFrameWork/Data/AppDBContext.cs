using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(
     new Language() { Id = 1, LanTitle = "Hindi", LanDescription = "Hindi" },
     new Language() { Id = 2, LanTitle = "Tamil", LanDescription = "Tamil" },
     new Language() { Id = 3, LanTitle = "Urdu", LanDescription = "Urdu" },
     new Language() { Id = 4, LanTitle = "Gujrati", LanDescription = "Gujrati" }
 );

            modelBuilder.Entity<Currency>().HasData(
                new Currency() { ID = 1, CurTitle = "INR", CurDescription = "Indian INR" },
                new Currency() { ID = 2, CurTitle = "Dollar", CurDescription = "Dollar" },
                new Currency() { ID = 3, CurTitle = "Euro", CurDescription = "Euro" },
                new Currency() { ID = 4, CurTitle = "Dinar", CurDescription = "Dinar" },
                new Currency() { ID = 5, CurTitle = "Dollar", CurDescription = "USDollar" }
                );
        }


        public  DbSet<Book> Book { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
        public DbSet<Currency> Currency { get; set; }

    }
}
