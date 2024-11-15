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
    if (sWord != "") {
      if (ispunct(sWord[sWord.length() - 1])) {
        sWord = sWord.substr(0, sWord.length() - 1); // Trim punctuation
      }
      vWords.push_back(sWord);
    }
    S1.erase(0, pos + Delim.length()); // erase() until position and move to next word
  }

  if (S1 != "")
  {
    if (ispunct(S1[S1.length() - 1])) {
      S1 = S1.substr(0, S1.length() - 1); // Trim punctuation
    }
    vWords.push_back(S1);
  }
  return vWords;
}

string JoinString(vector <string> &str, string delimiter)
{
  string result = "";
  for (string &word : str)
  {
    result += word;
    if (word != str[str.size()-1])
    {
      result += delimiter;
    }
  }
  return result;
}

string ReplaceWords(string Sentence, string WordToReplace, string WordToInsert, bool CaseSensitive = true){
  vector<string> Words = SplitString(Sentence, " ");
  for (string &s : Words)
  {
    if(CaseSensitive) {
      if (s == WordToReplace) {
        s = WordToInsert;
      }
    }
    else {
      if (LowerAllString(s) == LowerAllString(WordToReplace)) {
        s = WordToInsert;
      }
    }
  }
  return JoinString(Words, " ");
}

int main()
{
  cout << ReplaceWords(ReadString(), "Jordan", "Egypt");
  return 0;
}

// Course Code

/*
#include<string>
#include<iostream>
#include<vector>
using namespace std;

string ReplaceWordInStringUsingBuiltInFunction(string S1, string StringToReplace, string sRepalceTo) {
    short pos = S1.find(StringToReplace);
    while (pos != std::string::npos) {
        S1 = S1.replace(pos, StringToReplace.length(), sRepalceTo);
        pos = S1.find(StringToReplace); // find next
    }
    return S1;
}

int main() {
    string S1 = "Welcome to Jordan, Jordan is a nice country";
    string StringToReplace = "Jordan";
    string ReplaceTo = "USA";

    cout << "\nOriginal String\n" << S1;
    cout << "\n\nString After Replace:";
    cout << "\n" << ReplaceWordInStringUsingBuiltInFunction(S1, StringToReplace, ReplaceTo);
    system("pause>0");
}
*/