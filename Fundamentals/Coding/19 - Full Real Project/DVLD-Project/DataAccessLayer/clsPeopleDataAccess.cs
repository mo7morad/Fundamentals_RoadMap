using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsPeopleDataAccess
    {
        public static bool IsNationalNoExists(string nationalNo)
        {
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM People WHERE NationalNo = @NationalNo";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NationalNo", nationalNo);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public static DataTable GetAllPeople()
        {
            DataTable People = new DataTable();

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                               CASE Gender 
                                  WHEN 0 THEN 'Male'
                                  WHEN 1 THEN 'Female'
                                  ELSE 'Unknown'
                                END AS Gender,
                                DateOfBirth,
                                CountryName,
                                Phone,
                                Email
                                FROM People
                                JOIN Countries ON People.NationalityCountryID = Countries.CountryID";

                using (SqlCommand Command = new SqlCommand(query, Connection))
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
                    int countryID = clsCountriesDataAccess.GetCountryID(person.Country);

                    cmd.Parameters.Add("@NationalNo", SqlDbType.NVarChar, 50).Value = person.NationalNo;
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Value = person.FirstName;
                    cmd.Parameters.Add("@SecondName", SqlDbType.NVarChar, 50).Value = person.SecondName;
                    cmd.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 50).Value = person.ThirdName;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Value = person.LastName;
                    cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = person.DateOfBirth;
                    cmd.Parameters.Add("@Gender", SqlDbType.Bit).Value = person.Gender;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 255).Value = person.Address;
                    cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Value = person.Phone;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = person.Email;
                    cmd.Parameters.Add("@NationalityCountryID", SqlDbType.Int).Value = countryID;
                    cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 500).Value =
                    string.IsNullOrEmpty(person.ImagePath) ? DBNull.Value : (object)person.ImagePath;

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
