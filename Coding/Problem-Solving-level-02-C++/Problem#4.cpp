#include <iostream>
using namespace std;


int ReadPositiveNumber(string Message)
{
  int Number = 0;
  do
  {
    cout << Message << endl;
    cin >> Number;
  } while (Number <= 0);
  return Number;
}
bool isPerfectNumber(int Number)
{
  int Sum = 0;
  for (int i = 1; i < Number; i++)
  {
    if (Number % i == 0)
      Sum += i;
  }
  return Number == Sum;
}
void PrintPerfectNumbersFrom1ToN(int Number)
{
  for (int i = 1; i <= Number; i++)
  {
    if (isPerfectNumber(i))
    {
      cout << i << endl;
    }
  }
}
