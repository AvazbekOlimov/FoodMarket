using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Exeptions;

public class FoodExeption : Exception
{
    public FoodExeption(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public readonly string ErrorMessage; 
    
}
