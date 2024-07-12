#include <iostream>
using namespace std;


void LettersOnLetters()
{

  for (int i = 65; i <= 90; i++)
  {
    for (int j = 65; j <= 90; j++)
    {
      for (int k = 65; k <= 90; k++)
      {
        cout << char(i) << char(j) << char(k) << endl;
      }
    }
    cout << "----------\n";
  }
};

int main()
{
  LettersOnLetters();
  return 0;
}