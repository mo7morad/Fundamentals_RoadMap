using System;
using System.Data;
using DataAccessLayer;
using Entities;


namespace BusinessLayer
{
    public class clsUsersBusinessLayer
    {
        public static bool IsUserNameExists(string userName)
        {
            return clsUsersDataAccess.IsUserNameExists(userName);
        }

        public static clsUser GetUserByUserName(string userName)
        {
            return clsUsersDataAccess.GetUserByUserName(userName);
        }

        public static DataTable GetAllUsers()
        {
            return clsUsersDataAccess.GetAllUsers();
        }
    }
}
