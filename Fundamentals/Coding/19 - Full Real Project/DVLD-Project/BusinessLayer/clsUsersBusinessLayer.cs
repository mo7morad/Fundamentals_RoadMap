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
            return clsUserDataAccess.IsUserNameExists(userName);
        }

        public static clsUser GetUserByUserName(string userName)
        {
            return clsUserDataAccess.GetUserByUserName(userName);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }
    }
}
