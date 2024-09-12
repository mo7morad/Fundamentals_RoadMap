#include <iostream>
#include <cstdlib>
#include <iomanip>
using namespace std;

char InvertLetterCase(char character)
{
  return (islower(character) ? (char)toupper(character) : (char)tolower(character));
}

int main()
{
  cout << InvertLetterCase('j');
  cout << InvertLetterCase('J');
  return 0;
};

// Course Code

/*
#include<string>
#include<iostream>
using namespace std;

// Function to read a character from the user
char ReadChar() {
    char Ch1;
    cout << "Please Enter a Character?\n";
    cin >> Ch1;
    return Ch1;
}

// Function to invert the case of a character
char InvertLetterCase(char char1) {
    return isupper(char1) ? tolower(char1) : toupper(char1);
}

int main() {
    char Ch1 = ReadChar();
    cout << "\nChar after inverting case:\n";
    Ch1 = InvertLetterCase(Ch1);
    cout << Ch1 << endl;
    system("pause>0");
    return 0; // Added return statement to indicate successful execution
}
*/