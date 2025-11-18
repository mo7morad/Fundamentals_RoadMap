#include <iostream>
using namespace std;

int ReadNumber()
{
  int Number;
  cout << "\nPlease enter a number? ";
  cin >> Number;
  return Number;
}

void ReadArrayFromUser(int Array[100], short &ArrayLength)
{
  short i = 0;
  bool Check = true;

  while (Check)
  {
    Array[i] = ReadNumber();
    i++;
    cout << "\nDo you want to add more numbers? NO[0]/Yes[1]: ";
    cin >> Check;
    if (!Check)
      Check = false;
  }
  ArrayLength = i;
}

void PrintArray(int arr[100], int SizeOfArray)
{
  cout << "Array Length is: " << SizeOfArray << endl;
  for (int i = 0; i < SizeOfArray; i++)
  {
    cout << arr[i] << " ";
  }
  cout << "\n";
};

int main()
{
  srand((unsigned)time(NULL));
  int arr[100];
  short arrLength;

  ReadArrayFromUser(arr, arrLength);
  PrintArray(arr, arrLength);
};


// ################################################# Course Code ############################################################

// #include <iostream>
// using namespace std;

// int ReadNumber()
// {
//   int Number;
//   cout << "\nPlease enter a number? ";
//   cin >> Number;
//   return Number;
// }

// void AddArrayElement(int Number, int arr[100], int &arrLength)
// {
//   arr[arrLength] = Number;
//   arrLength++;
// }
// void InputUserNumbersInArray(int arr[100], int &arrLength)
// {
//   bool AddMore = true;
//   do
//   {
//     AddArrayElement(ReadNumber(), arr, arrLength);
//     cout << "\nDo you want to add more numbers? No[0]/Yes[1]: ";
//     cin >> AddMore;
//   } while (AddMore);
// }
// void PrintArray(int arr[100], int arrLength)
// {
//   for (int i = 0; i < arrLength; i++)
//     cout << arr[i] << " ";
//   cout << "\n";
// }

// int main()
// {
//   int arr[100], arrLength = 0;
//   InputUserNumbersInArray(arr, arrLength);
//   cout << "\nArray Length: " << arrLength << endl;
//   cout << "Array elements: ";
//   PrintArray(arr, arrLength);
//   return 0;
// }