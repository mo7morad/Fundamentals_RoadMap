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

void ArraySum(int FirstArray[100], int SecondArray[100], int ResultArray[100], short ArrayLength)
{
  for(int i = 0; i < ArrayLength; i++)
    ResultArray[i] = FirstArray[i] + SecondArray[i];
}

int main()
{
  srand((unsigned)time(NULL));

  int arr[100]; short arrLength;
  RandomArrayGenerator(arr, arrLength);

  int arr2[100]; short arr2Length;
  RandomArrayGenerator(arr2, arr2Length);

  int SummedArray[100];

  cout << "\nArray 1 elements:\n";
  PrintArray(arr, arrLength);

  cout << "\nArray 2 elements: \n";
  PrintArray(arr2, arr2Length);

  ArraySum(arr, arr2, SummedArray, arrLength);
  cout << "\nSum of Array 1, and 2 is: \n";
  PrintArray(SummedArray, arrLength);
}



// // ################################## Course Code ###########################################

// #include <iostream>
// using namespace std;


// int RandomNumber(int From, int To)
// {
//   // Function to generate a random number
//   int randNum = rand() % (To - From + 1) + From;
//   return randNum;
// };


// int ReadPositiveNumber(string Message)
// {
//   int Number = 0;
//   do
//   {
//     cout << Message << endl;
//     cin >> Number;
//   } while (Number <= 0);
//   return Number;
// };


// void FillArrayWithRandomNumbers(int arr[100], int arrLength)
// {
//   for (int i = 0; i < arrLength; i++)
//     arr[i] = RandomNumber(1, 100);
// };


// void SumOf2Arrays(int arr1[100], int arr2[100], int arrSum[100], int arrLength)
// {
//   for (int i = 0; i < arrLength; i++)
//   {
//     arrSum[i] = arr1[i] + arr2[i];
//   }
// };


// void PrintArray(int arr[100], int arrLength)
// {
//   for (int i = 0; i < arrLength; i++)
//     cout << arr[i] << " ";
//   cout << "\n";
// };



// int main()
// {
//   // Seeds the random number generator in C++, called only once
//   srand((unsigned)time(NULL));
//   int arr[100], arr2[100], arrSum[100];
//   int arrLength = ReadPositiveNumber("How many elements ?\n");
//   FillArrayWithRandomNumbers(arr, arrLength);
//   FillArrayWithRandomNumbers(arr2, arrLength);
//   SumOf2Arrays(arr, arr2, arrSum, arrLength);
//   cout << "\nArray 1 elements:\n";
//   PrintArray(arr, arrLength);
//   cout << "\nArray 2 elements:\n";
//   PrintArray(arr2, arrLength);
//   cout << "\nSum of array1 and array2 elements:\n";
//   PrintArray(arrSum, arrLength);
//   return 0;
// };