using System;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class clsTestsDataAccess
    {
        public static DataTable GetAllTestTypes()
        {
            DataTable dtTestTypes = new DataTable();

            string query = "select TestTypeID AS 'ID' , TestTypeTitle AS 'Title', TestTypeDescription AS 'Description', TestTypeFees AS 'Fees' from TestTypes\r\n";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            dtTestTypes.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error retrieving test types: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred: " + ex.Message);
            }
            return dtTestTypes;
        }

        public static DataTable GetTestByID(int testID)
        {
            DataTable dtTestTypes = new DataTable();
            string query = "SELECT TestTypeID AS 'ID' , TestTypeTitle AS 'Title', TestTypeDescription AS 'Description', TestTypeFees AS 'Fees' FROM TestTypes WHERE TestTypeID = @TestTypeID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeID", testID);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            dtTestTypes.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error retrieving test type: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred: " + ex.Message);
            }
            return dtTestTypes;
        }
        
        public static bool UpdateTestType(int testTypeID, string title, string description, decimal fees)
        {
            try
            {
                string query = "UPDATE TestTypes SET TestTypeTitle = @Title, TestTypeDescription = @Description, TestTypeFees = @Fees WHERE TestTypeID = @TestTypeID";
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeID", testTypeID);
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@Fees", fees);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error updating test type: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
