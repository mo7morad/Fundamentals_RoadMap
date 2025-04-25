using System;
using System.Data;
using System.Collections.Generic;
using Entities;
using System.Data.SqlClient;
using System.Collections;

namespace DataAccessLayer
{
    public class clsUserDataAccess
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

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Users";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader Reader = command.ExecuteReader())
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
