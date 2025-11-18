#include <iostream>
using namespace std;

int ReadPositiveNumber(string msg)
{
  int Number = 0;
  do{
    cout << msg;
    cin >> Number;
  }while (Number <= 0);
  return Number;
};

int ReverseNumber (int Number)
{
  int Reminder = 0;
  int ReversedNumber = 0;
  while (Reminder != 0)
  {
    Reminder = Number % 10;
    Number /= 10;
    ReversedNumber = (ReversedNumber * 10) + Reminder;
  }
  return ReversedNumber;
};

bool IsPalindrome(int Number)
{
  return (Number == ReverseNumber(Number));
}

void PrintIfPalindrome(bool is_palindrome)
{
  if  (is_palindrome)
    cout << "The number is a palindrome." << endl;
  else
    cout << "The number is not a palindrome." << endl;
}

int main()
{
  PrintIfPalindrome(IsPalindrome(ReverseNumber(ReadPositiveNumber("Please enter the number to check: "))));
  return 0;
}