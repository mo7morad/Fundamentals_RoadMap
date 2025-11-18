#include <iostream>
using namespace std;

// #My code

int ReadPositiveNumber(string Message)
{
  int Number = 0;
  do
  {
    cout << Message << endl;
    cin >> Number;
  } while (Number <= 0);
  return Number;
};

void NumberReverserPrinter(int Number)
{
  string str_number = to_string(Number);
  for (int i = str_number.length(); i >= 0; i--)
  {
    cout << str_number[i];
  }
}

int main()
{
  NumberReverserPrinter(ReadPositiveNumber("Please enter a number to reverse: "));
}


// # Course Code


// int ReadPositiveNumber(string Message)
// {
//   int Number = 0;
//   do
//   {
//     cout << Message << endl;
//     cin >> Number;
//   } while (Number <= 0);
//   return Number;
// }
// void PrintDigits(int Number)
// {
//   int Remainder = 0;
//   while (Number > 0)
//   {
//     Remainder = Number % 10;
//     Number = Number / 10;
//     cout << Remainder << endl;
//   }
// }
// int main()
// {
//   PrintDigits(ReadPositiveNumber("Please enter a positive number?"));
//   return 0;
// }