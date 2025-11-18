#include <iostream>
#include <cmath> // For abs and ceil functions
using namespace std;

float ReadNumber()
{
  float Number;
  cout << "Please enter a number: ";
  cin >> Number;
  return Number;
}

float GetFractionPart(float Number)
{
  return Number - int(Number);
}

int MyCeil(float Number)
{
  if (abs(GetFractionPart(Number)) > 0)
  {
    if (Number > 0)
      return ++Number;
    else
      return Number;
  }
  else
  {
    return Number;
  }
}

int main()
{
  float Number = ReadNumber();
  cout << "My MyCeil Result: " << MyCeil(Number) << endl;
  cout << "C++ ceil Result: " << ceil(Number) << endl;
  return 0;
}
