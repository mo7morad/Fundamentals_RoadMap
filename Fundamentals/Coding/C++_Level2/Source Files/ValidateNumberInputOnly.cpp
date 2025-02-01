#include <iostream>
#include <limits>

using namespace std;

int ReadNumber()
{
  int Number;
  cout << "Please enter a number?" << endl;
  cin >> Number;

  while (cin.fail())
  {
    // Clear the error flag on cin
    cin.clear();
    // Ignore the invalid input up to the maximum stream size or until a newline character
    cin.ignore(numeric_limits<streamsize>::max(), '\n');
    cout << "Invalid number, please enter a valid one:" << endl;
    cin >> Number;
  }

  return Number;
}

int main()
{
  int Number = ReadNumber();
  cout << "Your number is: " << Number << endl;
  return 0;
}
