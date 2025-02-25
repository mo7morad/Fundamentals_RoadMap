using System;
class clsCalculator
{
    
    private float _Result = 0;
    private float _LastNumber = 0;
    private string _LastOperation = "Clear";

    private bool _IsZero(float Number)
    {
        return (Number == 0);
    }

   public void Add(float Number)
    {
        _LastNumber = Number;
        _LastOperation = "Adding";
        _Result += Number;
    }

    public void Subtract(float Number)
    {
        _LastNumber = Number;
        _LastOperation = "Subtracting";

        _Result -= Number;
    }

    public bool Divide(float Number)
    {
        
        bool Succeeded =true;
        _LastOperation = "Dividing";

        if (_IsZero(Number))
        {
            _LastNumber = Number;
            _Result /= 1;
            Succeeded = false; 
        }
        else
        {
            _LastNumber = Number;
            _Result /= Number;
        }

        return Succeeded;
    }

    public void Multiply(float Number)
    {
        _LastNumber = Number;
        _LastOperation = "Multiplying";
        _Result *= Number;
    }

    public float GetFinalResults()
    {
        return _Result;
    }

    public void Clear()
    {
        _LastNumber = 0;
        _LastOperation = "Clear";
        _Result = 0;
    }

    public void PrintResult()
    {
        Console.WriteLine( "Result After {0} {1} is : {2}", _LastOperation , _LastNumber,  _Result );
    }
};

internal class Program
    {
        static void Main(string[] args)
        {

        clsCalculator Calculator1= new clsCalculator();

  
        Calculator1.Clear();

        Calculator1.Add(10);
        Calculator1.PrintResult();

        Calculator1.Add(100);
        Calculator1.PrintResult();

        Calculator1.Subtract(20);
        Calculator1.PrintResult();

        Calculator1.Divide(0);
        Calculator1.PrintResult();

        Calculator1.Divide(2);
        Calculator1.PrintResult();

        Calculator1.Multiply(3);
        Calculator1.PrintResult();

        Calculator1.Clear();
        Calculator1.PrintResult();

        Console.ReadLine();


    }
}

