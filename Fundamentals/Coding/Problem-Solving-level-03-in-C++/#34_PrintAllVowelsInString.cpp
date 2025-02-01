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

string ReadString()
{
  string str;
  cout << "Enter your string: ";
  getline(cin, str);
  return str;
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

void PrintVowelsInString(string Sentence)
{
  cout << "The vowels in the string are: " << endl;
  for (short i = 0; i < Sentence.length(); ++i)
  {
    if (ValidateVowel(Sentence[i]))
      cout << Sentence[i] << setw(3);
  }
  cout << '\n';
}

int main()
{
  PrintVowelsInString(ReadString());
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
    cout << "\nPlease Enter Your String?\n";
    getline(cin, S1);
    return S1;
}

// Function to check if a character is a vowel
bool IsVowel(char Ch1) {
    Ch1 = tolower(Ch1);
    return (Ch1 == 'a' || Ch1 == 'e' || Ch1 == 'i' || Ch1 == 'o' || Ch1 == 'u');
}

// Function to count the number of vowels in a string
short CountVowels(string S1) {
    short Counter = 0;
    for (short i = 0; i < S1.length(); i++) {
        if (IsVowel(S1[i])) {
            Counter++;
        }
    }
    return Counter;
}

int main() {
    string S1 = ReadString();
    cout << "\nNumber of vowels is: " << CountVowels(S1);
    system("pause>0");
    return 0; // Added return statement to indicate successful execution
}
*/
