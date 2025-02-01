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



int main()
{
  srand((unsigned)time(NULL));
  int mat[3][3];
  GetRandom3x3Matrix(mat);
  PrintRandom3x3Matrix(mat);
  short NumberToSearch = ReadPositiveNumber("Please enter the number you want to count in the matrix: ");
  cout << "The number " << NumberToSearch << " appears " << NumCountInMatrix(NumberToSearch, mat) << " times in the matrix" << endl;
  return 0;

};


// Course code

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

short CountNumberInMatrix(int matrix1[3][3], int number, short rows, short cols) {
    short numberCount = 0;
    for (short i = 0; i < rows; i++) {
        for (short j = 0; j < cols; j++) {
            if (matrix1[i][j] == number) {
                numberCount++;
            }
        }
    }
    return numberCount;
}

int main() {
    int matrix1[3][3] = {{9, 1, 12}, {0, 9, 1}, {0, 9, 9}};

    cout << "\nMatrix1:\n";
    PrintMatrix(matrix1, 3, 3);

    int number;
    cout << "\nEnter the number to count in the matrix: ";  // Improved prompt
    cin >> number;

    cout << "\nNumber " << number << " count in the matrix is "
        << CountNumberInMatrix(matrix1, number, 3, 3) << endl;

    return 0;
}
*/