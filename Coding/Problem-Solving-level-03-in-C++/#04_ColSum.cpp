#include <iostream>
#include <cstdlib>
#include <iomanip>
using namespace std;

int RandomNumber(int From, int To)
{
  int randNum = rand() % (To - From + 1) + From;
  return randNum;
};

void GetRandom3x3Matrix(int arr[3][3])
{
  for (int i = 0; i < 3; i++)
    for (int j = 0; j < 3; j++)
    {
      arr[i][j] = RandomNumber(1, 100);
    }
};

void PrintRandom3x3Matrix(int arr[3][3])
{
  cout << "Your random matrix is: \n";
  for (int i = 0; i < 3; i++)
  {
    for (int j = 0; j < 3; j++)
    {
      cout << setw(1) << arr[i][j] << " ";
    }
    cout << endl;
  }
};

void PrintEachColSum(int Matrix[3][3])
{
  for (int i = 0; i < 3; i++)
  {
    int Sum = 0;
    cout << "col [" << i + 1 << "] sum is: ";
    for (int j = 0; j < 3; j++)
    {
      Sum += Matrix[j][i];
    }
    cout << Sum << endl;
  }
}

void PrintArray(int Array[], short ArrayLength)
{
  for (int i = 0; i < ArrayLength; i++)
  {
    cout << "col [" << i + 1 << "] sum is: ";
    cout << Array[i] << endl;
  }
}

int main()
{
  srand((unsigned)time(NULL));
  int arr[3][3];
  GetRandom3x3Matrix(arr);
  PrintRandom3x3Matrix(arr);
  PrintEachColSum(arr);
  return 0;
};


/*
#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

int RandomNumber(int From, int To) {
    // Function to generate a random number
    int randNum = rand() % (To - From + 1) + From;
    return randNum;
}

void FillMatrixWithRandomNumbers(int arr[3][3], short Rows, short Cols) {
    for (short i = 0; i < Rows; i++) {
        for (short j = 0; j < Cols; j++) {
            arr[i][j] = RandomNumber(1, 100);
        }
    }
}

void PrintMatrix(int arr[3][3], short Rows, short Cols) {
    for (short i = 0; i < Rows; i++) {
        for (short j = 0; j < Cols; j++) {
            cout << setw(3) << arr[i][j] << " ";
        }
        cout << "\n";
    }
}

int ColSum(int arr[3][3], short Rows, short ColNumber) {
    int Sum = 0;
    for (short i = 0; i <= Rows - 1; i++) {
        Sum += arr[i][ColNumber];
    }
    return Sum;
}

void PrintEachColSum(int arr[3][3], short Rows, short Cols) {
    cout << "\nThe following are the sum of each column in the matrix:\n";
    for (short j = 0; j < Cols; j++) {
        cout << " Col " << j + 1 << " Sum = " << ColSum(arr, Rows, j) << endl;
    }
}

int main() {
    // Seeds the random number generator in C++, called only once
    srand((unsigned)time(NULL));

    int arr[3][3];
    FillMatrixWithRandomNumbers(arr, 3, 3);
    cout << "\nThe following is a 3x3 random matrix:\n";
    PrintMatrix(arr, 3, 3);
    PrintEachColSum(arr, 3, 3);

    system("pause>0");
}
*/