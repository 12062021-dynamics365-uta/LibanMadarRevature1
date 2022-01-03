using NewProject0.DataModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject0.Storage
{
    internal class Mapper : IMapper
    {
        public List<Customer> CustomerListEntity(SqlDataReader dr)
        {
            List<Customer> consumers = new List<Customer>();
            while (dr.Read())
            {
                Customer customer = new Customer()
                {
                    consumerId = Convert.ToInt32(dr[0].ToString()),
                    fname = dr[1].ToString(),
                    lname = dr[2].ToString(),

                };

                consumers.Add(customer);
                Console.WriteLine(customer.lname, customer.lname);

            }
            dr.Close();
            return consumers;
        }


        public List<Product> InventoryListEntity(SqlDataReader dr)
        {
            List<Product> inventory = new List<Product>();
            while (dr.Read())
            {
                DataModels.Product p = new Product()
                {
                    product_quantity = Convert.ToInt32(dr[4].ToString()),
                    product_number = Convert.ToInt32(dr[5].ToString()),
                    product_name = dr[6].ToString(),
                    product_description = dr[7].ToString(),
                    price = Convert.ToDecimal(dr[8].ToString()),




                };
                inventory.Add(p);


            }
            
            return inventory;
        }


        public List<Store> StoreListEntity(SqlDataReader dr)
        {
            List<Store> storelist = new List<Store>();
            while (dr.Read())
            {
                Store s = new Store()
                {
                    StoreId = Convert.ToInt32(dr[0].ToString()),
                    AddressId = dr[1].ToString(),


                };
                storelist.Add(s);

            }
            dr.Close();
            return storelist;

        }
    }
}
