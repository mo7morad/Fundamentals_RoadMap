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
  cout << "\nArray Elements: " << endl;
  for (int i = 0; i < SizeOfArray; i++)
  {
    cout << arr[i] << " ";
  }
  cout << "\n";
};

int SumOfArray(int arr[100], short arrLength)
{
  int Sum = 0;
  for (int i = 0; i < arrLength; i++)
  {
    Sum += arr[i];
  }
  return Sum;
};

int main()
{
  srand((unsigned)time(NULL));
  int arr[100];
  short arrLength;
  RandomArrayGenerator(arr, arrLength);

  PrintArray(arr, arrLength);
  cout << "Sum of the array is: " << SumOfArray(arr, arrLength) << endl;

  return 0;
}