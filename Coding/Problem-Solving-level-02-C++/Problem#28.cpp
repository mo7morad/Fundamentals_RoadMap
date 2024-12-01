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

void ArrayCopier(int arrSource[100], int arrDestination[100], int arrLength)
{
  for (int i = 0; i < arrLength; i++)
    arrDestination[i] = arrSource[i];
};

int main()
{
  srand((unsigned)time(NULL));
  int arr[100]; short arrLength;
  RandomArrayGenerator(arr, arrLength);

  int arr2[100];
  ArrayCopier(arr, arr2, arrLength);

  cout << "\nArray 1 elements:\n";
  PrintArray(arr, arrLength);
  
  cout << "\nArray 2 elements after copy:\n";
  PrintArray(arr2, arrLength);
}