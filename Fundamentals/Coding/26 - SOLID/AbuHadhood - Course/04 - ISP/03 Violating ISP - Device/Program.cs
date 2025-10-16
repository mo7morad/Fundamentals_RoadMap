using System;

public interface IDevice
{
    void MakeCall();
    void TakePhoto();
    void SendEmail();
    void UseGPS();

}

public class Smartphone : IDevice
{
    public void MakeCall()
    {
        Console.WriteLine("Making a call.");
    }

    public void TakePhoto()
    {
        Console.WriteLine("Taking Photo.");
    }

    public void SendEmail()
    {
        Console.WriteLine("Sending an email.");
    }

    public void UseGPS()
    {
        Console.WriteLine("Using GPS.");
    }
}

public class Computer : IDevice
{
    public void MakeCall()
    {
        throw new NotImplementedException();
    }

    public void TakePhoto()
    {
        throw new NotImplementedException();
    }

    public void SendEmail()
    {
        Console.WriteLine("Sending an email.");
    }

    public void UseGPS()
    {
        throw new NotImplementedException();
    }
}

public class Program
{
    public static void Main()
    {
        IDevice smartphone = new Smartphone();
        Console.WriteLine("SmartPhone:");
        smartphone.MakeCall();
        smartphone.TakePhoto();
        smartphone.SendEmail();
        smartphone.UseGPS();

        IDevice computer = new Computer();
        Console.WriteLine("\nComputer:");
        computer.SendEmail();
        //computer.TakePhoto();// This will throw an exception.
        //computer.SendEmail();// This will throw an exception.
        //computer.UseGPS();// This will throw an exception.
        

        Console.ReadKey();

        
    }
}
