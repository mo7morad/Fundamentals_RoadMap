using System;

namespace Calculator
{
  class Calculator
  {
    private double _Value = 0;

    public void Add(double Value)
    {
      _Value += Value;
    }

    public void Subtract(double Value)
    {
      _Value -= Value;
    }

    public void Multiply(double Value)
    {
      _Value *= Value;
    }

    public void Divide(double Value)
    {
      _Value /= Value;
    }

    public void Clear()
    {
      _Value = 0;
    }

    public void PrintResult()
    {
      Console.WriteLine($"Value: {_Value}");
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Calculator calc = new Calculator();
      calc.Add(10);
      calc.PrintResult();

      calc.Subtract(5);
      calc.PrintResult();

      calc.Multiply(2);
      calc.PrintResult();

      calc.Divide(4);
      calc.PrintResult();
      
      calc.Clear();
      calc.PrintResult();
    }
  }
}