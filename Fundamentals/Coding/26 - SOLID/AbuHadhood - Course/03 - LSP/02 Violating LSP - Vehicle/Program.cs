using System;

public class Vehicle
{
    public virtual void StartEngine()
    {
        Console.WriteLine("Starting engine...");
    }

    public virtual void Drive()
    {
        Console.WriteLine("Driving...");
    }

}

public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started...");
    }

    public override void Drive()
    {
        Console.WriteLine("Car is driving...");
    }
}

public class Bicycle : Vehicle
{
    public override void StartEngine()
    {
        // Bicycles don't have engines, so this method could be a no-op or message
        Console.WriteLine("Bicycles don't have engines.");
    }

    public override void Drive()
    {
        Console.WriteLine("Bicycle is riding...");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Vehicle vehicle1 = new Car();
        vehicle1.StartEngine();
        vehicle1.Drive();

        Vehicle vehicle2 = new Bicycle();
        vehicle2.StartEngine();  // No exception is thrown, even though bicycles don't have engines.
        vehicle2.Drive();        // Behaves as expected for a bicycle.
    }
}
