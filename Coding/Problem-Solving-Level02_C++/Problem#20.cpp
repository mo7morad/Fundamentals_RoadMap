#include <iostream>
#include <cstdlib>
#include <ctime> 
using namespace std;

enum enRandomStuff
{
  SmallLetter = 1,
  CapitalLetter = 2,
  SpecialCharacter = 3,
  Digit = 4
};

int RandomNumber(int From, int To)
{
  int randNum = rand() % (To - From + 1) + From;
  return randNum;
}

void RandomStuffGenerator(enRandomStuff TypeOfThing)
{
  switch (TypeOfThing)
  {
  case SmallLetter:
    cout << (char)RandomNumber(97, 122) << endl;
    break;
  case CapitalLetter:
    cout << (char)RandomNumber(65, 90) << endl;
    break;
  case SpecialCharacter:
    // Randomly select from ASCII range of special characters
    cout << (char)(RandomNumber(33, 47) + RandomNumber(58, 64) + RandomNumber(91, 96)) << endl;
    break;
  case Digit:
    cout << RandomNumber(0, 9) << endl;
    break;
  default:
    cout << "Invalid type of thing" << endl;
    break;
  }
}

int main()
{
  srand((unsigned)time(NULL));

  RandomStuffGenerator(SmallLetter);
  RandomStuffGenerator(CapitalLetter);
  RandomStuffGenerator(SpecialCharacter);
  RandomStuffGenerator(Digit);
  return 0;
}
