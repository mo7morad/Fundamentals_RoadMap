using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsCountriesBussinessLayer
    {
        public static List<string> GetAllCountires()
        {
            return clsCountriesDataAccess.GetAllCountries();
        }
    }
}
