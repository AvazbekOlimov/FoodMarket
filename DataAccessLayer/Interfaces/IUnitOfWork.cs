using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IFoodInterface Food { get; }
        IFoodCategoryInterface FoodCategories { get; }
        void Commit();
    }
}
