using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace YumBlazor.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Appetizers" },
                new Category { Id = 2, Name = "Main Courses" },
                new Category { Id = 3, Name = "Desserts" },
                new Category { Id = 4, Name = "Beverages" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Spring Rolls", Price = 5.99M, Description = "Crispy rolls with vegetables", CategoryId = 1, ImageUrl = "images/spring_rolls.jpg" },
                new Product { Id = 2, Name = "Caesar Salad", Price = 7.99M, Description = "Fresh romaine with Caesar dressing", CategoryId = 1, ImageUrl = "images/caesar_salad.jpg" },
                new Product { Id = 3, Name = "Grilled Chicken", Price = 12.99M, Description = "Juicy grilled chicken breast", CategoryId = 2, ImageUrl = "images/grilled_chicken.jpg" }
                );
        }
    }
}
