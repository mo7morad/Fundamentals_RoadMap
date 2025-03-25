using System;
using System.Data;
using System.Net;
using System.Data.SqlClient;

public class Program
{
    static string connectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=sa123456;";


    public struct stContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }
    }


    static void AddNewContactAndGetID(stContact newContact)
    {


          SqlConnection connection = new SqlConnection(connectionString);
        
            string query = @"INSERT INTO Contacts (FirstName, LastName, Email, Phone, Address, CountryID)
                             VALUES (@FirstName, @LastName, @Email, @Phone, @Address, @CountryID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            
                command.Parameters.AddWithValue("@FirstName", newContact.FirstName);
                command.Parameters.AddWithValue("@LastName", newContact.LastName);
                command.Parameters.AddWithValue("@Email", newContact.Email);
                command.Parameters.AddWithValue("@Phone", newContact.Phone);
                command.Parameters.AddWithValue("@Address", newContact.Address);
                command.Parameters.AddWithValue("@CountryID", newContact.CountryID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        Console.WriteLine($"Newly inserted ID: {insertedID}");
                    }
                    else
                    {
                        Console.WriteLine("Failed to retrieve the inserted ID.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
        connection.Close();
            
        
    }


    public static void Main()
    {

        // Create a new contact with the required information
        stContact Contact = new stContact
        {
            FirstName = "Laila",
            LastName = "Maher",
            Email = "m@example.com",
            Phone = "1234567890",
            Address = "123 Main Street",
            CountryID = 1
        };

        AddNewContactAndGetID(Contact);

        Console.ReadKey();

    }

}
