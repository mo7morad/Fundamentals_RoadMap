#include <iostream>
using namespace std;

// #My Solution

enum enNumberType
{
  Perfect = 1,
  NotPerfect = 2
};

enNumberType CheckPerfect(int Number)
{
  int sum = 0;
  for (int i = 1; i < Number; i++)
  {
    if (Number % i == 0)
    {
      sum += i;
    }
  }
  if (Number == sum)
    return Perfect;
  else
    return NotPerfect;
};

void PrintPerfectNumber(int Number)
{
if (CheckPerfect(Number) == enNumberType::Perfect)
  cout << "The number " << Number << " is a perfect number!" << endl;
else
  cout << "The number " << Number << " is Not a perfect number!" << endl;
};

int main ()
{

PrintPerfectNumber(500);
PrintPerfectNumber(12);

return 0;
};

// Course Solution:

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
// bool isPerfectNumber(int Number)
// {
//   int Sum = 0;
//   for (int i = 1; i < Number; i++)
//   {
//     if (Number % i == 0)
//       Sum += i;
//   }
//   return Number == Sum;
// }
// void PrintResults(int Number)
// {
//   if (isPerfectNumber(Number))
//     cout << Number << " Is Perfect Number.\n";
//   else
//     cout << Number << " Is NOT Perfect Number.\n";
// }
// int main()
// {
//   PrintResults(ReadPositiveNumber("Please enter a positive number?"));
//   return 0;
// }