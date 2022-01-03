using NewProject0.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject0.Storage
{
    interface IDBConnection
    {
        public void access();

        public void addUser(Customer c);


        public void get_productlist();


        public void get_locations();


        public List<Product> get_inventory(int storenumber);


        public List<Store> get_storelist();

    }
}
