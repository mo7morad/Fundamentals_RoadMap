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

            // Add a new column for formatted gender
            dt.Columns.Add("Person Gender", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                if (row["Gender"] != DBNull.Value)
                {
                    bool gender = Convert.ToBoolean(row["Gender"]);
                    row["Person Gender"] = gender ? "Female" : "Male";
                }
                else
                {
                    row["Person Gender"] = "Unknown"; // Optional
                }
            }

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

