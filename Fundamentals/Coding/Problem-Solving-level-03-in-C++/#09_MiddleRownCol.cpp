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

void MultiplyMatrix(int FirstMatrix[3][3], int SecMatrix[3][3], int ResultMatrix[3][3])
{
  for (short i = 0; i < 3; i++)
  {
    for (int j = 0; j < 3; j++)
      ResultMatrix[i][j] = FirstMatrix[i][j] * SecMatrix[i][j];
  }
}

void PrintMiddleRow(int Matrix[3][3]){
  cout << "The middle row is: \n";
  for (short i = 0; i < 3; i++)
  {
    printf("%0*d", 2, Matrix[1][i], "   ");
    cout << "   ";
  }
  cout << endl;
}

void PrintMiddleCol(int Matrix[3][3]){
  cout << "The middle column is: \n";
  for (short i = 0; i < 3; i++)
  {
    printf("%0*d", 2, Matrix[i][1], "   ");
    cout << "   ";
  }
  cout << endl;
};

int main()
{
  srand((unsigned)time(NULL));
  int arr[3][3];
  FillOrdered3x3Matrix(arr);
  Print3x3Matrix(arr);
  PrintMiddleRow(arr);
  PrintMiddleCol(arr);
  return 0;
}

// Course Code

/*
// ProgrammingAdvices.com
// Copyright 2022
// Problem # 09/3 Solution Using C++

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
            printf(" %0*d   ", 2, arr[i][j]); // cout << setw(3) << arr[i][j] << "     ";
        }
        cout << "\n";
    }
}

void PrintMiddleRowOfMatrix(int arr[3][3], short Rows, short Cols) {
    short MiddleRow = Rows / 2;
    for (short j = 0; j < Cols; j++) {
        printf(" %0*d   ", 2, arr[MiddleRow][j]);
    }
    cout << "\n";
}

void PrintMiddleColOfMatrix(int arr[3][3], short Rows, short Cols) {
    short MiddleCol = Cols / 2;
    for (short j = 0; j < Rows; j++) {
        printf(" %0*d   ", 2, arr[j][MiddleCol]);
    }
    cout << "\n";
}

int main() {
    // Seeds the random number generator in C++, called only once
    srand((unsigned)time(NULL));

    int Matrix1[3][3];

    FillMatrixWithRandomNumbers(Matrix1, 3, 3);
    cout << "\nMatrix1:\n";
    PrintMatrix(Matrix1, 3, 3);

    cout << "\nMiddle Row of Matrix1 is:\n";
    PrintMiddleRowOfMatrix(Matrix1, 3, 3);

    cout << "\nMiddle Col of Matrix1 is:\n";
    PrintMiddleColOfMatrix(Matrix1, 3, 3);

    system("pause>0");
}
*/
