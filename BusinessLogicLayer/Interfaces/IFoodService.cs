using BusinessLogicLayer.Dtos.FoodDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.AutoMapper.Interfaces;

public interface IFoodService
{
    Task<List<FoodDto>> GetAllFoodsAsync();
    Task<FoodDto> GetFoodAsync(int id);
    Task AddFoodAsync(AddFoodDto addFood);
    Task DeleteFoodAsync(int id);
    Task UpdateFoodAsyn(FoodDto food);
}
