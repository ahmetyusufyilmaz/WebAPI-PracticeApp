using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Practices.Entities;
using WebAPI_Practices.Entities.ViewModels;

namespace WebAPI_Practices.Extensions
{
    public static class ProductViewModelExtensions
    {
        public static List<GetProductViewModel> GetProductsViewModel(this List<Product> products)
        {
            List<GetProductViewModel> getProducts = new List<GetProductViewModel>();

            foreach (var product in products)
            {

                var viwModel = new GetProductViewModel
                {
                    ProductName = product.ProductName,
                    Price = product.Price,
                    Category = product.Category.CategoryName,
                    StockAmount = product.StockAmount
                };
                getProducts.Add(viwModel);
            }

            return getProducts;

        }

    }
}
