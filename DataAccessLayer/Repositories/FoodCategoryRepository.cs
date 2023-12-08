using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;


namespace DataAccessLayer.Repositories;

public class FoodCategoryRepository : IFoodCategoryInterface
{
    private readonly ApplicationDbContext _dbContext;

    public FoodCategoryRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public Task AddFoodCategoryAsync(FoodCategory foodCategory)
    {
        throw new NotImplementedException();
    }

    public Task DeleteFoodCategoryAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<FoodCategory>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<FoodCategory> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateFoodCategoryAsync(FoodCategory foodCategory)
    {
        throw new NotImplementedException();
    }
}
