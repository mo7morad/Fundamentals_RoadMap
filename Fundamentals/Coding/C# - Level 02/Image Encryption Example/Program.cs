using System;
using System.IO;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        string inputFile = "c:\\Image\\MyImage.jpg";
        string encryptedFile = "c:\\Image\\encrypted.jpg";
        string decryptedFile = "c:\\Image\\decrypted.jpg";

        // Generate a random IV for each encryption operation
        byte[] iv;
        using (Aes aesAlg = Aes.Create())
        {
            iv = aesAlg.IV;
        }

        string key = "1234567890123456";

        EncryptFile(inputFile, encryptedFile, key, iv);
        DecryptFile(encryptedFile, decryptedFile, key, iv);

        Console.WriteLine("Encryption and decryption completed successfully.");
        Console.WriteLine("go to c:\\Image folder to see the results");
        Console.ReadKey();  

    }

    static void EncryptFile(string inputFile, string outputFile, string key, byte[] iv)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = System.Text.Encoding.UTF8.GetBytes(key);
            aesAlg.IV = iv;

            using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
            using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
            using (ICryptoTransform encryptor = aesAlg.CreateEncryptor())
            using (CryptoStream cryptoStream = new CryptoStream(fsOutput, encryptor, CryptoStreamMode.Write))
            {
                // Write the IV to the beginning of the file
                fsOutput.Write(iv, 0, iv.Length);
                fsInput.CopyTo(cryptoStream);
            }
        }
    }

    static void DecryptFile(string inputFile, string outputFile, string key, byte[] iv)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = System.Text.Encoding.UTF8.GetBytes(key);
            aesAlg.IV = iv;

            using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
            using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
            using (ICryptoTransform decryptor = aesAlg.CreateDecryptor())
            using (CryptoStream cryptoStream = new CryptoStream(fsOutput, decryptor, CryptoStreamMode.Write))
            {
                // Skip the IV at the beginning of the file
                fsInput.Seek(iv.Length, SeekOrigin.Begin);
                fsInput.CopyTo(cryptoStream);
            }
        }
    }
}
