using System;

public class Bird
{
    public virtual void Eat()
    {
        Console.WriteLine("Eating...");
    }

    public virtual void Fly()
    {
        Console.WriteLine("Flying...");
    }
}


public class Eagle : Bird
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

    public override void Fly()
    {
        // Ostriches can't fly, but because it is forced to override Fly, it violates LSP
        throw new NotSupportedException("Ostriches can't fly");
       // Console.WriteLine("Ostriches can't fly");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Bird bird1 = new Eagle();
        bird1.Eat();
        bird1.Fly();


        Bird bird2 = new Ostrich();
        bird2.Eat();
        bird2.Fly();  // Throws an exception, violating LSP

        Console.ReadKey();

    }
}