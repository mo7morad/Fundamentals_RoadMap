#include <iostream>
using namespace std;


void LettersOnLetters()
{

  for (int i = 65; i <= 90; i++)
  {
    for (int j = 65; j <= 90; j++)
    {
      cout << char(i) << char(j) << endl;
    }
    cout << "----------\n";
  }
};

void ReversedStarsTriangel()
{
  for (int i = 10; i > 0; i--)
  {
    for  (int j = 0; j < i; j++ )
    {
      cout << "* ";
    }
    cout << "\n";
  }
};

void ReversedNumbersTriangle()
{
  for (int i = 10; i > 0; i--)
  {
    for  (int j = 1; j <= i; j++ )
    {
      cout << j << " ";
    }
    cout << "\n";
  }
};

void NumbersTraingle()
{
  for (int i = 1; i <= 10; i++)
  {
    for (int j = 1; j <= i; j++)
    {
      cout << j << " ";
    }
    cout << endl;
  }
};

void MinusedNumberTraingleV1()
{
  int counter = 1;
  for (int i = 10; i > 0; i--)
  {
    for (int j = counter; j <= 10; j++)
    {
      cout << j << " ";
    }
    cout << "\n";
    counter++;
  }
};

void MinusedNumberTraingleV2()
{
  for (int i = 1; i <= 10; i++)
  {
    for (int j = i; j <= 10; j++)
    {
      cout << j << " ";
    }
    cout << "\n";
  }
};

int main()
{

LettersOnLetters();
  return 0;
}