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


public class Smartphone : ICallDevice, IPhotoDevice, IEmailDevice, IGPSDevice
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


public class Camera: IPhotoDevice
{
    public void TakePhoto()
    {
        Console.WriteLine("Taking Photo.");
    }
}

public class AdvancedCamera : IPhotoDevice,IEmailDevice
{
    public void TakePhoto()
    {
        Console.WriteLine("Taking Photo.");
    }

    public void SendEmail()
    {
        Console.WriteLine("Sending an email.");
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


       

        Camera camera = new Camera();
        Console.WriteLine("\nCamera:");
        camera.TakePhoto();


        AdvancedCamera advancedCamera = new AdvancedCamera();
        Console.WriteLine("\nAdvanced Camera:");
        advancedCamera.TakePhoto();
        advancedCamera.SendEmail();

        Console.ReadKey();


    }
}
