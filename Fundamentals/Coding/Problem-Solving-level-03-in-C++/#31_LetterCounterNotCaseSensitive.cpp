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

char ReadChar()
{
  char C;
  cout << "Please Enter Your Character:\n";
  cin >> C;
  cin.ignore();
  return C;
}

char InvertLetterCase(char character)
{
  return (islower(character) ? (char)toupper(character) : (char)tolower(character));
}

void LetterCounter(string String, char Letter)
{
  short NonSensitiveCounter = 0, SensitiveCounter = 0;
  for (short i = 0; i < String.length(); i++)
  {
    if (String[i] == Letter)
      SensitiveCounter++;
    if (String[i] == Letter || String[i] ==  InvertLetterCase(Letter))
      NonSensitiveCounter++;
  }
  cout << "Letter \'" << Letter << "\' count is:  " << SensitiveCounter << endl;
  cout << "Letter \'" << Letter << "\' or \'" << InvertLetterCase(Letter)  << "\' count is:  " << NonSensitiveCounter << endl;
}

int main()
{
  LetterCounter(ReadString(), ReadChar());
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
    cout << "\nPlease Enter Your String?\n";
    getline(cin, S1);
    return S1;
}

// Function to read a character from the user
char ReadChar() {
    char Ch1;
    cout << "\nPlease Enter a Character?\n";
    cin >> Ch1;
    return Ch1;
}

// Function to invert the case of a character
char InvertLetterCase(char char1) {
    return isupper(char1) ? tolower(char1) : toupper(char1);
}

// Function to count the occurrences of a character in a string
short CountLetter(string S1, char Letter, bool MatchCase = true) {
    short Counter = 0;
    for (short i = 0; i < S1.length(); i++) {
        if (MatchCase) {
            if (S1[i] == Letter) {
                Counter++;
            }
        } else {
            if (tolower(S1[i]) == tolower(Letter)) {
                Counter++;
            }
        }
    }
    return Counter;
}

int main() {
    string S1 = ReadString();
    char Ch1 = ReadChar();
    cout << "\nLetter \'" << Ch1 << "\' Count = " << CountLetter(S1, Ch1);
    cout << "\nLetter \'" << Ch1 << "\' ";
    cout << "Or \'" << InvertLetterCase(Ch1) << "\' ";
    cout << "Count = " << CountLetter(S1, Ch1, false);
    system("pause>0");
    return 0; // Added return statement to indicate successful execution
}
*/