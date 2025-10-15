using System;

public class Bird
{
    public virtual void Eat()
    {
        Console.WriteLine("Eating...");
    }

}

public class FlyingBird:Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Flying...");
    }
}


public class Eagle : FlyingBird
{
    public override void Eat()
    {
        Console.WriteLine("Eagle Eating...");
    }

    public override void Fly()
    {
        Console.WriteLine("Eagle flying...");
    }
}

public class Ostrich : Bird
{

    public override void Eat()
    {
        Console.WriteLine("Ostrich Eating...");
    }

   
}

public class Program
{
    public static void Main(string[] args)
    {
        FlyingBird  bird1 = new Eagle();
        bird1.Eat();
        bird1.Fly();


        Bird bird2 = new Ostrich();
        bird2.Eat();
        

        Console.ReadKey();

    }
}