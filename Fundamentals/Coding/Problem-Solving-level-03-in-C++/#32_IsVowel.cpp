#include <iostream>
#include <cstdlib>
#include <iomanip>
using namespace std;

char ReadChar()
{
  char C;
  cout << "Please Enter Your Character:\n";
  cin >> C;
  cin.ignore();
  return C;
}

bool ValidateVowel(char Character)
{
  Character = (char)tolower(Character);
  switch (Character)
  {
  case 'a':
  case 'e':
  case 'i':
  case 'o':
  case 'u':
    return 1;
  default:
    return 0;
  }
}

int main()
{
  cout << (ValidateVowel(ReadChar()) ? "Yes, the char is a vowel." : "No, the char is not a vowel.") << endl;
  return 0;
}

// Course Code

/*
#include<string>
#include<iostream>
using namespace std;

// Function to read a character from the user
char ReadChar() {
    char Ch1;
    cout << "\nPlease Enter a Character?\n";
    cin >> Ch1;
    return Ch1;
}

// Function to check if a character is a vowel
bool IsVowel(char Ch1) {
    Ch1 = tolower(Ch1);
    return (Ch1 == 'a' || Ch1 == 'e' || Ch1 == 'i' || Ch1 == 'o' || Ch1 == 'u');
}

int main() {
    char Ch1 = ReadChar();
    if (IsVowel(Ch1)) {
        cout << "\nYES Letter \'" << Ch1 << "\' is a vowel";
    } else {
        cout << "\nNO Letter \'" << Ch1 << "\' is NOT a vowel";
    }
    system("pause>0");
    return 0; // Added return statement to indicate successful execution
}
*/
