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

short IsEvenArrayCounter(int Array[100], short ArrayLength)
{
  short EvenCounter = 0;
  for (int i = 0; i < ArrayLength; i++)
  {
    if (Array[i] % 2 == 0)
    {
      EvenCounter++;
    }
  }
  return EvenCounter;
}

void PrintEvenNumCounter(short EvenCounter)
{
  cout << "The number of odd numbers in the array is: " << EvenCounter << endl;
}

int main()
{
  srand((unsigned)time(NULL));
  int arr1[100];
  short ArrLength = 0;

  RandomArrayGenerator(arr1, ArrLength);
  cout << "Array 1 elements: " << endl;
  PrintArray(arr1, ArrLength);

  PrintEvenNumCounter(IsEvenArrayCounter(arr1, ArrLength));
  return 0;
}