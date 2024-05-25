#include <iostream>
using namespace std;

enum enCharType
{
  SamallLetter = 1,
  CapitalLetter = 2,
  SpecialCharacter = 3,
  Digit = 4
};

int ReadPositiveNumber(string Message)
{
  int Number = 0;
  do
  {
    cout << Message << endl;
    cin >> Number;
  } while (Number <= 0);
  return Number;
};

int RandomNumber(int From, int To)
{
  // Function to generate a random number
  int randNum = rand() % (To - From + 1) + From;
  return randNum;
};


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
  default:
    return ' ';
  }
};


void PrintStringArray(string arr[100], int arrLength)
{
  cout << "\nArray elements:\n";
  for (int i = 0; i < arrLength; i++)
    cout << "Array[" << i << "] : " << arr[i] << endl;
};


string GenerateWord(enCharType CharType, short Length)
{
  string Word;
  for (int i = 1; i <= Length; i++)
  {
    Word = Word + GetRandomCharacter(CharType);
  }
  return Word;
};

string KeyGenerator()
{
  string Key = "";
  for (int i = 1; i <= 4; i++)
  {
    if (i != 4)
    {
      Key += GenerateWord(CapitalLetter, 4) + "-";
    }
    else
    {
      Key += GenerateWord(CapitalLetter, 4);
    }
  }
  return Key;
};


void FillArrayWithKeys(string arr[100], int arrLength)
{
  for (int i = 0; i < arrLength; i++)
    arr[i] = KeyGenerator();
};


int main()
{
  // Seeds the random number generator in C++, called only once
  srand((unsigned)time(NULL));
  string arr[100];
  short arrLength = 0;
  arrLength = ReadPositiveNumber("How many keys do you want to generate?");

  FillArrayWithKeys(arr, arrLength);
  PrintStringArray(arr, arrLength);
  return 0;
}