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

bool IsExsit(short Number, int Matrix[3][3])
{
  for (short i = 0; i < 3; i++)
    for (short j = 0; j < 3; j++)
      if (Matrix[i][j] == Number)
        return true;
  return false;
}

int main()
{
  srand((unsigned)time(NULL));
  int mat[3][3];
  GetRandom3x3Matrix(mat);
  PrintRandom3x3Matrix(mat);

  if (IsExsit(ReadPositiveNumber("Please enter the number to search for: "), mat))
    cout << "The number is in the matrix" << endl;
  else
    cout << "The number is NOT in the matrix" << endl;

  return 0;

};

// Course Code

/*
// ProgrammingAdvices.com © Copyright 2022 Problem # 17/3 Solution Using C++

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

short CountNumberInMatrix(int Matrix1[3][3], int Number, short Rows, short Cols) {
    short NumberCount = 0;
    for (short i = 0; i < Rows; i++) {
        for (short j = 0; j < Cols; j++) {
            if (Matrix1[i][j] == Number) {
                NumberCount++;
            }
        }
    }
    return NumberCount;
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

int main() {
    int Matrix1[3][3] = { {77, 5, 12}, {22, 20, 1}, {1, 0, 9} };
    cout << "\nMatrix1:\n";
    PrintMatrix(Matrix1, 3, 3);
    int Number;
    cout << "\nPlease Enter the number to look for in matrix? ";
    cin >> Number;
    // Using Count is a slower method
    if (CountNumberInMatrix(Matrix1, Number, 3, 3) > 0) {
        cout << "\nYes it is there.\n";
    } else {
        cout << "\nNo: It's NOT there.\n";
    }
    // This is a faster method
    if (IsNumberInMatrix(Matrix1, Number, 3, 3)) {
        cout << "\nYes it is there.\n";
    } else {
        cout << "\nNo: It's NOT there.\n";
    }
    system("pause>0");
    return 0;
}
*/