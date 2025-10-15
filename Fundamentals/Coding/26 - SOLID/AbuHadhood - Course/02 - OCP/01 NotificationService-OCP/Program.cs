using System;
using System.Transactions;

public class NotificationService
{
    private INotification _Notification;

    public NotificationService ( INotification Notification)
    {
        _Notification=Notification;
    }

    public void SendNotification(string to, string message)
    {

       
        _Notification.Send(to, message);


    }
   
}

public interface INotification
{
    public void Send(string to, string message);
}


public class EmailService:INotification 
{
    // Method to send email
    public   void Send(string to, string message)
    {
        Console.WriteLine($"\nSending Email to {to}: {message}");
    }

}

public class SMSService:INotification
{
    // Method to send SMS
    public  void Send(string to, string message)
    {
        Console.WriteLine($"\nSending SMS to {to}: {message}");
    }
}

public class FaxService:INotification
{
    // Method to send Fax
    public  void Send(string to, string message)
    {
        Console.WriteLine($"\nSending Fax to {to}: {message}");
    }
}

public class TelegramService:INotification 
{
    // Method to send Telegram
    public  void Send(string to, string message)
    {
        Console.WriteLine($"\nSending Telegram to {to}: {message}");
    }
}


public class WhatsappService:INotification
{
    // Method to send whatsapp
    public  void Send(string to, string message)
    {
        Console.WriteLine($"\nSending Whatsapp to {to}: {message}");
    }
}


public class SnappChatService : INotification
{
    // Method to send whatsapp
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending SnappChat to {to}: {message}");
    }
}

public class TikTokService : INotification
{
    // Method to send whatsapp
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending TikTok to {to}: {message}");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the NotificationService
        NotificationService notificationService = new NotificationService( new EmailService()  );


        // Send an email
        notificationService.SendNotification("john@example.com", "Welcome to our service!");

        notificationService = new NotificationService(new SMSService());

        // Send an SMS
        notificationService.SendNotification("+123456789", "Your OTP code is 1234.");

        notificationService = new NotificationService(new FaxService());

        // Send a fax
        notificationService.SendNotification("123-456-789", "Fax Message: Important document.");

        notificationService = new NotificationService(new TelegramService());

        // Send a telegram
        notificationService.SendNotification("123-456-789", "Telegram Message: Important message.");

        notificationService = new NotificationService(new WhatsappService());

        // Send a whatsapp
        notificationService.SendNotification("123-456-789", "Whatsapp Message: Important message.");

        notificationService = new NotificationService(new SnappChatService());

        // Send a SnappChat
        notificationService.SendNotification("123-456-789", "SnappChat Message: Important message.");

        notificationService = new NotificationService(new TikTokService());

        // Send a SnappChat
        notificationService.SendNotification("123-456-789", "TikTok Message: Important message.");


        Console.ReadKey();

    }
}
