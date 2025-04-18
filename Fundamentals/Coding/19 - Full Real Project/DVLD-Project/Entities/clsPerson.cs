using System;

namespace Entities
{
    public class clsPerson
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string CountryID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ImagePath { get; set; }
        public string Email { get; set; }
        public clsPerson(string nationalNo, string firstName, string secondName, string thirdName, string lastName,
        DateTime dateOfBirth, bool gender, string address, string phone, string countryID, string email, string imagePath = null)
        {
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            Phone = phone;
            CountryID = countryID;
            ImagePath = imagePath;
            Email = email;
        }
    }
}
