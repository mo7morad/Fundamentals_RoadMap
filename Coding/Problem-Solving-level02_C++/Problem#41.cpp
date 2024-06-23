#include<iostream>
using namespace std;

void FillArray(int arr[100], int &arrLength){
  arrLength = 6;
  arr[0] = 10;
  arr[1] = 20;
  arr[2] = 30;
  arr[3] = 30;
  arr[4] = 20;
  arr[5] = 10;
  }

  void PrintArray(int arr[100], int arrLength)
  {
    for (int i = 0; i < arrLength; i++)
      cout << arr[i] << " ";
    cout << "\n";
  }

  bool IsArrayPolindrome(int Arr[100], int ArrLength)
  {
    for (int i = 0; i < ArrLength; i++)
    {
      if (Arr[i] != Arr[ArrLength - i - 1])
        return 0;
    }
    return 1;
  }

  int main()
  {
    int Arr[100], ArrLength = 0;
    FillArray(Arr, ArrLength);

    if (IsArrayPolindrome(Arr, ArrLength))
      cout << "The array is polindrome!\n";

    else
      cout << "Array is not a polindrome!\n";
    return 0;
  }
