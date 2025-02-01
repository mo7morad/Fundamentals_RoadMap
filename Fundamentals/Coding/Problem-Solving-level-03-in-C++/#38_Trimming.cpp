#include <string>
#include <iostream>
#include <vector>
using namespace std;

string ReadString()
{
  string S1;
  cout << "Please Enter Your String?\n";
  getline(cin, S1);
  return S1;
}

string TrimLeft(string S1)
{
  string s;
  for (short i = 0; i < S1.length(); i++)
  {
    if (S1[i] != ' ')
    {
      s = S1.substr(i);
      return s;
    }
  }
  return S1;
}

string TrimRight(string S1)
{
  string s;
  for (short i = S1.length() - 1; i >= 0; i--)
  {
    if (S1[i] != ' ')
    {
      s = S1.substr(0, i+1);
      return s;
    }
  }
  return S1;
}

string Trim(string S1)
{
  return TrimLeft(TrimRight(S1));
}


int main()
{
  string S1 = "    Mohamed Essam Ahmed Morad.       ";
  cout << "Left Trimming: " << TrimLeft(S1) << endl;
  cout << "Right Trimming: " <<TrimRight(S1) << endl;
  cout << "Full Trimming: " << Trim(S1) << endl;
  return 0;
}

// Course Code

/*
#include <string>
#include <iostream>

using namespace std;

string TrimLeft(string S1) {
    for (short i = 0; i < S1.length(); i++) {
        if (S1[i] != ' ') {
            return S1.substr(i, S1.length() - i);
        }
    }
    return "";
}

string TrimRight(string S1) {
    for (short i = S1.length() - 1; i >= 0; i--) {
        if (S1[i] != ' ') {
            return S1.substr(0, i + 1);
        }
    }
    return "";
}

string Trim(string S1) {
    return TrimLeft(TrimRight(S1));
}

int main() {
    string S1 = "      Mohammed Abu-Hahdoud      ";
    cout << "\nString     = " << S1;
    cout << "\n\nTrim Left  = " << TrimLeft(S1);
    cout << "\nTrim Right = " << TrimRight(S1);
    cout << "\nTrim       = " << Trim(S1);
    system("pause>0");
    return 0;
}
*/