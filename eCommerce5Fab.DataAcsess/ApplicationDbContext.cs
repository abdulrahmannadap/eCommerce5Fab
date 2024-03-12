using ClassLibrary1eCommerce5Fab.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce5Fab.DataAcsess
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { Id = "Phone" , Name = "Phone"},
                new Category { Id = "Laptop" , Name = "Laptop"},
                new Category { Id = "Cumputer" , Name = "Cumputer"},
                new Category { Id = "Watch", Name = "Watch" },
                new Category { Id = "Matchine", Name = "Matchine" }
                ) ;
        }
    }
}
