using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Practices.Entities.ViewModels
{
    public class PostProductQueryViewModel
    {
        public string ProductName { get; set; }
        public int StockAmount { get; set; }
        public int CategoryId { get; set; }

    }
}
