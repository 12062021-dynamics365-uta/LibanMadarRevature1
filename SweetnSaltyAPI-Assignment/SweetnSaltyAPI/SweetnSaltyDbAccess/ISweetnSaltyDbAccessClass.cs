using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetnSaltyDbAccess
{
    internal interface ISweetnSaltyDbAccessClass
    {
        Task<SqlDataReader> GetFlavors();
        Task<SqlDataReader> GetPersons();

    }
}
