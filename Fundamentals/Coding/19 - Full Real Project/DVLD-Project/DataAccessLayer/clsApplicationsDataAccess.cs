using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsApplicationsDataAccess
    {
        public static DataTable GetAllApplications()
        {
            DataTable dtApplications = new DataTable();
            try
            {
                string query = "SELECT * FROM Applications";
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtApplications.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error retrieving application types: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred: " + ex.Message);
            }
            return dtApplications;
        }

    }
}
