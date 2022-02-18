using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Practices.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName{ get; set; }
        public double Price { get; set; }
        public int StockAmount { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
