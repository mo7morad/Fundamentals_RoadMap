using System;
using System.Data;
using System.Data.SqlClient;
using Entities;

namespace DataAccessLayer
{
    public class clsUsersDataAccess
    {
        public static bool IsUserNameExists(string userName)
        {
            bool exists = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    exists = count > 0;
                }
            }
            return exists;
        }

        public static clsUser GetUserByUserName(string userName)
        {
            clsUser user = null;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Users WHERE UserName = @UserName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    connection.Open();
                    using (SqlDataReader Reader = command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            user = new clsUser(
                                       Convert.ToInt32(Reader["UserID"]),
                                       bool.Parse(Reader["IsActive"].ToString()),
                                       Reader["UserName"].ToString(),
                                       Reader["Password"].ToString()
                                            );
                        }
                    }
                }
            }
            return user;
        }

        public static DataTable GetAllUsers()
        {
            DataTable users = new DataTable();

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT 
                                Users.UserID AS 'User ID', 
                                Users.PersonID AS 'Person ID', 
                                Users.UserName AS 'User Name', 
                                CONCAT(People.FirstName, ' ', People.SecondName, ' ', People.ThirdName, ' ', People.LastName) AS 'Full Name',
                                Users.IsActive AS 'Is Active'
                                FROM Users
                                JOIN People ON Users.PersonID = People.PersonID;";

                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Connection.Open();
                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            users.Load(Reader);
                        }
                    }
                }
            }
            return users;
        }
    }
}


