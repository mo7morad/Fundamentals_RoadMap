using System;
using System.Data;
using ContactsDataAccessLayer;


namespace ContactBusinessLayer
{
    public class clsCountry
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public string CountryName { set; get; }


        public clsCountry()

        {
            this.ID = -1;
            this.CountryName = "";
            Mode = enMode.AddNew;
        }

        private clsCountry(int ID, string CountryName)

        {
            this.ID = ID;
            this.CountryName = CountryName;
            Mode = enMode.Update;
        }
        public static int AddNewCountry(string CountryName)
        {
            //this function will return the new country id if succeeded and -1 if not.
            int newID = clsCountryData.AddNewCountry(CountryName);
            if (newID > 0)
            {
                return newID;
            }
            else
            {
                return -1;
            }

        }

        public static bool UpdateCountry(int CountryID, string CountryName)
        {
            return clsCountryData.UpdateCountry(CountryID, CountryName);
        }

        public static DataTable ListCountries()
        {
             return clsCountryData.ListCountries();
        }

        public static bool DeleteCountry(int countryID)
        {
            return clsCountryData.DeleteCountry(countryID);
        }

        public static clsCountry FindCountryByID(int countryID)
        {
            string countryName = "";
            if (clsCountryData.FindCountryByID(countryID, ref countryName))
            {
                return new clsCountry(countryID, countryName);
            }
            else
            {
                return null;
            }
        }
        public static clsCountry FindCountryByName(string countryName, ref int countryID)
        {
            if (clsCountryData.FindCountryByName(countryName, ref countryID))
            {
                return new clsCountry(countryID, countryName);
            }
            else
            {
                return null;
            }
        }

        public static bool isCountryExists(int ID)
        {
            return clsCountryData.IsCountryExists(ID);
        }

        public static bool isCountryExists(string CountryName)
        {
            return clsCountryData.IsCountryExists(CountryName);
        }

    }


}
