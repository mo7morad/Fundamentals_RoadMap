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

void AddArrayElement(int Number, int arr[100], int &arrLength)
{
  arr[arrLength] = Number;
  arrLength++;
}

void ArrayCopierVersion2(int arrSource[100], int arrDestination[100], int ArraySourceLength, int& ArrayDestinationLength )
{
  for (int i = 0; i < ArraySourceLength; i++)
    AddArrayElement(arrSource[i], arrDestination, ArrayDestinationLength);
};

int main()
{
  srand((unsigned)time(NULL));
  int arr1[100], arr2[100];
  int Arr1Length = 0, Arr2Length = 0;

  RandomArrayGenerator(arr1, Arr1Length);
  cout << "Array 1 elements: " << endl;
  PrintArray(arr1, Arr1Length);

  ArrayCopierVersion2(arr1, arr2, Arr1Length, Arr2Length);
  cout << "Array 2 elements after copy: " << endl;
  PrintArray(arr2, Arr2Length);

  return 0;
}