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

short CountEachWordInString(string S1)
{
  string delim = " "; // delimiter
  short pos = 0, count = 0;
  string sWord; // define a string variable

  // Use find() function to get the position of the delimiters
  while ((pos = S1.find(delim)) != std::string::npos)
  {
    sWord = S1.substr(0, pos); // store the word
    if (sWord != "")
    {
      count++;
    }
    S1.erase(0, pos + delim.length()); // erase() until position and move to next word
  }

  if (S1 != "")
  {
    count++;
  }
  return count;
}

int main()
{
  cout << CountEachWordInString(ReadString()) << " Words in the sentence you've entered.";
  return 0;
}

// Course Code

/*
#include<string>
#include<iostream>
using namespace std;

// Function to read a string from the user
string ReadString() {
    string S1;
    cout << "Please Enter Your String?\n";
    getline(cin, S1);
    return S1;
}

// Function to count the number of words in a string
short CountWords(string S1) {
    string delim = " "; // delimiter
    short Counter = 0;
    short pos = 0;
    string sWord; // define a string variable
    while ((pos = S1.find(delim)) != std::string::npos) {
        sWord = S1.substr(0, pos); // store the word
        if (sWord != "") {
            Counter++;
        }
        S1.erase(0, pos + delim.length()); // erase() until position and move to next word.
    }
    if (S1 != "") {
        Counter++; // it counts the last word of the string.
    }
    return Counter;
}

int main() {
    string S1 = ReadString();
    cout << "\nThe number of words in your string is: ";
    cout << CountWords(S1);
    system("pause>0");
    return 0; // Added return statement to indicate successful execution
}

*/