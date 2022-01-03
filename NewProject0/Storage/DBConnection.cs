using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NewProject0.DataModels;

namespace NewProject0.Storage
{
    class DBConnection
    {
        //My Sql server connection
        //DESKTOP-UFOCI86\\MSSQLSERVER01
        public readonly string str = "Data source = DESKTOP-UFOCI86\\MSSQLSERVER01; initial Catalog=NewProject0; integrated security =true";
        private readonly SqlConnection conn;
        private readonly IMapper _mapper;

        public DBConnection()
        {
            conn = new SqlConnection(str);
            conn.Open();
            this._mapper = new Mapper();

        }
        // Get all data from customers table 
        internal List<Customer> storeallconsumers()
        {
            string query = "SELECT * FROM Customers";
            List<Customer> customerlist = new List<Customer>();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                customerlist = this._mapper.CustomerListEntity(dr);
                
            }

            return customerlist;

        }

    // Adding a New customer        
        public void addUser(Customer c)
        {

            string s = "propaneprogain";

            Console.WriteLine($"{c.fname}, {c.lname},");
            string querystring = $"INSERT INTO CUSTOMERS (FirstName,LastName,Username,Password) VALUES ('{c.fname}', '{c.lname}', );";
            SqlCommand command = new SqlCommand(querystring, conn);
            SqlDataReader dr = command.ExecuteReader();
            dr.Read();



            dr.Close();
        }

        // Adding a new order 
        public void addOrder(Order a)
        {
            
            string querystring = $"INSERT INTO Orders (OrderId,CustomerId,SaleTotal,ProductId) VALUES ('{a.Orderid}', '{a.consumerid}', '{a.Ordertotal}','{a.productid}');";
            SqlCommand command = new SqlCommand(querystring, conn);
            SqlDataReader dr = command.ExecuteReader();
            dr.Read();



            dr.Close();




        }

        // Getting a list of all the products available for sale
        public void getProducts()
        {

            SqlCommand command;

            command = conn.CreateCommand();
            String productquerystring = "SELECT * from PRODUCTS";
            
            using (command = new SqlCommand(productquerystring, conn))
            {
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            Console.Write(dr.GetValue(i) + "\n");
                        }
                        
                    }
                    dr.Close();
                }

            }
           ;
            
        }

        // Getting available store locations

        public List<Store> getStorelist()
        {

            SqlCommand command;
            command = conn.CreateCommand();
            string query = "SELECT * FROM STORES";
            List<Store> Storelist = new List<Store>();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                Storelist = this._mapper.StoreListEntity(dr);
                dr.Close();
            }

            return Storelist;






        }
    }
}
