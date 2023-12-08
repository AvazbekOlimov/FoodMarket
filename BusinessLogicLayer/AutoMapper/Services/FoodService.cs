using BusinessLogicLayer.AutoMapper.Interfaces;
using BusinessLogicLayer.Dtos.FoodDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.AutoMapper.Services;

public class FoodService : IFoodService
{
    public FoodService()
    {
        
    }
    public Task AddFoodAsync(AddFoodDto addFood)
    {
        throw new NotImplementedException();
    }

    public Task DeleteFoodAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<FoodDto>> GetAllFoodsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<FoodDto> GetFoodAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateFoodAsyn(FoodDto food)
    {
        throw new NotImplementedException();
    }
}
