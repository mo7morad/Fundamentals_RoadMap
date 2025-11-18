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

void PrintInvertedLetterPattern(short Number)
{
  for (short i = Number; i > 0; i--)
  {
    for (short j = 0; j < i; j++)
    {
      cout << (char) (i+64);
    }
    cout << endl;
  }
}

int main()
{
  PrintInvertedLetterPattern(ReadPositiveNumber("Enter a positive number: "));
  return 0;
}

// ##########################OR#####################

// void PrintInverted(int Number)
// {
//   for (int i = 64 + Number; i >= 65; i--)
//   {
//     for (int j = 65; j <= i; j++)
//     {
//       cout << char(i);
//     }
//     cout << "\n";
//   }
// }
