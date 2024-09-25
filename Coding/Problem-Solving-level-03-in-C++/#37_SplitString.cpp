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

short CountWords(string S1)
{
  string delim = " "; // delimiter
  short Counter = 0;
  short pos = 0;
  string sWord; // define a string variable
  while ((pos = S1.find(delim)) != std::string::npos)
  {
    sWord = S1.substr(0, pos); // store the word
    if (sWord != "")
    {
      Counter++;
    }
    S1.erase(0, pos + delim.length()); // erase() until position and move to next word.
  }
  if (S1 != "")
  {
    Counter++; // it counts the last word of the string.
  }
  return Counter;
}

vector <string> SplitString(string S1, string Delim)
{
  short pos = 0;
  string sWord;
  vector <string> vWords;

  // Use find() function to get the position of the delimiters
  while ((pos = S1.find(Delim)) != std::string::npos)
  {
    sWord = S1.substr(0, pos); // store the word
    if (sWord != "")
    {
      vWords.push_back(sWord);
    }
    S1.erase(0, pos + Delim.length()); // erase() until position and move to next word
  }

  if (S1 != "")
  {
    vWords.push_back(S1);
  }
  return vWords;
}

int main()
{
  string str = ReadString();
  vector <string> vWords = SplitString(str, " ");
  cout << "Tokens = " << vWords.size() << '\n';
  for (string &s : vWords)
  {
    cout << s << '\n';
  }
  return 0;
}

// Course Code

/*
#include <string>
#include <iostream>
#include <vector>

using namespace std;

string ReadString() {
    string S1;
    cout << "Please Enter Your String?\n";
    getline(cin, S1);
    return S1;
}

vector<string> SplitString(string S1, string Delim) {
    vector<string> vString;
    short pos = 0;
    string sWord;

    while ((pos = S1.find(Delim)) != std::string::npos) {
        sWord = S1.substr(0, pos);
        if (sWord != "") {
            vString.push_back(sWord);
        }
        S1.erase(0, pos + Delim.length());
    }

    if (S1 != "") {
        vString.push_back(S1);
    }

    return vString;
}

int main() {
    vector<string> vString;
    vString = SplitString(ReadString(), " ");
    cout << "\nTokens = " << vString.size() << endl;

    for (string& s : vString) {
        cout << s << endl;
    }

    system("pause>0");
    return 0;
}
*/