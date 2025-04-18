using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsPeopleDataAccess
    {
        public static DataTable GetAllPeople()
        {
            DataTable People = new DataTable();

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand("SELECT * FROM People", Connection))
                {
                    Connection.Open();
                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            People.Load(Reader);
                        }
                    }
                }
            }

            return People;
        }

        public static int AddNewPerson(Entities.clsPerson person)
        {
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO People 
                               (NationalNo, FirstName, SecondName, ThirdName, 
                                LastName, DateOfBirth, Gender, Address, Phone,
                                Email, NationalityCountryID, ImagePath)
                         VALUES 
                            (@NationalNo, @FirstName, @SecondName, @ThirdName,
                            @LastName, @DateOfBirth, @Gender, @Address, @Phone,
                            @Email, @NationalityCountryID, @ImagePath);
                        SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NationalNo", person.NationalNo);
                    cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
                    cmd.Parameters.AddWithValue("@SecondName", person.SecondName);
                    cmd.Parameters.AddWithValue("@ThirdName", person.ThirdName);
                    cmd.Parameters.AddWithValue("@LastName", person.LastName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Gender", person.Gender ? 0 : 1);
                    cmd.Parameters.AddWithValue("@Address", person.Address ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Phone", person.Phone ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Email", person.Email ?? string.Empty);
                    cmd.Parameters.AddWithValue("@NationalityCountryID", person.CountryID);
                    cmd.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(person.ImagePath) ? DBNull.Value : (object)person.ImagePath);

                    conn.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int newPersonId))
                    {
                        return newPersonId;
                    }
                    else
                    {
                        throw new Exception("Failed to insert new person");
                    }
                }
            }
        }
    }
}
