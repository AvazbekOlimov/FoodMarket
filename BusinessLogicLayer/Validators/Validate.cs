using BusinessLogicLayer.Dtos.FoodDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Validators;

public static class Validate
{
    public static bool IsValid(this AddFoodDto dto)
    {
        if (dto == null || dto.Name.Length < 4 || dto.Price<1|| dto.FoodCategoryId == 0) {
            return false;
        }
        return true;
    }
    
}
