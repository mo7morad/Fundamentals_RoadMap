#include <iostream>
using namespace std;

void MyFunc()
{
  static int Number = 1; // Declare a static variable
  cout << "Value of Number: " << Number << "\n";
  Number++; // Increment the static variable
}

int main()
{
  MyFunc(); // First call, Number is 1
  MyFunc(); // Second call, Number is 2
  MyFunc(); // Third call, Number is 3
}
