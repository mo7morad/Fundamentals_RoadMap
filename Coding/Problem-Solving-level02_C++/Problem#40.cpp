#include <iostream>
using namespace std;

void FillArray(int arr[100], int &arrLength)
{
  arrLength = 10;
  arr[0] = 10;
  arr[1] = 10;
  arr[2] = 10;
  arr[3] = 50;
  arr[4] = 50;
  arr[5] = 70;
  arr[6] = 70;
  arr[7] = 70;
  arr[8] = 70;
  arr[9] = 90;
}

void PrintArray(int arr[100], int arrLength)
{
  for (int i = 0; i < arrLength; i++)
    cout << arr[i] << " ";
  cout << "\n";
}

bool IsNumberInArray(int array[100], int lengtharr, int numberSearch)
{
  for (int i = 0; i < lengtharr; i++)
  {
    if (array[i] == numberSearch)
    {
      return 1;
    }
  }
  return 0;
}

void AddArrayElement(int Number, int arr[100], int &arrLength)
{
  arr[arrLength] = Number;
  arrLength++;
}

void CopyDistinctNumbersToArray(int arrSource[100], int arrDestination[100], int SourceLength, int &DestinationLength)
{
  for (int i = 0; i < SourceLength; i++)
  {
    if (!IsNumberInArray(arrDestination, DestinationLength, arrSource[i]))
    {
      AddArrayElement(arrSource[i], arrDestination, DestinationLength);
    }
  }
}

int main()
{
  int arrSource[100], SourceLength = 0;
  int arrDestination[100], DestinationLength = 0;

  FillArray(arrSource, SourceLength);

  cout << "\nArray 1 elements:\n";
  PrintArray(arrSource, SourceLength);

  CopyDistinctNumbersToArray(arrSource, arrDestination, SourceLength, DestinationLength);

  cout << "\nArray 2 distinct elements:\n";
  PrintArray(arrDestination, DestinationLength);

  return 0;
}
