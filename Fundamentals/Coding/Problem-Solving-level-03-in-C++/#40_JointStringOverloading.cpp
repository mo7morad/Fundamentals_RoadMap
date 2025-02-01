#include <string>
#include <iostream>
#include <vector>
using namespace std;

string JoinString(vector<string> &str, string delimiter)
{
  string result = "";
  for (int i = 0; i < str.size(); i++)
  {
    result += str[i];
    if (i != str.size() - 1)
    {
      result += delimiter;
    }
  }
  return result;
}

string JoinString(string arr[], short length, string delimiter)
{
  string result = "";
  for (int i = 0; i < length; i++)
  {
    result += arr[i];
    if (arr[i] != arr[length] )
    {
      result += delimiter;
    }
  }
  return result;
}

int main()
{
  vector<string> vWords = {"Ahmed", "Mohamed", "Ali", "Mona"};
  string ArrString[4] = {"Mahmoud", "Hady", "Fady", "Alaa"};
  string delimiter = "#*#";
  cout << "Vector Join-string funciton: " << endl;
  cout << JoinString(vWords, delimiter) << endl;
  cout << "Array Join-string funciton: " << endl;
  cout << JoinString(ArrString, 4, delimiter) << endl;
  return 0;
}

// Course Code

/*
#include <string>
#include <iostream>
#include <vector>

using namespace std;

string JoinString(vector<string> vString, string Delim) {
    string S1 = "";
    for (string& s : vString) {
        S1 = S1 + s + Delim;
    }
    return S1.substr(0, S1.length() - Delim.length());
}

string JoinString(string arrString[], short Length, string Delim) {
    string S1 = "";
    for (short i = 0; i < Length; i++) {
        S1 = S1 + arrString[i] + Delim;
    }
    return S1.substr(0, S1.length() - Delim.length());
}

int main() {
    vector<string> vString = { "Mohammed", "Faid", "Ali", "Maher" };
    string arrString[] = { "Mohammed", "Faid", "Ali", "Maher" };
    cout << "\nVector after join: \n";
    cout << JoinString(vString, " ");
    cout << "\n\nArray after join: \n";
    cout << JoinString(arrString, 4, " ");
    system("pause>0");
    return 0;
}
*/