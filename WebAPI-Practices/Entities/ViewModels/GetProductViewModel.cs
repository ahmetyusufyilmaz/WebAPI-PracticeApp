using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Practices.Entities.ViewModels
{
    public class GetProductViewModel
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockAmount { get; set; }
        public string Category { get; set; }

    }
}
