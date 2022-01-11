using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SweetnSaltyDbAccess
{
    public class SweetnSaltyDbAccessClass : ISweetnSaltyDbAccessClass
    {
        private readonly string str = "Data source = DESKTOP-UFOCI86\\MSSQLSERVER01; initial Catalog=SweetnSalty; integrated security = true";
        private readonly SqlConnection _con;

        //constructor
        public SweetnSaltyDbAccessClass()
        {
            this._con = new SqlConnection(this.str);
            _con.Open();
        }
        // Get all the flavors
        public async Task<SqlDataReader> GetFlavors()
        {
            string retrieveFlavors = "SELECT * FROM Flavor;";

            using (SqlCommand cmd = new SqlCommand(retrieveFlavors, this._con))
            {
                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                return dr;
            }
        }

        //Get all persons
        Public async Task<SqlDataReader> GetPersons()
        {
            string retrievePersons = "SELECT * FROM Persons;";
            using (SqlCommand cmd = new SqlCommand(retrieveFlavors, this._con))
            {
                SqlDataReader dr = await cmd.ExecuteReaderAsync();
            }
        }

       
        
    }
}
