using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;


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

        public static void OnSavePerson(Entities.clsPerson person)
        {
        }

        public static int AddNewPerson(Entities.clsPerson person)
        {
            return clsPeopleDataAccess.AddNewPerson(person);
        }
    }
}

