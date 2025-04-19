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
        public static int GetCountryID(string countryName)
        {
            int countryID = 0;
            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand("SELECT CountryID FROM Countries WHERE CountryName = @CountryName", Connection))
                {
                    Command.Parameters.AddWithValue("@CountryName", countryName);
                    Connection.Open();
                    object result = Command.ExecuteScalar();
                    if (result != null)
                    {
                        countryID = Convert.ToInt32(result);
                    }
                }
            }
            return countryID;
        }
        public static string GetCountryName(int countryID)
        {
            string countryName = string.Empty;
            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand("SELECT CountryName FROM Countries WHERE CountryID = @CountryID", Connection))
                {
                    Command.Parameters.AddWithValue("@CountryID", countryID);
                    Connection.Open();
                    object result = Command.ExecuteScalar();
                    if (result != null)
                    {
                        countryName = result.ToString();
                    }
                }
            }
            return countryName;
        }
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
                            while (Reader.Read())
                            {
                                Countries.Add(Reader["CountryName"].ToString());
                            }
                        }
                    }
                }
            }
            return Countries;
        }

    }
}
