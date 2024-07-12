#include <iostream>
#include <cstdlib>
#include <iomanip>
using namespace std;


short RandomNumber(short From, short To)
{
  short randNum = rand() % (To - From + 1) + From;
  return randNum;
};

void GetRandom3x3Matrix(int arr[3][3]){
  for(short i = 0; i < 3; i++)
    for(short j = 0; j < 3; j++){
      arr[i][j] = RandomNumber(1, 100);
    }
};

void FillOrdered3x3Matrix(int arr[3][3])
{
  short Number = 1;
  for (short i = 0; i < 3; i++)
  {
    for (short j = 0; j < 3; j++)
    {
      arr[i][j] = Number;
      Number++;
    }
  }
};

void Print3x3Matrix(int arr[3][3])
{
  cout << "Your matrix is: \n";
  for (short i = 0; i < 3; i++)
  {
    for (short j = 0; j < 3; j++)
    {
      cout << setw(3) << arr[i][j] << " ";
    }
    cout << endl;
  }
};

void MultiplyMatrix(int FirstMatrix[3][3], int SecMatrix[3][3], int ResultMatrix[3][3]){
  for (short i = 0; i < 3; i++)
  {
    for (short j = 0; j < 3; j++)
      ResultMatrix[i][j] = FirstMatrix[i][j]*SecMatrix[i][j];
  }
}


int main()
{
  srand((unsigned)time(NULL));
  int arr1[3][3], arr2[3][3], Result[3][3];
  FillOrdered3x3Matrix(arr1);
  GetRandom3x3Matrix(arr2);
  MultiplyMatrix(arr1,arr2,Result);
  Print3x3Matrix(arr1);
  Print3x3Matrix(arr2);
  Print3x3Matrix(Result);
  return 0;
}

// Course Code

/*
// ProgrammingAdvices.com
// Copyright 2022
// Problem # 08/3 Solution Using C++

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
            arr[i][j] = RandomNumber(1, 10);
        }
    }
}

void PrintMatrix(int arr[3][3], short Rows, short Cols) {
    for (short i = 0; i < Rows; i++) {
        for (short j = 0; j < Cols; j++) {
            printf(" %0*d   ", 2, arr[i][j]); 
            // cout << setw(3) << arr[i][j] << "     ";
        }
        cout << "\n";
    }
}

void MultiplyMatrix(int Matrix1[3][3], int Matrix2[3][3], int MatrixResults[3][3], short Rows, short Cols) {
    for (short i = 0; i < Rows; i++) {
        for (short j = 0; j < Cols; j++) {
            MatrixResults[i][j] = Matrix1[i][j] * Matrix2[i][j];
        }
    }
}

int main() {
    // Seeds the random number generator in C++, called only once
    srand((unsigned)time(NULL));

    int Matrix1[3][3], Matrix2[3][3], MatrixResults[3][3];

    FillMatrixWithRandomNumbers(Matrix1, 3, 3);
    cout << "\nMatrix1:\n";
    PrintMatrix(Matrix1, 3, 3);

    FillMatrixWithRandomNumbers(Matrix2, 3, 3);
    cout << "\nMatrix2:\n";
    PrintMatrix(Matrix2, 3, 3);

    MultiplyMatrix(Matrix1, Matrix2, MatrixResults, 3, 3);
    cout << "\nResults:\n";
    PrintMatrix(MatrixResults, 3, 3);

    system("pause>0");
}
*/
