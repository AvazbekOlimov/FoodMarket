using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IFoodCategoryInterface
    {
        Task<IQueryable<FoodCategory>> GetAllAsync();
        Task<FoodCategory> GetByIdAsync(int id);
        Task AddFoodCategoryAsync(FoodCategory foodCategory);
        Task DeleteFoodCategoryAsync(int id);
        Task UpdateFoodCategoryAsync(FoodCategory foodCategory);

    }
}
