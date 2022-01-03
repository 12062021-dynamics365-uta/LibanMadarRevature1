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
        public string fname { get; set; }
        public string lname { get; set; }
         public string last_order { get; set; }
        public List<Product> shoppingcart = new List<Product>();


        public Customer(string FirstName, string LastName)
        {
            fname = FirstName;
            lname = LastName;

        }

        public void viewshoppingcart()
        {
            foreach (Product x in this.shoppingcart)
            {
                Console.WriteLine(x.product_name);
            }

        }

        public void add_to_shoppingcart(Product s)
        {
            this.shoppingcart.Add(s);
        }



        public void remove_from_shoppingcart(Product s)
        {
            this.shoppingcart.Remove(s);
        }




        public Customer()
        {

        }


        internal decimal CartTotal()
        {
            decimal totalCost;
            return totalCost = Math.Round(shoppingcart.Sum(p => p.price), 2); 
        }

    }
}
