using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public string Homeland { get; set; } = string.Empty;
        public int FoodCategoryId { get; set; }
        public FoodCategory FoodCategory { get; set; }
    }
}
