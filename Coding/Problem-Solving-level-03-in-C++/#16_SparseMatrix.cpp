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

bool IsSparse(int Matrix[3][3])
{
  short ZeroCounter = NumCountInMatrix(0, Matrix);
  if (ZeroCounter > 4) // Or if you have rows, cols. should be ZeroCounter > (rows*cols) / 2;
    return true;
  return false;
  /*
    // Or could be:
    return (NumCountInMatrix(0, Matrix) > 4);
  */
}

int main()
{
  // Random case

  /*
  srand((unsigned)time(NULL));
  int mat[3][3];
  int mat2[3][3];
  GetRandom3x3Matrix(mat);
  PrintRandom3x3Matrix(mat);
  if (IsSparse(mat))
    cout << "The matrix is Sparse matrix.";
  else
    cout << "The matrix is Not Sparse matrix.";
  return 0;
  */

  // Sparse case

  int mat[3][3] = {{7, 5, 3}, {0, 9, 0}, {0, 0, 0}};
  PrintRandom3x3Matrix(mat);
  if (IsSparse(mat))
    cout << "The matrix is Sparse matrix.";
  else
    cout << "The matrix is Not Sparse matrix.";
  return 0;
};