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

void PrintInvertedNumberPattern(short Number)
{
  for (short i = Number; i > 0; i--)
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
PrintInvertedNumberPattern(ReadPositiveNumber( "Enter a positive number: "));
  return 0;
}