using NewProject0.DataModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject0.Storage
{
    interface IMapper
    {
        public List<Customer> CustomerListEntity(SqlDataReader dr);
        List<Product> InventoryListEntity(SqlDataReader dr);
        List<Store> StoreListEntity(SqlDataReader dr);
    }
}
