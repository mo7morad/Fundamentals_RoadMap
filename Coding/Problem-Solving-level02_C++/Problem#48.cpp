#include <iostream>
#include <cmath>
using namespace std;

float ReadNumber()
{
  float Number;
  cout << "Please enter a float number: ";
  cin >> Number;
  return Number;
}

int MyFloor(float Number)
{
  if (Number > 0)
    return Number;
  else
    return (Number-1);
}

int main()
{
  float Number = ReadNumber();
  cout << "My Floor Result: " << MyFloor(Number) << endl;
  cout << "C++ Floor Result: " << floor(Number) << endl;
  return 0;
}
