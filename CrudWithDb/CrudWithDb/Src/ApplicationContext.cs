using CrudWithDb.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudWithDb.Src
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Language data
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = 1, Title = "Hindi", Desc = "Indian Language" },
                new Language() { Id = 2, Title = "English", Desc = "USA Language" },
                new Language() { Id = 3, Title = "French", Desc = "France Language" }
            );

            // Seed Emp data
            modelBuilder.Entity<Emp>().HasData(
                new Emp() { id = 1, name = "krunal", state = "Gujarat", city = "surat", salary = 20000, LanguageId = 1 },
                new Emp() { id = 2, name = "keval", state = "MP", city = "gawali", salary = 30000, LanguageId = 2 },
                new Emp() { id = 3, name = "samit", state = "Delhi", city = "wajipur", salary = 50000, LanguageId = 3 },
                new Emp() { id = 4, name = "aakash", state = "maharashtra", city = "mumbai", salary = 60000, LanguageId = 1 }
            );
        }

        public DbSet<Emp> Emp { get; set; }
        public DbSet<Language> Language { get; set; }
    }
}
