using System;
using System.Transactions;

public class NotificationService
{
    public enum enNotificationType {Email,  SMS,  Fax}

    public void SendNotification(string to, string message,enNotificationType NotificationType)
    {

        if (NotificationType == enNotificationType.Email)
        {
            SendEmail(to, message);
        }
        else if (NotificationType == enNotificationType.SMS)
        {
           SendSMS(to, message);
        } 
        else if (NotificationType == enNotificationType.Fax)
        {
            SendFax(to, message);
        }
    }
    // Method to send email
    private void SendEmail(string to, string message)
    {
        Console.WriteLine($"\nSending Email to {to}: {message}");
    }

    // Method to send SMS
    private void SendSMS(string to, string message)
    {
        Console.WriteLine($"\nSending SMS to {to}: {message}");
    }

    // Method to send Fax
    private void SendFax(string to, string message)
    {
        Console.WriteLine($"\nSending Fax to {to}: {message}");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the NotificationService
        NotificationService notificationService = new NotificationService();

        // Send an email
        notificationService.SendNotification ("john@example.com", "Welcome to our service!",NotificationService.enNotificationType.Email);

        // Send an SMS
        notificationService.SendNotification("+123456789", "Your OTP code is 1234.", NotificationService.enNotificationType.SMS);

        // Send a fax
        notificationService.SendNotification("123-456-789", "Fax Message: Important document.", NotificationService.enNotificationType.Fax);

        Console.ReadKey();

    }
}
