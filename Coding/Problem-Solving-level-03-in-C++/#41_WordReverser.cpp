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

vector<string> ReverseSplitString(string S1, string Delim)
{
  short pos = 0;
  string sWord;
  vector<string> vWords;

  // Use find() function to get the position of the delimiters
  while ((pos = S1.find(Delim)) != std::string::npos)
  {
    sWord = S1.substr(0, pos); // store the word
    if (sWord != "")
    {
      vWords.insert(vWords.begin(), sWord);
    }
    S1.erase(0, pos + Delim.length()); // erase() until position and move to next word
  }

  if (S1 != "")
  {
    vWords.insert(vWords.begin(), S1);
  }
  return vWords;
}

int main()
{
  string str = ReadString();
  vector<string> vWords = ReverseSplitString(str, " ");
  for (string &word : vWords)
  {
    cout << word << ' ';
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

string ReverseWordsInString(string S1) {
    vector<string> vString;
    string S2 = "";

    vString = SplitString(S1, " ");

    vector<string>::iterator iter = vString.end();
    while (iter != vString.begin()) {
        --iter;
        S2 += *iter + " ";
    }

    S2 = S2.substr(0, S2.length() - 1); // remove last space
    return S2;
}

int main() {
    string S1 = ReadString();
    cout << "\n\nString after reversing words:";
    cout << "\n" << ReverseWordsInString(S1);
    system("pause>0");
    return 0;
}
*/