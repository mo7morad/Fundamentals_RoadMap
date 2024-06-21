#include <iostream>
#include <cstdlib>
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
      cout << arr[i][j] << " ";
    }
    cout << endl;
  }
};

void GetRowSumInArray(int Matrix[3][3], int ResultArray[])
{
  for (int i = 0; i < 3; i++){
    int Sum = 0;
    for (int j = 0; j < 3; j++){
      Sum += Matrix[i][j];
    }
    ResultArray[i] = Sum;
  }
}

void PrintArray(int Array[], short ArrayLength)
{
  for (int i = 0; i < ArrayLength; i++){
    cout << "Row [" << i+1 << "] sum is: ";
    cout << Array[i] << endl;
  }
}

int main()
{
  srand((unsigned)time(NULL));
  int arr[3][3];
  int Result[3];
  GetRandom3x3Matrix(arr);
  PrintRandom3x3Matrix(arr);
  GetRowSumInArray(arr, Result);
  PrintArray(Result, 3);
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

int RowSum(int arr[3][3], short RowNumber, short Cols) {
    int Sum = 0;
    for (short j = 0; j <= Cols - 1; j++) {
        Sum += arr[RowNumber][j];
    }
    return Sum;
}

void SumMatixRowsInArry(int arr[3][3], int arrSum[3], short Rows, short Cols) {
    for (short i = 0; i < Rows; i++) {
        arrSum[i] = RowSum(arr, i, Cols);
    }
}

void PrintRowsSumArray(int arrSum[3], short Rows) {
    cout << "\nThe following are the sum of each row in the matrix:\n";
    for (short i = 0; i < Rows; i++) {
        cout << " Row " << i + 1 << " Sum = " << arrSum[i] << endl;
    }
}

int main() {
    // Seeds the random number generator in C++, called only once
    srand((unsigned)time(NULL));

    int arr[3][3];
    int arrSum[3];
    FillMatrixWithRandomNumbers(arr, 3, 3);
    cout << "\nThe following is a 3x3 random matrix:\n";
    PrintMatrix(arr, 3, 3);
    SumMatixRowsInArry(arr, arrSum, 3, 3);
    PrintRowsSumArray(arrSum, 3);

    system("pause>0");
}
*/