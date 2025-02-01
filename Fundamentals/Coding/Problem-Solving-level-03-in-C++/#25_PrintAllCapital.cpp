#include <iostream>
#include <cstdlib>
#include <iomanip>
using namespace std;

void PrintAllLettersCapital(string Sentence)
{
  for (short i = 0; i < Sentence.length(); i++)
  {
    cout << (islower(Sentence[i])? (char)toupper(Sentence[i]) : Sentence[i]);
  }
}
void PrintAllLettersLower(string Sentence)
{
  for (short i = 0; i < Sentence.length(); i++)
  {
    cout << (isupper(Sentence[i])? (char)tolower(Sentence[i]) : Sentence[i]);
  }
}

int main()
{
  cout << "All upper: \n";
  PrintAllLettersCapital("this sentence is all in lowercase letters!");
  cout << "\nAll lower: \n"; 
  PrintAllLettersLower("THIS SENTENCE IS ALL IN UPPERCASE LETTERS!");
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

// Function to convert a string to uppercase
string UpperAllString(string S1) {
    for (short i = 0; i < S1.length(); i++) {
        S1[i] = toupper(S1[i]);
    }
    return S1;
}

// Function to convert a string to lowercase
string LowerAllString(string S1) {
    for (short i = 0; i < S1.length(); i++) {
        S1[i] = tolower(S1[i]);
    }
    return S1;
}

int main() {
    string S1 = ReadString();
    cout << "\nString after Upper:\n";
    S1 = UpperAllString(S1);
    cout << S1 << endl;
    cout << "\nString after Lower:\n";
    S1 = LowerAllString(S1);
    cout << S1 << endl;
    system("pause>0");
    return 0; // Added return statement to indicate successful execution
}
*/