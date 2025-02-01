#include <iostream>
#include <cstdlib>
#include <iomanip>
using namespace std;

string ReadString()
{
  string S;
  cout << "Please Enter Your String?\n";
  getline(cin, S);
  return S;
}

void PrintStringInfo(string Sentence)
{
  short StringLength = Sentence.length(), LowerCount = 0, CapitalCount = 0;

  for (short i; i < StringLength; ++i)
  {
    ((isupper(Sentence[i])) ? ++CapitalCount : (islower(Sentence[i])) ? ++LowerCount : 0);
  }
  cout << "String length is: " << StringLength << endl;
  cout << "Capital letters count: " << CapitalCount << endl;
  cout << "Lower letters count: " << LowerCount << endl;
}

int main()
{
  string Sentence = ReadString();
  PrintStringInfo(Sentence);
  return 0;
};

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

// Method 1: Separate functions for counting capital letters and small letters
short CountCapitalLetters(string S1) {
    short Counter = 0;
    for (short i = 0; i < S1.length(); i++) {
        if (isupper(S1[i])) {
            Counter++;
        }
    }
    return Counter;
}

short CountSmallLetters(string S1) {
    short Counter = 0;
    for (short i = 0; i < S1.length(); i++) {
        if (islower(S1[i])) {
            Counter++;
        }
    }
    return Counter;
}

// Method 2: Single function with enumeration
enum enWhatToCount { SmallLetters = 0, CapitalLetters = 1, All = 2 };

short CountLetters(string S1, enWhatToCount WhatToCount = enWhatToCount::All) {
    if (WhatToCount == enWhatToCount::All) {
        return S1.length();
    }
    short Counter = 0;
    for (short i = 0; i < S1.length(); i++) {
        if (WhatToCount == enWhatToCount::CapitalLetters && isupper(S1[i])) {
            Counter++;
        }
        if (WhatToCount == enWhatToCount::SmallLetters && islower(S1[i])) {
            Counter++;
        }
    }
    return Counter;
}

int main() {
    string S1 = ReadString();
    cout << "\nString Length = " << S1.length();
    cout << "\nCapital Letters Count = " << CountCapitalLetters(S1);
    cout << "\nSmall Letters Count = " << CountSmallLetters(S1);
    cout << "\n\nMethod 2\n";
    cout << "\nString Length = " << CountLetters(S1);
    cout << "\nCapital Letters Count = " << CountLetters(S1, enWhatToCount::CapitalLetters);
    cout << "\nSmall Letters Count = " << CountLetters(S1, enWhatToCount::SmallLetters);
    system("pause>0");
    return 0; // Added return statement to indicate successful execution
}
*/