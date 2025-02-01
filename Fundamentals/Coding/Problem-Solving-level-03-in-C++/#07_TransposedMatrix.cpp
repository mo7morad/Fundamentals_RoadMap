#include <iostream>
#include <cstdlib>
#include <iomanip>
using namespace std;

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
void Print3x3TransposedMatrix(int arr[3][3])
{
  cout << "Your transposed matrix is: \n";
  for (short i = 0; i < 3; i++)
  {
    for (short j = 0; j < 3; j++)
    {
      cout << setw(3) << arr[j][i] << " ";
    }
    cout << endl;
  }
};

int main()
{
  srand((unsigned)time(NULL));
  int arr[3][3];
  FillOrdered3x3Matrix(arr);
  Print3x3Matrix(arr);
  Print3x3TransposedMatrix(arr);
  return 0;
}


// Course Code

/*
#include <iostream>
#include <string>

using namespace std;

void FillMatrixWithOrderedNumbers(int arr[3][3], short Rows, short Cols) {
    short Counter = 0;
    for (short i = 0; i < Rows; i++) {
        for (short j = 0; j < Cols; j++) {
            Counter++;
            arr[i][j] = Counter;
        }
    }
}

void PrintMatrix(int arr[3][3], short Rows, short Cols) {
    for (short i = 0; i < Rows; i++) {
        for (short j = 0; j < Cols; j++) {
            cout << " " << arr[i][j] << "     ";
        }
        cout << "\n";
    }
}

void TransposeMatrix(int arr[3][3], int arrTransposed[3][3], short Rows, short Cols) {
    for (short i = 0; i < Rows; i++) {
        for (short j = 0; j < Cols; j++) {
            arrTransposed[j][i] = arr[i][j];
        }
    }
}

int main() {
    int arr[3][3], arrTransposed[3][3];

    FillMatrixWithOrderedNumbers(arr, 3, 3);
    cout << "\nThe following is a 3x3 ordered matrix:\n";
    PrintMatrix(arr, 3, 3);

    TransposeMatrix(arr, arrTransposed, 3, 3);
    cout << "\n\nThe following is the transposed matrix:\n";
    PrintMatrix(arrTransposed, 3, 3);

    system("pause>0");
}
*/
