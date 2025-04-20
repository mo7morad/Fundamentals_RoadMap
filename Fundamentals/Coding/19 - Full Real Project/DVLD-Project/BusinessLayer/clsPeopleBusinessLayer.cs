using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            DataTable dt = clsPeopleDataAccess.GetAllPeople();

            return dt;
        }
        public static clsPerson GetPersonByID(int personID)
        {
            return clsPeopleDataAccess.GetPersonByID(personID);
        }
        public static int AddNewPerson(Entities.clsPerson person)
        {
            return clsPeopleDataAccess.AddNewPerson(person);
        }
        public static bool DeletePerson(int personID, ref string errorMessage)
        {
            return clsPeopleDataAccess.DeletePerson(personID, ref errorMessage);
        }
    }
}

