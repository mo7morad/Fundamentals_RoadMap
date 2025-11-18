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

void RandomArrayGenerator(int arr[100], int &arrLength)
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

void AddPrimeArrayElement(int Number, int arr[100], int &arrLength)
{
  if (CheckPrime(Number) == Prime){
    arr[arrLength] = Number;
    arrLength++;
  }
};

void PrimeArrayCopier(int arrSource[100], int arrDestination[100], int ArraySourceLength, int &ArrayDestinationLength)
{
  for (int i = 0; i < ArraySourceLength; i++)
    AddPrimeArrayElement(arrSource[i], arrDestination, ArrayDestinationLength);
};

int main()
{
  srand((unsigned)time(NULL));
  int arr1[100], arr2[100];
  int Arr1Length = 0, Arr2Length = 0;

  RandomArrayGenerator(arr1, Arr1Length);
  cout << "Array 1 elements: " << endl;
  PrintArray(arr1, Arr1Length);

  PrimeArrayCopier(arr1, arr2, Arr1Length, Arr2Length);
  cout << "Array 2 prime numbers: " << endl;
  PrintArray(arr2, Arr2Length);

  return 0;
}