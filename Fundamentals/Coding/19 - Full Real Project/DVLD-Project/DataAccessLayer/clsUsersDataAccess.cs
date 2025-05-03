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

        public static bool IsUserExist(int personID)
        {
            bool exists = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE PersonID = @PersonID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
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
                            clsPerson person = clsPeopleDataAccess.GetPersonByID(Convert.ToInt32(Reader["PersonID"]));
                            if (person != null)
                            {
                                user = new clsUser(person,
                                    Convert.ToInt32(Reader["UserID"]),
                                    Reader["UserName"].ToString(),
                                    Reader["Password"].ToString(),
                                    bool.Parse(Reader["IsActive"].ToString())
                                );
                            }
                        }
                    }
                }
                return user;
            }
        }

        public static clsUser GetUserByUserID(int userID)
        {
            clsUser user = null;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Users WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    connection.Open();
                    using (SqlDataReader Reader = command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            clsPerson person = clsPeopleDataAccess.GetPersonByID(Convert.ToInt32(Reader["PersonID"]));
                            if (person != null)
                            {
                                user = new clsUser(person,
                                    Convert.ToInt32(Reader["UserID"]),
                                    Reader["UserName"].ToString(),
                                    Reader["Password"].ToString(),
                                    bool.Parse(Reader["IsActive"].ToString())
                                );
                            }
                        }
                    }
                }
                return user;
            }
        }
    
        public static clsUser GetUserByPersonID(int personID)
        {
            clsUser user = null;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Users WHERE PersonID = @PersonID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
                    connection.Open();
                    using (SqlDataReader Reader = command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            clsPerson person = clsPeopleDataAccess.GetPersonByID(personID);
                            if (person != null)
                            {
                                int userId = Convert.ToInt32(Reader["UserID"]);
                                user = new clsUser(person, userId, Reader["UserName"].ToString(), Reader["Password"].ToString(), bool.Parse(Reader["IsActive"].ToString()));
                            }
                        }
                    }
                }
            }
            return user;
        }

        public static string GetUserPassword(int userID, ref string errorMessage)
        {
            string password = string.Empty;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Password FROM Users WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            password = result.ToString();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                errorMessage = ex.Message;
            }
            catch (Exception ex)
            {
                errorMessage = "Unexpected error: " + ex.Message;
            }
            return password;
        }
    
        public static int AddNewUser(clsUser user, ref string errorMessage)
        {
            try
            {
                int newUserId = 0;
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    // Modified query to return the inserted ID
                    string query = @"INSERT INTO Users (PersonID, UserName, Password, IsActive) 
                         VALUES (@PersonID, @UserName, @Password, @IsActive);
                         SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", user.PersonID);
                        command.Parameters.AddWithValue("@UserName", user.UserName);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.Parameters.AddWithValue("@IsActive", user.IsActive);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            newUserId = Convert.ToInt32(result);
                        }
                    }
                }
                return newUserId;
            }
            catch (SqlException ex)
            {
                errorMessage = ex.Message;
                return -1;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return -1;
            }
        }
    
        public static bool DeleteUser(int userID, ref string errorMessage)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE FROM Users WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        conn.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                errorMessage = ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                errorMessage = "Unexpected error: " + ex.Message;
                return false;
            }
        }
    
        public static bool UpdateUser(clsUser user, ref string errorMessage)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE Users 
                                     SET UserName = @UserName, 
                                         Password = @Password, 
                                         IsActive = @IsActive 
                                     WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", user.UserID);
                        cmd.Parameters.AddWithValue("@UserName", user.UserName);
                        cmd.Parameters.AddWithValue("@Password", user.Password);
                        cmd.Parameters.AddWithValue("@IsActive", user.IsActive);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                errorMessage = ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                errorMessage = "Unexpected error: " + ex.Message;
                return false;
            }
        }
  
        public static bool ChangeUserPassword(int userID, int newPassword, ref string errorMessage)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "UPDATE Users SET Password = @Password WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@Password", newPassword);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                errorMessage = ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                errorMessage = "Unexpected error: " + ex.Message;
                return false;
            }
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


