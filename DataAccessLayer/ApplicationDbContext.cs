using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options) { }

    public DbSet<FoodCategory> FoodCategories { get; set; }
    public DbSet<Food> foods { get; set; }
     

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FoodCategory>().HasData(new FoodCategory()
        {
            Id = 1,
            Name = "O'zbek milliy taomlari"
        });
        modelBuilder.Entity<Food>().HasData(new Food()
        {
            Id = 1,
            Name = "Osh",
            Price = 18.000,
            Homeland = "Uzbekistan",
            FoodCategoryId = 1
        });
        base.OnModelCreating(modelBuilder);
    }
}
