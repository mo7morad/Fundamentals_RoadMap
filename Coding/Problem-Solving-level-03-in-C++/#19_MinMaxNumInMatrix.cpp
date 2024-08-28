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

void MinMaxNumInMatrix(int Matrix[3][3]){
  short Min = Matrix[0][0]; short Max = Matrix[3][3];
  for (short i = 0; i < 3; i++){
    for (short j = 0; j < 3; j++){
      if (Min > Matrix[i][j])
        Min = Matrix[i][j];
      if (Max < Matrix[i][j])
        Max = Matrix[i][j];
    }
  }
  cout << "The minimum num in the matrix is: " << Min << endl;
  cout << "The maximum num in the matrix is: " << Max << endl;
}



int main()
{
  srand((unsigned)time(NULL));
  int mat[3][3];
  GetRandom3x3Matrix(mat);
  PrintRandom3x3Matrix(mat);
  MinMaxNumInMatrix(mat);

  return 0;
};

// Course Code

/*
#include<iostream>
#include<string>
#include<iomanip>

using namespace std;

void PrintMatrix(int arr[3][3], short Rows, short Cols) {
    for (short i = 0; i < Rows; i++) {
        for (short j = 0; j < Cols; j++) {
            cout << setw(3) << arr[i][j] << "     ";
        }
        cout << "\n";
    }
}

int MinNumberInMatrix(int Matrix1[3][3], short Rows, short Cols) {
    int Min = Matrix1[0][0];
    for (short i = 0; i < Rows; i++) {
        for (short j = 0; j < Cols; j++) {
            if (Matrix1[i][j] < Min) {
                Min = Matrix1[i][j];
            }
        }
    }
    return Min;
}

int MaxNumberInMatrix(int Matrix1[3][3], short Rows, short Cols) {
    int Max = Matrix1[0][0];
    for (short i = 0; i < Rows; i++) {
        for (short j = 0; j < Cols; j++) {
            if (Matrix1[i][j] > Max) {
                Max = Matrix1[i][j];
            }
        }
    }
    return Max;
}

int main() {
    int Matrix1[3][3] = { {77,5,12},{22,20,6},{14,3,9} };
    cout << "\nMatrix1:\n";
    PrintMatrix(Matrix1, 3, 3);
    cout << "\nMinimum Number is: ";
    cout << MinNumberInMatrix(Matrix1, 3, 3);
    cout << "\n\nMax Number is: ";
    cout << MaxNumberInMatrix(Matrix1, 3, 3);
    system("pause>0");
    return 0;
}
*/