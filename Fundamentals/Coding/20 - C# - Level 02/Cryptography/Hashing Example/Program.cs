using System;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main()
    {
        // Input data
        string data = "Mohammed Morad";

        // Compute the SHA-256 hash of the input data
        string hashedData = ComputeHash(data);

        // Display the original data and its hash
        Console.WriteLine($"Original Data: {data}");
        Console.WriteLine($"Hashed Data: {hashedData}");

        /*
         The SHA-256 hash output is represented as a 64-character hexadecimal string 
         because each character in a hexadecimal representation represents 4 bits. 
         Since SHA-256 produces a 256-bit hash value, 
         the hexadecimal representation requires 256 bits / 4 bits per character = 64 characters.
         */
        Console.WriteLine($"Hashed Data Length: {hashedData.Length}");


        // Pause to keep the console window open for viewing the results
        Console.ReadKey();
    }

    static string ComputeHash(string input)
    {
        //SHA is Secutred Hash Algorithm.
        // Create an instance of the SHA-256 algorithm
        using (SHA256 sha256 = SHA256.Create())
        {
            // Compute the hash value from the UTF-8 encoded input string
            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Convert the byte array to a lowercase hexadecimal string
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }
    }

}
