namespace Entities
{
    public class clsCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountry(int countryID, string countryName)
        {
            this.CountryID = countryID;
            this.CountryName = countryName;
        }
    }
}
