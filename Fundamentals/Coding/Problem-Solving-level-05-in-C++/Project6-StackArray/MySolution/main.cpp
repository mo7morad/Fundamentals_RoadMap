#include <iostream>
#include "StackArray.h"

using namespace std;

int main()
{

  StackArray<int> MyStackArray;

  MyStackArray.push(10);
  MyStackArray.push(20);
  MyStackArray.push(30);
  MyStackArray.push(40);
  MyStackArray.push(50);

  cout << "\nStack: \n";
  MyStackArray.Display();

  cout << "\nStack Size: " << MyStackArray.Size();
  cout << "\nStack Top: " << MyStackArray.Top();
  cout << "\nStack Bottom: " << MyStackArray.Bottom();

  MyStackArray.pop();

  cout << "\n\nStack after pop() : \n";
  MyStackArray.Display();

  cout << "\n\n Item(2) : " << MyStackArray.GetItem(2);

  MyStackArray.Reverse();
  cout << "\n\nStack after reverse() : \n";
  MyStackArray.Display();

  MyStackArray.Update(2, 600);
  cout << "\n\nStack after updating Item(2) to 600 : \n";
  MyStackArray.Display();

  MyStackArray.InsertAfter(2, 800);
  cout << "\n\nStack after Inserting 800 after Item(2) : \n";
  MyStackArray.Display();

  MyStackArray.InsertAtFront(1000);
  cout << "\n\nStack after Inserting 1000 at top: \n";
  MyStackArray.Display();

  MyStackArray.InsertAtBack(2000);
  cout << "\n\nStack after Inserting 2000 at bottom: \n";
  MyStackArray.Display();

  MyStackArray.Clear();
  cout << "\n\nStack after Clear(): \n";
  MyStackArray.Display();

  system("exit");
}