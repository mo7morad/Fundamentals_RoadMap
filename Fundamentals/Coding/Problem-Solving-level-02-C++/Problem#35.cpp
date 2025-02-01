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

bool IsNumInArray(int arr[100], short ArrayLength, short &NumberToSearch)
{
  NumberToSearch = ReadPositiveNumber("Please enter a number to search for: ");
  cout << "The number you're looking for is: " << NumberToSearch << endl;
  bool IsFound = false;

  for (short i = 0; i < ArrayLength; i++)
  {
    if (NumberToSearch == arr[i])
    {
      return true;
    }
  }
  return false;
};

// #### Another Function to do it (Better one Actually)

// bool IsNumInArray(int array[100], int lengtharr, int numberSearch)
// {
//   for (int i = 0; i < lengtharr; i++)
//   {
//     if (array[i] == numberSearch)
//     {
//       return 1;
//     }
//   }
//   return 0;
// }

int main()
{
  srand((unsigned)time(NULL));
  int arr[100];
  short arrLength, SearchingNumber;

  RandomArrayGenerator(arr, arrLength);
  cout << "Array elemnts are: \n";
  PrintArray(arr, arrLength);
  cout << '\n';

  return 0;
}
