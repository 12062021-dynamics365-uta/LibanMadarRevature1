using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject0.DataModels
{
    class Product
    {
        public int product_quantity;
        public int product_number { get; set; }
        public string product_name { get; set; }
        public string product_description { get; set; }
        public decimal price { get; set; }
    }
}
