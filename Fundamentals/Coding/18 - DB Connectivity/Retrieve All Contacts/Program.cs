using System;
using System.Data;
using System.Net;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

public class Contact
{
    public int ContactID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public int CountryID { get; set; }
}

public class Program
{
    static string connectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=sa123456;";

    public static async Task<List<Contact>> GetAllContactsAsync()
    {
        List<Contact> contacts = new List<Contact>();

        string query = "SELECT * FROM Contacts";

        using (SqlConnection connection = new SqlConnection(connectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            await connection.OpenAsync();
            using (SqlDataReader reader = await command.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    contacts.Add(new Contact
                    {
                        ContactID = reader.GetInt32(0),
                        FirstName = reader["FirstName"] as string ?? "N/A",
                        LastName = reader["LastName"] as string ?? "N/A",
                        Email = reader["Email"] as string ?? "N/A",
                        Phone = reader["Phone"] as string ?? "N/A",
                        Address = reader["Address"] as string ?? "N/A",
                        CountryID = reader.IsDBNull(6) ? 0 : reader.GetInt32(6)
                    });
                }
            }
        }

        return contacts;
    }

    public static async Task PrintAllContactsAsync()
    {
        List<Contact> contacts = await GetAllContactsAsync();

        foreach (var contact in contacts)
        {
            Console.WriteLine($"Contact ID: {contact.ContactID}");
            Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
            Console.WriteLine($"Email: {contact.Email}");
            Console.WriteLine($"Phone: {contact.Phone}");
            Console.WriteLine($"Address: {contact.Address}");
            Console.WriteLine($"Country ID: {contact.CountryID}");
            Console.WriteLine();
        }
    }

    public static async Task Main()
    {
        await PrintAllContactsAsync();
        Console.ReadKey();
    }
}
