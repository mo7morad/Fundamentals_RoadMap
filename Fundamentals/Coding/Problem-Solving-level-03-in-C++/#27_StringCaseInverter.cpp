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

char LetterCaseInverter(char character)
{
  return (islower(character) ? (char)toupper(character) : (char)tolower(character));
}

string SentenceCaseInverter(string Sentence)
{
  for (short i; i < Sentence.length(); ++i)
  {
    Sentence[i] = LetterCaseInverter(Sentence[i]);
  }
  return Sentence;
}

int main()
{
  string Sentence = ReadString();
  cout << SentenceCaseInverter(Sentence);
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

// Function to invert the case of a character
char InvertLetterCase(char char1) {
    return isupper(char1) ? tolower(char1) : toupper(char1);
}

// Function to invert the case of all letters in a string
string InvertAllStringLettersCase(string S1) {
    for (short i = 0; i < S1.length(); i++) {
        S1[i] = InvertLetterCase(S1[i]);
    }
    return S1;
}

int main() {
    string S1 = ReadString();
    cout << "\nString after Inverting All Letters Case:\n";
    S1 = InvertAllStringLettersCase(S1);
    cout << S1 << endl;
    system("pause>0");
    return 0; // Added return statement to indicate successful execution
}
*/