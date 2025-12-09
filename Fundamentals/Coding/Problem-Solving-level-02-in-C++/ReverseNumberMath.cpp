// #include <iostream>
// using namespace std;

// // #My code

// int ReadPositiveNumber(string Message)
// {
//   int Number = 0;
//   do
//   {
//     cout << Message << endl;
//     cin >> Number;
//   } while (Number <= 0);
//   return Number;
// };

// void NumberReverserPrinter(int Number)
// {
//   string str_number = to_string(Number);
//   for (int i = 0; i <= str_number.length(); i++)
//   {
//     cout << str_number[i] << endl;
//   }
// }

// int main()
// {
//   NumberReverserPrinter(ReadPositiveNumber("Please enter a number: "));
// }


// #course code:

#include <iostream>
#include <string>
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
int ReverseNumber(int Number)
{
  int Remainder = 0, Number2 = 0;
  while (Number > 0)
  {
    Remainder = Number % 10;
    Number = Number / 10;
    Number2 = Number2 * 10 + Remainder;
  }
  return Number2;
}
void PrintDigits(int Number)
{
  int Remainder = 0;
  while (Number > 0)
  {
    Remainder = Number % 10;
    Number = Number / 10;
    cout << Remainder << endl;
  }
}

int main()
{
  PrintDigits(ReverseNumber(ReadPositiveNumber("Please enter a positive number?")));
  return 0;
}