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

void IsEquivalent(int Matrix1[3][3], int Matrix2[3][3])
{
  if (GetMatrixSum(Matrix1) == GetMatrixSum(Matrix2))
    cout << "Both Matrices are equivalent." << endl;
  cout << "The matrices are not equivalent." << endl;
}

int main()
{
  srand((unsigned)time(NULL));
  int mat1[3][3]; int mat2[3][3];
  GetRandom3x3Matrix(mat1);
  PrintRandom3x3Matrix(mat1);
  GetRandom3x3Matrix(mat2);
  PrintRandom3x3Matrix(mat2);
  IsEquivalent(mat1, mat2);
  
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

int SumOfMatrix(int matrix1[3][3], short rows, short cols) {
    int sum = 0;
    for (short i = 0; i < rows; i++) {
        for (short j = 0; j < cols; j++) {
            sum += matrix1[i][j];
        }
    }
    return sum;
}

bool AreEqualMatrices(int matrix1[3][3], int matrix2[3][3], short rows, short cols) {
    return (SumOfMatrix(matrix1, rows, cols) == SumOfMatrix(matrix2, rows, cols));
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

    if (AreEqualMatrices(matrix1, matrix2, 3, 3))
        cout << "\nYES: both martices are equal.";
    else
        cout << "\nNo: martices are NOT equal.";

    return 0;
}

*/