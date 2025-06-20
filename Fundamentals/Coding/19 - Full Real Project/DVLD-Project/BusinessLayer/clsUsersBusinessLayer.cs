using System;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;
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

        public static int GetUserIDByUserName(string userName, ref string errorMsg)
        {
            return clsUsersDataAccess.GetUserIDByUserName(userName, ref errorMsg);
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

        // Added validation methods from UI layer
        public static bool ValidateUsername(string username, int userId = -1)
        {
            if (string.IsNullOrWhiteSpace(username))
                return false;

            if (username.Length < 3)
                return false;

            // For new user or if username changed for existing user
            if (userId == -1)
            {
                return !IsUserNameExists(username);
            }
            else
            {
                clsUser currentUser = GetUserByUserID(userId);
                if (currentUser != null && currentUser.UserName != username)
                {
                    return !IsUserNameExists(username);
                }
                return true;
            }
        }

        public static bool ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            return password.Length >= 6;
        }

        public static bool AuthenticateUser(string username, string password)
        {
            // if the username or password are empty, return false
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            // Check if the user exists in the database
            if (!IsUserNameExists(username))
            {
                return false;
            }

            // if user exists, verify password and check if active
            clsUser user = GetUserByUserName(username);
            if (user == null)
                return false;

            if (!user.IsActive)
                return false;

            return user.Password == password;
        }
    }
}
