#include <iostream>
#include <string>
using namespace std;

int ReadPositiveNumber(string msg)
{
  int Number;
  do
  {
    cout << msg << endl;
    cin >> Number;
  }while(Number < 0);
  return Number;
};

void PrintNumberRedundancy(int Number, int Sequence)
{
  string str_number = to_string(Sequence);
  int counter = 0;
  for (int i = str_number.length()-1; i > 0; i--)
  {
    if (str_number[i] == (char)Number + '0')
      counter ++;
  }
  cout << "Digit " << Number << " is repeated " << counter << " times in the number."<<endl;
}


int main()
{
  PrintNumberRedundancy(ReadPositiveNumber("Please enter the number you want to search for: "), ReadPositiveNumber("Please enter the sequance of the number to search in: "));
}