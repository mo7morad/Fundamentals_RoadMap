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


void PrintArray(int Array[], short ArrayLength)
{
  for (short i = 0; i < ArrayLength; i++)
  {
    cout << "col [" << i + 1 << "] sum is: ";
    cout << Array[i] << endl;
  }
}

bool IsPalindrome (int Matrix[3][3]){
  if (Matrix[0][0] == Matrix [0][2])
  {
    if (Matrix[1][0] == Matrix[1][2])
    {
      if (Matrix[2][0] == Matrix[2][2])
      {
        return true;
      }
    }
  }
  else
    return false;
}

int main()
{
  srand((unsigned)time(NULL));
  int mat[3][3] = {{1,2,1}, {3,5,3}, {7,0,7}};
  // GetRandom3x3Matrix(mat);
  PrintRandom3x3Matrix(mat);
  if (IsPalindrome(mat))
    cout << "Yes, Palindrome";
  else
    cout << "No, Palindorme";
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

int IsPalindromeMatrix(int Matrix1[3][3], short Rows, short Cols) {
    for (short i = 0; i < Rows; i++) {
        for (short j = 0; j < Cols / 2; j++) {
            if (Matrix1[i][j] != Matrix1[i][Cols - 1 - j]) {
                return false;
            }
        }
    }
    return true;
}
// Or My Updated version for 3x3 only.
// int IsPalindromeMatrix(int Matrix1[3][3], short Rows, short Cols) {
//     for (short i = 0; i < Rows; i++){
//         if (Matrix1[i][0] != Matrix1[i][Cols - 1])
//           return false;
//     }
//   return true;
// };

int main(){

  int Matrix1[3][3] = { {1,2,1},{5,5,5},{7,3,7} };
  cout << "\nMatrix1:\n";
  PrintMatrix(Matrix1, 3, 3);
  if (IsPalindromeMatrix(Matrix1, 3, 3)) {
      cout << "\nYes: Matrix is Palindrome\n";
  } else {
      cout << "\nNo: Matrix is NOT Palindrome\n";
  }
  return 0;
}
*/