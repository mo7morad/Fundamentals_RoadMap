using System;
using System.Data;
using System.Data.SqlClient;

public class Program
{
    static string connectionString = "Server=.;Database=contactsDB;User Id=sa;Password=sa123456;";

    static Contact FindContactByID(int ContactID)
    {
        Contact contact = null;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Contacts WHERE ContactID = @ContactID";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ContactID", ContactID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            contact = new Contact
                            {
                                ID = (int)reader["ContactID"],
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Email = reader["Email"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Address = reader["Address"].ToString(),
                                CountryID = (int)reader["CountryID"]
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        return contact;
    }

    public class Contact
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }
    }

    public static void Main()
    {
        Contact contact = FindContactByID(5);

        if (contact != null)
        {
            Console.WriteLine($"\nContact ID: {contact.ID}");
            Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
            Console.WriteLine($"Email: {contact.Email}");
            Console.WriteLine($"Phone: {contact.Phone}");
            Console.WriteLine($"Address: {contact.Address}");
            Console.WriteLine($"Country ID: {contact.CountryID}");
        }
        else
        {
            Console.WriteLine("Contact is not found.");
        }

        Console.ReadKey();
    }
}
