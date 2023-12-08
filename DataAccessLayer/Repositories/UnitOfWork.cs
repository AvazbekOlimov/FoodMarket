using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IFoodCategoryInterface _foodCategory;
    private readonly IFoodInterface _food;

    public UnitOfWork(ApplicationDbContext dbContext,
        IFoodCategoryInterface foodCategory,
        IFoodInterface food)
    {
        _dbContext = dbContext;
        _foodCategory = foodCategory;
        _food = food;
    }
    public IFoodInterface Food => _food;

    public IFoodCategoryInterface FoodCategories => _foodCategory;

    public async void Commit()
        => await _dbContext.SaveChangesAsync();

    public void Dispose()
    {   
        GC.SuppressFinalize(this);
    }
}
