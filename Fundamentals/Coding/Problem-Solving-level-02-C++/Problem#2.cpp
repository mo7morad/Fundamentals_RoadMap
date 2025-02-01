#include <iostream>
using namespace std;

enum enNumberType
{
  Prime = 1,
  NotPrime = 2
};

enNumberType CheckPrime(int Number)
{
  if (Number <= 1)
    return NotPrime;

  for (int i = 2; i <= Number / 2; i++)
  {
    if (Number % i == 0)
      return NotPrime;
  }
  return Prime;
}

void PrintPrimeNumber(int Number)
{
  for (int i = 1; i <= Number; i++)
  {
    if (CheckPrime(i) == enNumberType::Prime)
    {
      cout << i << endl;
    }
  }
};

int main()
{
  PrintPrimeNumber(10);
  return 0;
}
