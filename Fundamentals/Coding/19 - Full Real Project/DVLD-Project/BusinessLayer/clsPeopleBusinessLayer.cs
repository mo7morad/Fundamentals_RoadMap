using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public class PeopleBusinessLayer
    {
        public static DataTable GetAllPeople()
        {
            DataTable dt = DataAccessLayer.clsPeopleDataAccess.GetAllPeople();

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

        public static int AddNewPerson(Entities.clsPerson person)
        {
            return DataAccessLayer.clsPeopleDataAccess.AddNewPerson(person);
        }
    }
}

