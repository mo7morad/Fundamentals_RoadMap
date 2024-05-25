#include <iostream>
using namespace std;

float MyABS(float Number)
{
  if (Number > 0)
    return Number;
  else
    return Number * -1;
}

float ReadNumber()
{
  float Number;
  cout << "Please enter a number: ";
  cin >> Number;
  return Number;
}

int main()
{
  float Number = ReadNumber();
  cout << "My abs Result : " << MyABS(Number) << endl;
  cout << "C++ abs Result: " << abs(Number) << endl;
  return 0;
}
