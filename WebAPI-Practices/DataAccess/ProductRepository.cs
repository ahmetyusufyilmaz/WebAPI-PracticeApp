using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Practices.Entities;

namespace WebAPI_Practices.DataAccess
{
    public class ProductRepository : IProductRepository
    {
        private readonly WebAPIDbContext _context;

        public ProductRepository(WebAPIDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int productId)
        {
            return _context.Products.SingleOrDefault(p => p.Id == productId);
        }

        public void Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);


            if (product is null)
            {
                throw new InvalidOperationException("Product bulunamadı");
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public List<Product> GetProductWithCategory()
        {
            var result = _context.Products.Include(c => c.Category);
            return result.ToList();
        }

    }
}
