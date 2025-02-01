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

bool IsScalar(int Matrix[3][3])
{
  for (int i = 0; i < 3; i++)
  {
    for (int j = 0; j < 3; j++)
    {
      if (i == j && Matrix[i][j] != Matrix[0][0])
        return false;
      else if (i != j && Matrix[i][j] != 0)
        return false;
    }
  }
  return true;
}

int main()
{
  // Random case
  
  srand((unsigned)time(NULL));
  int mat[3][3];
  int mat2[3][3];
  GetRandom3x3Matrix(mat);
  PrintRandom3x3Matrix(mat);
  if(IsScalar(mat))
    cout << "The matrix is Scalar matrix.";
  else
    cout << "The matrix is Not Scalar matrix.";
  
  return 0;

  // Scalar case
  /*
  int mat[3][3] = {{7, 0, 0}, {0, 7, 0}, {0, 0, 7}};
  PrintRandom3x3Matrix(mat);
  if (IsScalar(mat))
    cout << "The matrix is Scalar matrix.";
  else
    cout << "The matrix is Not Scalar matrix.";
  return 0;
  */
};


// Course Code
/*
#include <iostream>
#include <iomanip>

using namespace std;

void PrintMatrix(int arr[3][3], short rows, short cols) {
    for (short i = 0; i < rows; i++) {
        for (short j = 0; j < cols; j++) {
            cout << setw(3) << arr[i][j] << " ";
        }
        cout << "\n";
    }
}

bool IsScalarMatrix(int matrix1[3][3], short rows, short cols) {
    // Store the first diagonal element for comparison
    int firstDiagonalElement = matrix1[0][0];

    for (short i = 0; i < rows; i++) {
        for (short j = 0; j < cols; j++) {
            // Check for diagonal elements
            if (i == j && matrix1[i][j] != firstDiagonalElement) {
                return false;
            }
            // Check for rest elements
            else if (i != j && matrix1[i][j] != 0) {
                return false;
            }
        }
    }
    return true;
}

int main() {
    int matrix1[3][3] = {{9, 0, 0}, {0, 9, 0}, {0, 0, 9}};

    cout << "\nMatrix1:\n";
    PrintMatrix(matrix1, 3, 3);

    if (IsScalarMatrix(matrix1, 3, 3)) {
        cout << "\nYES: Matrix is scalar.";
    } else {
        cout << "\nNo: Matrix is NOT scalar.";
    }

    return 0;
}
*/