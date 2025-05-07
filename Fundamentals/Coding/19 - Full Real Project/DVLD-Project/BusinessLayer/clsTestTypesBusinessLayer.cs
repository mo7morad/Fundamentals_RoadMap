using System.Data;
using DataAccessLayer;


namespace BusinessLayer
{
    public class clsTestTypesBusinessLayer
    {
        public static DataTable GetAllTestTypes()
        {
            return clsTestsDataAccess.GetAllTestTypes();
        }

        public static DataTable GetTestTypeByID(int testTypeID)
        {
            return clsTestsDataAccess.GetTestByID(testTypeID);
        }

        public static bool UpdateTestType(int testTypeID, string title, string description, decimal fees)
        {
            return clsTestsDataAccess.UpdateTestType(testTypeID, title, description, fees);
        }
    }
}
