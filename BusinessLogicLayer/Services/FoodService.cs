using AutoMapper;
using BusinessLogicLayer.AutoMapper.Interfaces;
using BusinessLogicLayer.Dtos.FoodDtos;
using BusinessLogicLayer.Validators;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.AutoMapper.Services;

public class FoodService : IFoodService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public FoodService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async Task AddFoodAsync(AddFoodDto addFood)
    {
        if (addFood.IsValid())
        {
            var list = await _unitOfWork.FoodCategories.GetAllAsync();
            if(list.Any(i => i.Id == addFood.FoodCategoryId))
            {
                var food = _mapper.Map<Food>(addFood);
                food.FoodCategory = null;
                await _unitOfWork.Foods.AddFoodCategoryAsync;
            }
        }
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
