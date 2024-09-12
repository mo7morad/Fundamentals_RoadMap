#include <iostream>
#include <cstdlib>
#include <iomanip>
using namespace std;

void PrintFirstLetter(string Sentence){
  for (short i = 0; i < Sentence.length(); i++){
    if (i == 0 || !isalpha(Sentence[i-1])){
      cout << Sentence[i] << " ";
    }
  }
}

int main()
{
  PrintFirstLetter("This Is Mohameed Abo-Morad");
  return 0;
};


// Course Code

/*
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

void PrintFirstLetterOfEachWord(string S1)
{
  bool isFirstLetter = true;
  cout << "\nFirst letters of this string: \n";
  for (short i = 0; i < S1.length(); i++)
  {
    if (S1[i] != ' ' && isFirstLetter)
    {
      cout << S1[i] << endl;
    }
    isFirstLetter = (S1[i] == ' ' ? true : false);
  }
}


int main()
{
  PrintFirstLetterOfEachWord(ReadString());
  system("pause>0");
  return 0;
}
*/