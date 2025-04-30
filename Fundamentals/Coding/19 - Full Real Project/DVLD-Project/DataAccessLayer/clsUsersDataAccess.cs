using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsUsersDataAccess
    {
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
