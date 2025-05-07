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

        public static bool UpdateApplicationType(int applicationTypeID, string title, decimal fees)
        {
            return clsApplicationTypesDataAccess.UpdateApplicationType(applicationTypeID, title, fees);
        }
    }
}
