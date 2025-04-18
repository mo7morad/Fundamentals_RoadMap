using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsCountriesDataAccess
    {
        public static List<string> GetAllCountries()
        {
            List<string> Countries = new List<string>();

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand("SELECT CountryName FROM Countries", Connection))
                {
                    Connection.Open();
                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            foreach (var Country in Reader)
                            {
                                Countries.Add(Country.ToString());
                            }
                        }
                    }
                }
            }
            return Countries;
        }

    }
}
