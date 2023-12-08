using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IFoodInterface
    {
        Task<IQueryable<Food>> GetAllAsync();
        Task<Food> GetByIdAsync(int id);
        Task AddFoodCategoryAsync(Food food);
        Task DeleteFoodCategoryAsync(int id);
        Task UpdateFoodCategoryAsync(Food food);
    }
}
