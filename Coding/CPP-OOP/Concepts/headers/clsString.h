#pragma once
#include <iostream>
using namespace std;

class clsString
{
private:
  string _Value;

public:
  clsString()
  {
    _Value = "";
  }
  clsString(string Value)
  {
    _Value = Value;
  }
  void SetValue(string Value)
  {
    _Value = Value;
  }
  string GetValue()
  {
    return _Value;
  }

static short CountWords(string S1)
  {
    string delim = " "; // delimiter
    short Counter = 0;
    short pos = 0;
    string sWord; // define a string variable
    // use find() function to get the position of the delimiters 
    while ((pos = S1.find(delim)) != std::string::npos)
    {
      sWord = S1.substr(0, pos); // store the word
      if (sWord != "")
      {
        Counter++;
      }
      // erase() until positon and move to next word.
      S1.erase(0, pos + delim.length());
    }
    if (S1 != "")
    {
      Counter++; // it counts the last word of the string.
    }
    return Counter;
  }
  short CountWords()
  {
    return CountWords(_Value);
  };
};