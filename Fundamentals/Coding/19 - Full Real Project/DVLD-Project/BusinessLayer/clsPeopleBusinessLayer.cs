using System.Data;
using DataAccessLayer;
using Entities;


namespace BusinessLayer
{
    public class clsPeopleBusinessLayer
    {
        public static bool IsNationalNoExists(string nationalNo)
        {
            return clsPeopleDataAccess.IsNationalNoExists(nationalNo);
        }
        public static DataTable GetAllPeople()
        {
            return clsPeopleDataAccess.GetAllPeople();
        }
        public static clsPerson GetPersonByID(int personID)
        {
            return clsPeopleDataAccess.GetPersonByID(personID);
        }
        public static clsPerson GetPersonByNationalNo(string nationalNumber)
        {
            return clsPeopleDataAccess.GetPersonByNationalNo(nationalNumber);
        }
        public static int AddNewPerson(Entities.clsPerson person, ref string errorMessage)
        {
            return clsPeopleDataAccess.AddNewPerson(person, ref errorMessage);
        }
        public static bool UpdatePerson(Entities.clsPerson person, ref string errorMessage)
        {
            return clsPeopleDataAccess.UpdatePerson(person, ref errorMessage);
        }
        public static bool DeletePerson(int personID, ref string errorMessage)
        {
            return clsPeopleDataAccess.DeletePerson(personID, ref errorMessage);
        }
    }
}

