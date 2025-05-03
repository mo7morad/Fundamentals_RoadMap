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

        public static clsUser GetUserByUserID(int userID)
        {
            return clsUsersDataAccess.GetUserByUserID(userID);
        }

        public static clsUser GetUserByPersonID(int personID)
        {
            return clsUsersDataAccess.GetUserByPersonID(personID);
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

        public static bool UpdateUser(clsUser user, ref string errorMessage)
        {
            return clsUsersDataAccess.UpdateUser(user, ref errorMessage);
        }

        public static bool ChangeUserPassword(int userID, int newPassword, ref string errorMessage)
        {
            return clsUsersDataAccess.ChangeUserPassword(userID, newPassword, ref errorMessage);
        }
    }
}
