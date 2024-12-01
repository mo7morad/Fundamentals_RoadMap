#include <iostream>
using namespace std;

string ReadPassword()
{
  string Password;
  cout << "Please enter a 3-Letter Password (all capital)?\n";
  cin >> Password;
  return Password;
}

void Check3LetterPassword(string Password)
{
  string Word = "";
  short Trial_Counter = 1;
  for (int i = 65; i <= 90; i++)
  {
    for (int j = 65; j <= 90; j++)
    {
      for (int k = 65; k <= 90; k++)
      {
        Word = string(1, char(i)) + string(1, char(j)) + string(1, char(k));
        cout << "Trail [" << Trial_Counter << "]: " << Word << endl;
        if (Word == Password)
        {
          cout << "\nPassword is: " << Word << endl;
          cout << "Found after " << Trial_Counter << " Trail(s)." << endl;
          return;
        }
        else
        {
          Trial_Counter++;
          continue;
        }
      }
    }
  }

};


int main()
{
  Check3LetterPassword(ReadPassword());
  return 0;
}