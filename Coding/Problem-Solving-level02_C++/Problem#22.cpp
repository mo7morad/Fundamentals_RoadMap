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

void ReadArray(int arr[100], int& arrLength)
{
  arrLength = ReadPositiveNumber("Please enter the size of the array: ");
  cout << "\nPlease Enter array elements: \n\n";
  for (int i = 0; i < arrLength; i++)
  {
    cout << "Element [" << i + 1 << "] : ";
    cin >> arr[i];
  }
  cout << endl;
};

void PrintArray(int arr[100], int SizeOfArray)
{
  cout << "\nOriginal Array: " << endl;
  for(int i = 0; i < SizeOfArray; i++)
  {
    cout << arr[i] << " ";
  }
};

void NumberFrequency(int arr[100], int arrLength, int NumberToCheck)
{
  int Freq = 0;
  for (int i = 0; i < arrLength; i++)
  {
    if (arr[i] == NumberToCheck)
      Freq++;
  }
  cout << NumberToCheck << " is repetead " << Freq << " time(s)";
}


int main()
{
  int arr[100];
  int arrLength;
  ReadArray(arr, arrLength);
  NumberFrequency(arr, arrLength, ReadPositiveNumber("Please enter the number you want to check: "));
  PrintArray(arr, arrLength);
  return 0;
}


// ########################################## Course Code ##############################################


// #include <iostream>
// using namespace std;


// int ReadPositiveNumber(string Message)
// {
// int Number = 0;
// do
// {
// cout << Message << endl;
// cin >> Number;
// } while (Number <= 0);
// return Number;
// }

// void ReadArray(int arr[100], int &arrLength)
// {
//   cout << "\nEnter number of elements:\n";
//   cin >> arrLength;
//   cout << "\nEnter array elements: \n";

//   for (int i = 0; i < arrLength; i++)
//   {
//     cout << "Element [" << i + 1 << "] : ";
//     cin >> arr[i];
//   }
//   cout << endl;
// }

// void PrintArray(int arr[100], int arrLength)
// {
//   for (int i = 0; i < arrLength; i++)
//     cout << arr[i] << " ";
//   cout << "\n";
// }

// int TimesRepeated(int Number, int arr[100], int arrLength)
// {
//   int count = 0;
//   for (int i = 0; i <= arrLength - 1; i++)
//   {
//     if (Number == arr[i])
//     {
//       count++;
//     }
//   }
//   return count;
// }

// int main()
// {
//   int arr[100], arrLength, NumberToCheck;
//   ReadArray(arr, arrLength);
// NumberToCheck = ReadPositiveNumber("Enter the number you want to check: ");
// cout << "\nOriginal array: ";
// PrintArray(arr, arrLength);
// cout << "\nNumber " << NumberToCheck;
// cout << " is repeated ";
// cout << TimesRepeated(NumberToCheck, arr, arrLength) << "time(s)\n";
// return 0;
// }