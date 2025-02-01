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

short LetterCounter(string String, char Letter)
{
    short counter = 0;
    for (short i = 0; i < String.length(); i++)
    {
        if  (String[i] == Letter)
            counter++;
    }
    return counter;
}


int main()
{
    string Sentence = ReadString();
    cout << LetterCounter(Sentence, 'a');
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

// Function to count the occurrences of a character in a string
short CountLetter(string S1, char Letter) {
    short Counter = 0;
    for (short i = 0; i < S1.length(); i++) {
        if (S1[i] == Letter) {
            Counter++;
        }
    }
    return Counter;
}

int main() {
    string S1 = ReadString();
    char Ch1 = ReadChar();
    cout << "\nLetter \'" << Ch1 << "\' Count = " << CountLetter(S1, Ch1);
    system("pause>0");
    return 0; // Added return statement to indicate successful execution
}
*/