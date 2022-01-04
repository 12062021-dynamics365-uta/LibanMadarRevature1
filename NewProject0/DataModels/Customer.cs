using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject0.DataModels
{
    class Customer
    {
       
        public int consumerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
         public string last_order { get; set; }
        public List<Product> shoppingcart = new List<Product>();


        public Customer(string FirstName, string LastName)
        {
            firstname = FirstName;
            lastname = LastName;
            customerid = CustomerID;


        }

       
        }



        
    
}
