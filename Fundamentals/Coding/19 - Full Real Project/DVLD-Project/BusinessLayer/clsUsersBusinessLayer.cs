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

        public static bool IsUserExist(int personID)
        {
            return clsUsersDataAccess.IsUserExist(personID);
        }

        public static clsUser GetUserByUserName(string userName)
        {
            return clsUsersDataAccess.GetUserByUserName(userName);
        }

        public static DataTable GetAllUsers()
        {
            return clsUsersDataAccess.GetAllUsers();
        }

        public static int AddNewUser(clsUser user, ref string errorMessage)
        {
            return clsUsersDataAccess.AddNewUser(user, ref errorMessage);
        }

        public static bool DeleteUser(int userID, ref string errorMessage)
        {
            return clsUsersDataAccess.DeleteUser(userID, ref errorMessage);
        }
    }
}
