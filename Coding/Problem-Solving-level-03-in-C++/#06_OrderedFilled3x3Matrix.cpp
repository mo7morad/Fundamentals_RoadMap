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

int main()
{
  srand((unsigned)time(NULL));
  int arr[3][3];
  FillOrdered3x3Matrix(arr);
  Print3x3Matrix(arr);
  return 0;
}
