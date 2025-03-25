using System;
using System.Data;
using System.Data.SqlClient;

public class Program
{
    static string connectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=sa123456;";

    static void DeleteContacts(string ContactIDs)
    {
        string query = "DELETE FROM Contacts WHERE ContactID IN (" + ContactIDs + ")";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Records deleted successfully.");
                }
                else
                {
                    Console.WriteLine("No records deleted.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    public static void Main()
    {
        DeleteContacts("8,9,10");
        Console.ReadKey();
    }
}
