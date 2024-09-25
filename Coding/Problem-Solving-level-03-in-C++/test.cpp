#include <string>
#include <iostream>
using namespace std;

string ReadString()
{
  string S1;
  cout << "Please Enter Your String?\n";
  getline(cin, S1);
  return S1;
}

void PrintEachWordInString(string S1)
{
  string delim = " "; // delimiter
  cout << "\nYour string words are: \n\n";
  size_t pos = 0, PrevPos = 0;

  // Use find() function to get the position of the delimiters
  while ((pos = S1.find(delim, PrevPos)) != string::npos)
  {
    string sWord = S1.substr(PrevPos, pos); // store the word
    if (!sWord.empty())                               // Check if it's not an empty word
    {
      cout << sWord << endl;
    }
    PrevPos = pos; // Move past the delimiter
  }

  // // Print the last word after the last delimiter
  // if (PrevPos < S1.length())
  // {
  //   cout << S1.substr(PrevPos) << endl;
  // }
}

int main()
{
  PrintEachWordInString(ReadString());
  return 0;
}
