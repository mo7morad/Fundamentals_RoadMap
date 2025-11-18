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

void Swap(int &A, int &B)
{
  int Temp;
  Temp = A;
  A = B;
  B = Temp;
};

int RandomNumber(int From, int To)
{
  // Function to generate a random number
  int randNum = rand() % (To - From + 1) + From;
  return randNum;
};

void PrintArray(int arr[100], int SizeOfArray)
{
  for (int i = 0; i < SizeOfArray; i++)
  {
    cout << arr[i] << " ";
  }
  cout << "\n";
};

void RandomArrayGenerator(int arr[100], short &arrLength)
{
  arrLength = ReadPositiveNumber("Please enter the size of the array: ");
  for (int i = 0; i < arrLength; i++)
  {
    arr[i] = RandomNumber(1, 100);
  }
};

void CopyArrayInReverseOrder(int ArraySource[100], int ArrayDestination[100], short ArrayLength)
{
  for (int i = 0; i < ArrayLength; i++)
  {
    ArrayDestination[i] = ArraySource[ArrayLength-1-i];
  }
};

int main()
{
  srand((unsigned)time(NULL));

  int Arr[100], ReversedArray[100];
  short ArrayLength;
  RandomArrayGenerator(Arr, ArrayLength);
  cout << "\nArray 1 elements: \n";
  PrintArray(Arr, ArrayLength);

  CopyArrayInReverseOrder(Arr, ReversedArray, ArrayLength);
  cout << "\nReversed Array: \n";
  PrintArray(ReversedArray, ArrayLength);

  return 0;
}