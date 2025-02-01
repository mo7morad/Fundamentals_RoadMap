#include <iostream>
#include <cstdlib>
#include <iomanip>
using namespace std;

short RandomNumber(short From, short To)
{
  short randNum = rand() % (To - From + 1) + From;
  return randNum;
};

void GetRandom3x3Matrix(int arr[3][3])
{
  for (short i = 0; i < 3; i++)
    for (short j = 0; j < 3; j++)
    {
      arr[i][j] = RandomNumber(1, 100);
    }
};

void PrintRandom3x3Matrix(int arr[3][3])
{
  cout << "Your random matrix is: \n";
  for (short i = 0; i < 3; i++)
  {
    for (short j = 0; j < 3; j++)
    {
      cout << setw(1) << arr[i][j] << " ";
    }
    cout << endl;
  }
};

short GetMatrixSum(int Matrix[3][3])
{
  short Sum = 0;
  for (short i = 0; i < 3; i++)
    for (short j = 0; j < 3; j++)
      Sum += Matrix[i][j];
  return Sum;
}

void PrintArray(int Array[], short ArrayLength)
{
  for (short i = 0; i < ArrayLength; i++)
  {
    cout << "col [" << i + 1 << "] sum is: ";
    cout << Array[i] << endl;
  }
}

bool IsTypical(int Matrix1[3][3], int Matirx2[3][3])
{
  bool Typical = true;
  for (int i = 0; i < 3; i++)
  {
    for (int j = 0; j < 3; j++)
    {
      if (Matrix1[i][j] != Matirx2[i][j])
      {
        Typical = false;
        return Typical;
      }
    }
  }
  return Typical;
}

int main()
{
  srand((unsigned)time(NULL));
  // Case 1
  /*
  int mat1[3][3];
  int mat2[3][3];
  GetRandom3x3Matrix(mat1);
  PrintRandom3x3Matrix(mat1);
  GetRandom3x3Matrix(mat2);
  PrintRandom3x3Matrix(mat2);
  */

  // Case 2
  int mat1[3][3] = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
  int mat2[3][3] = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
  if (IsTypical(mat1, mat2))
    cout << "Both matrices are typical.";
  else
    cout << "The matrices are NOT typical.";
  return 0;
};


// Course Code

/*
#include <iostream>
#include <iomanip>

using namespace std;

int RandomNumber(int from, int to) {
    return rand() % (to - from + 1) + from;
}

void FillMatrixWithRandomNumbers(int arr[3][3], short rows, short cols) {
    for (short i = 0; i < rows; i++) {
        for (short j = 0; j < cols; j++) {
            arr[i][j] = RandomNumber(1, 10);
        }
    }
}

void PrintMatrix(int arr[3][3], short rows, short cols) {
    for (short i = 0; i < rows; i++) {
        for (short j = 0; j < cols; j++) {
            printf(" %0*d ", 2, arr[i][j]);
        }
        cout << "\n";
    }
}

bool AreTypicalMatrices(int matrix1[3][3], int matrix2[3][3], short rows, short cols) {
    for (short i = 0; i < rows; i++) {
        for (short j = 0; j < cols; j++) {
            if (matrix1[i][j] != matrix2[i][j]) {
                return false;
            }
        }
    }
    return true;
}

int main() {
    srand((unsigned)time(NULL));
    int matrix1[3][3], matrix2[3][3];

    FillMatrixWithRandomNumbers(matrix1, 3, 3);
    cout << "\nMatrix1:\n";
    PrintMatrix(matrix1, 3, 3);

    FillMatrixWithRandomNumbers(matrix2, 3, 3);
    cout << "\nMatrix2:\n";
    PrintMatrix(matrix2, 3, 3);

    if (AreTypicalMatrices(matrix1, matrix2, 3, 3)) {
        cout << "\nYES: both matrices are typical.";
    } else {
        cout << "\nNo: matrices are NOT typical.";
    }

    return 0;
}

*/