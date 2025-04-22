using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsCountriesBusinessLayer
    {
        public static List<string> GetAllCountires()
        {
            return clsCountriesDataAccess.GetAllCountries();
        }
        public static int GetCountryID(string countryName)
        {
            return clsCountriesDataAccess.GetCountryID(countryName);
        }
        public static string GetCountryName(int countryID)
        {
            return clsCountriesDataAccess.GetCountryName(countryID);
        }
    }
}
