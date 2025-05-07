using System;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class clsApplicationTypesDataAccess
    {
        public static DataTable GetApplicationTypes()
        {
            DataTable dtApplicationTypes = new DataTable();
            try
            {
                string query = "SELECT * FROM ApplicationTypes";
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if(reader.HasRows)
                                dtApplicationTypes.Load(reader);
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
            return dtApplicationTypes;
        }

        public static bool UpdateApplicationType(int applicationTypeID, string title, decimal fees)
        {
            try
            {
                string query = @"UPDATE ApplicationTypes 
                        SET ApplicationTypeTitle = @Title, 
                            ApplicationFees = @Fees 
                        WHERE ApplicationTypeID = @ID";

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Fees", fees);
                        command.Parameters.AddWithValue("@ID", applicationTypeID);

                        connection.Open();
                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error updating application type: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred: " + ex.Message);
            }
        }

        public static DataTable GetApplicationTypeByID(int applicationTypeID)
        {
            DataTable dtApplicationType = new DataTable();
            try
            {
                string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ID";
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", applicationTypeID);
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtApplicationType.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error retrieving application type: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred: " + ex.Message);
            }
            return dtApplicationType;
        }

    }
}