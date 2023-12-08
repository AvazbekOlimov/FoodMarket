using AutoMapper;
using BusinessLogicLayer.Dtos.FoodDtos;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<FoodDto, Food>().ReverseMap();
        CreateMap<AddFoodDto, Food>().ReverseMap();
        CreateMap<UpdataFoodDto, Food>().ReverseMap();
    }
}
