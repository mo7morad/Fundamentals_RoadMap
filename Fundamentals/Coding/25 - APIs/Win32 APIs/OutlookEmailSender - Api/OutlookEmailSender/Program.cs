using System;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookEmailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Outlook.Application outlookApp = new Outlook.Application();
                Outlook.MailItem mailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
                mailItem.Subject = "Test Email from C#";
                mailItem.To = "recipient@example.com";  // Change this to the actual recipient's email address
                mailItem.Body = "Hello, this is a test email sent from a C# application using Outlook Interop.";
                mailItem.Importance = Outlook.OlImportance.olImportanceHigh;
                mailItem.Display(false);  // Set to true to display the email before sending
                mailItem.Send();
                Console.WriteLine("Email sent successfully!");
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadKey();  // Keeps the console window open
        }
    }
}
