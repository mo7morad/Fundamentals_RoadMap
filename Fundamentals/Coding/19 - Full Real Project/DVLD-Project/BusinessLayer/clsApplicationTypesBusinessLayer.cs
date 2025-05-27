using System.Data;
using DataAccessLayer;


namespace BusinessLayer
{
    public class clsApplicationTypesBusinessLayer
    {
        public static DataTable GetApplicationTypes()
        {
            return clsApplicationTypesDataAccess.GetApplicationTypes();
        }

        public static DataTable GetApplicationTypeByID(int applicationTypeID)
        {
            return clsApplicationTypesDataAccess.GetApplicationTypeByID(applicationTypeID);
        }

        public static int GetApplicationFeesByID(int applicationTypeID)
        {
            return clsApplicationTypesDataAccess.GetApplicationFeesByID(applicationTypeID);
        }

        public static bool UpdateApplicationType(int applicationTypeID, string title, decimal fees)
        {
            return clsApplicationTypesDataAccess.UpdateApplicationType(applicationTypeID, title, fees);
        }
        
        // Validation methods for application types
        public static bool ValidateApplicationTypeTitle(string title)
        {
            return !string.IsNullOrWhiteSpace(title);
        }
        
        public static bool ValidateApplicationTypeFees(decimal fees)
        {
            return fees >= 0;
        }
        
        public static bool ValidateApplicationTypeData(string title, decimal fees)
        {
            return ValidateApplicationTypeTitle(title) && ValidateApplicationTypeFees(fees);
        }
    }
}
