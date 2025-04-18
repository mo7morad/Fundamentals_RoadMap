using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Entities
{
    class clsCountries
    {
        int countryID;
        string countryName;

        clsCountries(int CountryID, string CountryName)
        {
            this.countryID = CountryID;
            this.countryName = CountryName;
        }
    }
}
