#include <iostream>
#include <cstdlib>
#include <iomanip>
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

short NumCountInMatrix(short NumToSearch, int Matrix[3][3])
{
  short Counter = 0;
  for (short i = 0; i < 3; i++)
    for (short j = 0; j < 3; j++)
      if (Matrix[i][j] == NumToSearch)
        Counter++;
  return Counter;
}

bool IsExist(short Number, int Matrix[3][3])
{
  for (short i = 0; i < 3; i++)
    for (short j = 0; j < 3; j++)
      if (Matrix[i][j] == Number)
        return true;
  return false;
}

void PrintIntersectedNumbers(int MatrixOne[3][3], int MatrixTwo[3][3])
{
  for (short i = 0; i < 3; i++)
    for (short j = 0; j < 3; j++)
      if (IsExist((MatrixOne[i][j]), MatrixTwo))
        cout << "Intersected Numbers Are: \n" << MatrixOne[i][j] << "\t" << endl;
  // using ternary operator
  // cout << (IsExist(MatrixOne[i][j], MatrixTwo) ? MatrixOne[i][j] : "No Intersected Numbers") << endl;
  // printf(IsExist(MatrixOne[i][j], MatrixTwo) ? "%d\t" : "", MatrixOne[i][j]);
}



int main()
{
  srand((unsigned)time(NULL));
  int mat1[3][3];
  int mat2[3][3];
  GetRandom3x3Matrix(mat1);
  GetRandom3x3Matrix(mat2);
  PrintRandom3x3Matrix(mat1);
  PrintRandom3x3Matrix(mat2);

  PrintIntersectedNumbers(mat1, mat2);

  return 0;
};

// Course Code

/*
// ProgrammingAdvices.com © Copyright 2022 Problem # 18/3 Solution Using C++

#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

void PrintMatrix(int arr[3][3], short Rows, short Cols) {
    for (short i = 0; i < Rows; i++) {
        for (short j = 0; j < Cols; j++) {
            cout << setw(3) << arr[i][j] << "     ";
        }
        cout << "\n";
    }
}

bool IsNumberInMatrix(int Matrix1[3][3], int Number, short Rows, short Cols) {
    for (short i = 0; i < Rows; i++) {
        for (short j = 0; j < Cols; j++) {
            if (Matrix1[i][j] == Number) {
                return true;
            }
        }
    }
    return false;
}

void PrintIntersectedNumbers(int Matrix1[3][3], int Matrix2[3][3], short Rows, short Cols) {
    int Number;
    for (short i = 0; i < Rows; i++) {
        for (short j = 0; j < Cols; j++) {
            Number = Matrix1[i][j];
            if (IsNumberInMatrix(Matrix2, Number, Rows, Cols)) {
                cout << setw(3) << Number << "     ";
            }
        }
    }
}

int main() {
    int Matrix1[3][3] = { {77, 5, 12}, {22, 20, 1}, {1, 0, 9} };
    int Matrix2[3][3] = { {5, 80, 90}, {22, 77, 1}, {10, 8, 33} };
    cout << "\nMatrix1:\n";
    PrintMatrix(Matrix1, 3, 3);
    cout << "\nMatrix2:\n";
    PrintMatrix(Matrix2, 3, 3);
    cout << "\nIntersected Numbers are: \n\n";
    PrintIntersectedNumbers(Matrix1, Matrix2, 3, 3);
    system("pause>0");
    return 0;
}
*/