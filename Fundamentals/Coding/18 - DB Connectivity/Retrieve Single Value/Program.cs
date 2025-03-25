using System;
using System.Data;
using System.Net;
using System.Data.SqlClient;

public class Program
{
    static string connectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=123456;"; // Replace with your actual connection string


    static String  GetFirstName(int ContactID)
    {

       string FirstName="";

       SqlConnection connection = new SqlConnection(connectionString);

        string query = "SELECT FirstName FROM Contacts WHERE ContactID=@ContactID";

  
        SqlCommand command = new SqlCommand(query, connection);
      
        command.Parameters.AddWithValue("@ContactID", ContactID);

        try
        {
            connection.Open();

                object result = command.ExecuteScalar() ;

                if (result != null )
                {
             
                  FirstName = result.ToString() ;    
                }
                else
                {
                    FirstName = "";
                }


            connection.Close();
                    

        }


                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

        return FirstName;
    }

    public static void Main()
    {
      Console.WriteLine(GetFirstName(1));
      Console.ReadKey();

    }

}
