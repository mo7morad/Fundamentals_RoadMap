using System;

public interface ICallDevice
{
    void MakeCall();
}


public interface IPhotoDevice
{
    void TakePhoto();
}

public interface IEmailDevice
{
    void SendEmail();
}


public interface IGPSDevice
{
    void UseGPS();

}

//This new interface inherited all interfaces mentioned below , which means
// that they became part of it, and you can add more methods to it as well
public interface ISmartPhone : ICallDevice, IPhotoDevice, IEmailDevice, IGPSDevice
{

}

public class Smartphone : ISmartPhone
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

public class Computer : IEmailDevice
{

    public void SendEmail()
    {
        Console.WriteLine("Sending an email.");
    }

}

public class NormalCamera: IPhotoDevice
{
    public void TakePhoto()
    {
        Console.WriteLine("Taking Photo.");
    }

}


//This new interface inherited all interfaces mentioned below , which means
// that they became part of it, and you can add more methods to it as well
public interface IAdvancedCamera: IPhotoDevice, IEmailDevice
{

}
public class AdvancedCamera : IAdvancedCamera
{
    public void TakePhoto()
    {
        Console.WriteLine("Taking Photo.");
    }

    public void SendEmail()
    {
        Console.WriteLine("Sending Email.");
    }
}

public class Program
{
    public static void Main()
    {
        Smartphone smartphone = new Smartphone();
        Console.WriteLine("SmartPhone:");
        smartphone.MakeCall();
        smartphone.TakePhoto();
        smartphone.SendEmail();
        smartphone.UseGPS();

        Computer computer = new Computer();
        Console.WriteLine("\nComputer:");
        computer.SendEmail();


        NormalCamera normalCamera = new NormalCamera();
        Console.WriteLine("\nNormal Camera:");
        normalCamera.TakePhoto();


        AdvancedCamera advancedCamera = new AdvancedCamera();
        Console.WriteLine("\nAdvanced Camera:");
        advancedCamera.TakePhoto();
        advancedCamera.SendEmail();

        Console.ReadKey();


    }
}
