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

void SearchNumInArray(int arr[100], short ArrayLength, short &NumberToSearch)
{
  NumberToSearch = ReadPositiveNumber("Please enter a number to search for: ");
  cout << "The number you're looking for is: " << NumberToSearch << endl;
  bool IsFound = false;

  for (short i = 0; i < ArrayLength; i++)
  {
    if (NumberToSearch == arr[i])
    {
      IsFound = true;
      cout << "The number has been found at index: " << i << endl;
      cout << "The number order is: " << i+1 << endl;
      break;
    }
  }
  if (IsFound == false)
  {
    cout << "The number is not found!\n" ;
  }
};

// #### Another Function to do it (Better one Actually)

// bool get_Position_And_Order_Number(int array[100], int lengtharr, int numberSearch)
// {
//   for (int i = 0; i < lengtharr; i++)
//   {
//     if (array[i] == numberSearch)
//     {
//       cout << "the number found at position: " << i << endl;
//       cout << "the  number found its order: " << i + 1 << endl;
//       return 1;
//     }
//   }
//   cout << "the number is not found:-(\n";
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


  SearchNumInArray(arr, arrLength, SearchingNumber);

  return 0;
}

