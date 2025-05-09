using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsLicensesBusinessLayer
    {
        public static DataTable GetAllLicenseClasses()
        {
            return clsLicensesDataAccess.GetAllLicenseClasses();
        }
    }
}
