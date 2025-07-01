using System;
using System.Security.Cryptography;
using System.Text;


class Program
{
    static void Main()
    {
        // Original data
        string originalData = "Sensitive information";

        // Key for AES encryption (128-bit key)
       // The key is a string representation of the key used for AES encryption.
       // In the context of AES, the key size determines the strength of the encryption.
       // For AES, the key size options are 128 bits, 192 bits, and 256 bits.
       // You should provide a key with 16 characters long,
       // which corresponds to a 128-bit key.
       // Each character represents one byte (8 bits),
       // so 16 characters * 8 bits/character = 128 bits.
        string key = "1234567890123456";


        // Encrypt the original data
        string encryptedData = Encrypt(originalData, key);

        // Decrypt the encrypted data
        string decryptedData = Decrypt(encryptedData, key);


        // Display results
        Console.WriteLine($"Original Data: {originalData}");
        Console.WriteLine($"Encrypted Data: {encryptedData}");
        Console.WriteLine($"Decrypted Data: {decryptedData}");
        Console.ReadKey();

    }


    static string Encrypt(string plainText, string key)
    {
        using (Aes aesAlg = Aes.Create())
        {
            // Set the key and IV for AES encryption
            aesAlg.Key = Encoding.UTF8.GetBytes(key);

            /*
            Here, you are setting the IV of the AES algorithm to a block of bytes 
            with a size equal to the block size of the algorithm divided by 8. 
            The block size of AES is typically 128 bits (16 bytes), 
            so the IV size is 128 bits / 8 = 16 bytes.
             */
            aesAlg.IV = new byte[aesAlg.BlockSize / 8];


            // Create an encryptor
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);


            // Encrypt the data
            using (var msEncrypt = new System.IO.MemoryStream())
            {
                using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                {
                    swEncrypt.Write(plainText);
                }

                // Return the encrypted data as a Base64-encoded string
                return Convert.ToBase64String(msEncrypt.ToArray());
            }
        }
    }

    static string Decrypt(string cipherText, string key)
    {
        using (Aes aesAlg = Aes.Create())
        {
            // Set the key and IV for AES decryption
            aesAlg.Key = Encoding.UTF8.GetBytes(key);
            aesAlg.IV = new byte[aesAlg.BlockSize / 8];


            // Create a decryptor
            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);


            // Decrypt the data
            using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
            using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
            using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
            {
                // Read the decrypted data from the StreamReader
                return srDecrypt.ReadToEnd();
            }
        }
    }
}