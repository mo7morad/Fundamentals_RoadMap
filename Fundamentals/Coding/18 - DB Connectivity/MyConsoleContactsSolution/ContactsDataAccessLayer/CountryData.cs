using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace ContactsDataAccessLayer
{
    public class clsCountryData
    {
        public static int AddNewCountry(string CountryName)
        {
            string query = @"INSERT INTO Countries (CountryName) VALUES (@CountryName);
                    SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CountryName", CountryName);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int newId))
                        return newId;
                    else
                        return -1;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error adding country: {ex.Message}");
                    return -1;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static bool UpdateCountry(int CountryID, string CountryName)
        {
            string query = @"UPDATE Countries
                            SET CountryName = @CountryName
                            WHERE CountryID = @CountryID";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CountryID", CountryID);
                command.Parameters.AddWithValue("@CountryName", CountryName);

                try
                {
                    connection.Open();
                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows > 0)
                        return true;
                    else
                        return false;
                }

                catch
                {
                    return false;
                }
            }
        }

        public static DataTable ListCountries()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Countries";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Database error: {ex.Message}");
                    dt = null; // Or return an empty DataTable
                }
            }

            return dt ?? new DataTable(); // Null-coalescing for safety
        }


        public static bool DeleteCountry(int countryID)
        {
            string query = "DELETE FROM Countries WHERE CountryID = @CountryID";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CountryID", countryID);
                try
                {
                    connection.Open();
                    int affectedRows = command.ExecuteNonQuery();
                    return affectedRows > 0;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error deleting country: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool FindCountryByID(int countryID, ref string countryName)
        {
            string query = "SELECT * FROM Countries WHERE CountryID = @CountryID";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CountryID", countryID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            countryName = reader["CountryName"].ToString();
                            return true;
                        }
                        else
                        {
                            countryName = "";
                            return false;
                        }
                    }

                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error finding country: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool FindCountryByName(string countryName, ref int countryID)
        {
            string query = "SELECT * FROM Countries WHERE CountryName = @CountryName";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CountryName", countryName);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            countryID = Convert.ToInt32(reader["CountryID"]);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error finding country: {ex.Message}");
                    return false;
                }
            }

        }

        public static bool IsCountryExists(int countryID)
        {
            string query = "SELECT COUNT(*) FROM Countries WHERE CountryID = @CountryID";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CountryID", countryID);
                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error checking country existence: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool IsCountryExists(string countryName)
        {
            string query = "SELECT COUNT(*) FROM Countries WHERE CountryName = @CountryName";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CountryName", countryName);
                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error checking country existence: {ex.Message}");
                    return false;
                }
            }
        }
    }
}

