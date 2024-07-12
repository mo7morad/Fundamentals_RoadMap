#include <iostream>
#include <cstdlib>
using namespace std;

// ########################################### My Solution ##############################################

/* int ReadPositiveNumber(string msg)
{
  int Number = 0;
  do
  {
    cout << msg;
    cin >> Number;
  } while (Number <= 0);
  return Number;
};


int RandomNumber(int From, int To)
{
  int randNum = rand() % (To - From + 1) + From;
  return randNum;
};

string FourCharGenerator()
{
  string Result = "";
  for  (int i = 0; i < 4; ++i)
  {
    Result += (char)RandomNumber(65, 90);
  }
  return Result;
}

void KeyGenerator(short NumberOfKeys)
{

  for (int i = 1; i <= NumberOfKeys; i++)
  {
    string KeyValue = "";
    cout << "\nKey [" << i << "] : ";
    for (int j = 1; j <= 4; j++)
    {
      if (j != 4)
        KeyValue += FourCharGenerator() + "-";
      else
        KeyValue += FourCharGenerator();
    }
    cout << KeyValue;
  }
}



int main()
{
  srand((unsigned)time(NULL));
  KeyGenerator(ReadPositiveNumber("Please enter how many keys you want: "));
  return 0;
}*/

// ########################################### Course Solution + Own Modification #######################

#include <iostream>
#include <string>
using namespace std;


enum enCharType
{
  SamallLetter = 1,
  CapitalLetter = 2,
  SpecialCharacter = 3,
  Digit = 4
};


int RandomNumber(int From, int To)
{
  // Function to generate a random number
  int randNum = rand() % (To - From + 1) + From;
  return randNum;
}


char GetRandomCharacter(enCharType CharType)
{
  switch (CharType)
  {
  case enCharType::SamallLetter:
  {
    return char(RandomNumber(97, 122));
  }
  case enCharType::CapitalLetter:
  {
    return char(RandomNumber(65, 90));
  }
  case enCharType::SpecialCharacter:
  {
    return char(RandomNumber(33, 47));
  }
  case enCharType::Digit:
  {
    return char(RandomNumber(48, 57));
  }
  }
}


int ReadPositiveNumber(string Message)
{
  int Number = 0;
  do
  {
    cout << Message << endl;
    cin >> Number;
  } while (Number <= 0);
  return Number;
}


string GenerateWord(enCharType CharType, short Length)
{
  string Word;
  for (int i = 1; i <= Length; i++)
  {
    Word += GetRandomCharacter(CharType);
  }
  return Word;
}


string GenerateKey()
{
  string Key = "";
  for (int i = 1; i <= 4; ++i)
  {
    if (i != 4)
      Key += GenerateWord(CapitalLetter, 4) + "-";
    else
      Key += GenerateWord(CapitalLetter, 4);
  }
  return Key;
}

void GenerateKeys(short NumberOfKeys)
{
  for (int i = 1; i <= NumberOfKeys; i++)
  {
    cout << "Key [" << i << "] : ";
    cout << GenerateKey() << endl;
  }
}

int main()
{
  // Seeds the random number generator in C++, called only once
  srand((unsigned)time(NULL));
  GenerateKeys(ReadPositiveNumber("Pleaes enter how many keys to generate? \n "));
  return 0;
}
