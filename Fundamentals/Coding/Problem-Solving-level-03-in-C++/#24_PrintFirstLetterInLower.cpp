#include <iostream>
#include <cstdlib>
#include <iomanip>
using namespace std;

void PrintFirstLetterInLower(string Sentence)
{
  
  for (short i = 0; i < Sentence.length(); i++)
  {
    if (i == 0 || !isalpha(Sentence[i - 1]))
    {
      cout << (char)tolower(Sentence[i]) << " ";
    }
  }
}

int main()
{
  PrintFirstLetterInLower("This Is Mohamed Essam Ahmed Morad.");
  return 0;
};

// Course Code

/*

*/
