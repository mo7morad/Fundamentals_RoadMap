#include <iostream>
using namespace std;

int ReadPositiveNumber(string msg)
{
  int Number = 0;
  do
  {
    cout << msg;
    cin >> Number;
  } while (Number <= 0);
  return Number;
};

void PrintNumberPattern(short Number)
{
  for (short i = 1; i <= Number; i++)
  {
    for (short j = 0; j < i; j++)
    {
      cout << i;
    }
    cout << endl;
  }
}

int main()
{
  PrintNumberPattern(ReadPositiveNumber("Enter a positive number: "));
  return 0;
}