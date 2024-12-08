#include <iostream>
#include <string>
using namespace std;

class Calculator
{
private:
  // Private member variables
  double result;
  string lastOperation;

public:
  // Constructor - initialize result to 0
  Calculator()
  {
    result = 0;
  }

  // Addition method
  void add(double number)
  {
    result += number;
    lastOperation = "Addition";
  }

  // Subtraction method
  void subtract(double number)
  {
    result -= number;
    lastOperation = "Subtraction";
  }

  // Multiplication method
  void multiply(double number)
  {
    result *= number;
    lastOperation = "Multiplication";
  }

  // Division method with basic error checking
  void divide(double number)
  {
    if (number != 0)
    {
      result /= number;
      lastOperation = "Division";
    }
    else
    {
      cout << "Error: Cannot divide by zero!" << endl;
    }
  }

  // Clear the calculator
  void clear()
  {
    result = 0;
    lastOperation = "Cleared";
  }

  // Get current result
  double getResult()
  {
    return result;
  }

  // Set initial value
  void setInitialValue(double value)
  {
    result = value;
    lastOperation = "Initial Value Set";
  }

  // Display current result and last operation
  void showResult()
  {
    cout << "Result after: " << lastOperation << " is " << result << endl;
  }
};

// Main function to demonstrate calculator usage
int main()
{
  // Create calculator object
  Calculator calc;

  // Demonstrate basic operations
  cout << "Calculator Demonstration:" << endl;

  // Set initial value
  calc.setInitialValue(10);
  cout << "\nInitial Value:" << endl;
  calc.showResult();

  // Perform addition
  calc.add(5);
  cout << "\nAfter Addition:" << endl;
  calc.showResult();

  // Perform subtraction
  calc.subtract(3);
  cout << "\nAfter Subtraction:" << endl;
  calc.showResult();

  // Perform multiplication
  calc.multiply(2);
  cout << "\nAfter Multiplication:" << endl;
  calc.showResult();

  // Perform division
  calc.divide(4);
  cout << "\nAfter Division:" << endl;
  calc.showResult();

  // Demonstrate division by zero
  cout << "\nTrying Division by Zero:" << endl;
  calc.divide(0);

  // Clear the calculator
  calc.clear();
  cout << "\nAfter Clearing:" << endl;
  calc.showResult();

  return 0;
}