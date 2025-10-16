
using System;
using System.Drawing;



public interface IPrint
{

    void Print(string content);

}

public interface IScan
{
    void Scan();

}

public interface IFax
{

    void Fax();
}


public interface ICopy
{

    void Copy();
}


public class BasicPrinter :IPrint
{
    public void Print(string content)
    {
        Console.WriteLine($"Printing: {content}");
    }

   
}


public class AdvancedPrinter : IPrint, IFax, IScan,ICopy
{
    public void Print(string content)
    {
        Console.WriteLine($"Printing: {content}");
    }

    public void Scan()
    {
        Console.WriteLine($"Scanning..");
    }

    public void Fax()
    {
        Console.WriteLine($"Faxing...");
    }

    public void Copy()
    {
        Console.WriteLine($"Copying...");
    }
}

public class Program
{
    public static void Main()
    {
        BasicPrinter basicPrinter = new BasicPrinter();
        basicPrinter.Print("Hi, My Name is Abu-Hahdoud");
        

        AdvancedPrinter advancedPrinter = new AdvancedPrinter();
        advancedPrinter.Print("Hi, My Name is Abu-Hahdoud");
        advancedPrinter.Scan();
        advancedPrinter.Fax();
        advancedPrinter.Copy();

        Console.ReadKey();

    }
}
