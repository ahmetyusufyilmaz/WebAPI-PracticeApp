using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Practices.Entities;

namespace WebAPI_Practices.DataAccess
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        List<Product> GetProductWithCategory();
    }
}
    
