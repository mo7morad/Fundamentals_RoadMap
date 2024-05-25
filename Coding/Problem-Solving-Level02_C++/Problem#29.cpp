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
};

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

int RandomNumber(int From, int To)
{
  int randNum = rand() % (To - From + 1) + From;
  return randNum;
};

void RandomArrayGenerator(int arr[100], short &arrLength)
{
  arrLength = ReadPositiveNumber("Please enter the size of the array: ");
  for (int i = 0; i < arrLength; i++)
  {
    arr[i] = RandomNumber(1, 100);
  }
};

void PrintArray(int arr[100], int SizeOfArray)
{
  for (int i = 0; i < SizeOfArray; i++)
  {
    cout << arr[i] << " ";
  }
  cout << "\n";
};

void PrimeNumsArrayCopier(int arrSource[100], int PrimeArrDestination[100], int arrLength, int &arr2Length)
{
  int Counter = 0;
  for (int i = 0; i < arrLength; i++)
  {
    if (CheckPrime(arrSource[i]) == Prime)
    {
      PrimeArrDestination[Counter] = arrSource[i];
      Counter++;
    }
  }
  arr2Length = Counter;
};

int main()
{
  srand((unsigned)time(NULL));
  int arr[100];
  short arrLength;
  RandomArrayGenerator(arr, arrLength);

  cout << "Array 1 elements: \n";
  PrintArray(arr, arrLength);

  int arr2[100]; int arr2Length;
  PrimeNumsArrayCopier(arr, arr2, arrLength, arr2Length);

  cout << "Prime Numbers in array 2: \n";
  PrintArray(arr2, arr2Length);
}