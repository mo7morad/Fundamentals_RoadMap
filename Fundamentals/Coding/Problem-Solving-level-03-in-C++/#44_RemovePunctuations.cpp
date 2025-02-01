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

string LowerAllString(string S1)
{
  for (short i = 0; i < S1.length(); i++)
  {
    S1[i] = tolower(S1[i]);
  }
  return S1;
}

vector<string> SplitString(string S1, string Delim)
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
      if (ispunct(sWord[sWord.length() - 1]))
      {
        sWord = sWord.substr(0, sWord.length() - 1); // Trim punctuation
      }
      vWords.push_back(sWord);
    }
    S1.erase(0, pos + Delim.length()); // erase() until position and move to next word
  }

  if (S1 != "")
  {
    if (ispunct(S1[S1.length() - 1]))
    {
      S1 = S1.substr(0, S1.length() - 1); // Trim punctuation
    }
    vWords.push_back(S1);
  }
  return vWords;
}

string JoinString(vector<string> &str, string delimiter)
{
  string result = "";
  for (string &word : str)
  {
    result += word;
    if (word != str[str.size() - 1])
    {
      result += delimiter;
    }
  }
  return result;
}

string RemovePunctuations(string S1) {
  vector<string> Words = SplitString(S1, " ");
  for (string &s : Words) {
    for (short i = 0; i < s.length(); i++) {
      if (ispunct(s[i])) {
        s.erase(i,1);
      }
    }
  }
  return JoinString(Words, " ");
}



int main()
{
  cout << RemovePunctuations(ReadString());
  return 0;
}

// Course Code

/*
#include<string>
#include<iostream>
#include<vector>
using namespace std;

string RemovePunctuationsFromString(string S1) {
    string S2 = "";
    for (short i = 0; i < S1.length(); i++) {
        if (!ispunct(S1[i])) {
            S2 += S1[i];
        }
    }
    return S2;
}

int main() {
    string S1 = "Welcome to Jordan, Jordan is a nice country; it's amazing.";
    cout << "Original String:\n" << S1;
    cout << "\n\nPunctuations Removed:\n" << RemovePunctuationsFromString(S1);
    system("pause>0");
}
*/