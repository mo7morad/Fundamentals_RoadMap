#include <iostream>
#include <cstdlib>
#include <iomanip>
#include <string>
using namespace std;

int NonRepeatingChar(string Word){
  for (int i = 0; i < Word.length(); i++){
    char c = Word[i];
    short counter = 0;
    for (int j = 0; j < Word.length(); j++){
      if (c == Word[j])
        counter++;
      if (counter > 1)
        break;
    }
    if (counter == 1)
      return i;
  }
  return -1;
};


int main()
{
  string Word1 = "helloworld";
  string Word2 = "idontloveindonesia";
  string Word3 = "aabbcc";
  string Word4 = "hheelloowworld";
  string Word5 = "heyboyh";
  cout << NonRepeatingChar(Word1) << endl;
  cout << NonRepeatingChar(Word2) << endl;
  cout << NonRepeatingChar(Word3) << endl;
  cout << NonRepeatingChar(Word4) << endl;
  cout << NonRepeatingChar(Word5) << endl;
  return 0;
}