#include <iostream>
#include "Stack.h"
using namespace std;

// this is for testing all the Stack.h methods.
int main()
{
  Stack<int> MyStack;
  MyStack.push(10);
  MyStack.push(20);
  MyStack.push(30);
  MyStack.push(40);
  MyStack.push(50);

  cout << "\nStack: \n";
  MyStack.Display();

  cout << "\nStack Size: " << MyStack.Size();
  cout << "\nStack Top: " << MyStack.Top();
  cout << "\nStack Bottom: " << MyStack.Bottom();

  MyStack.pop();

  cout << "\n\nStack after pop() : \n";
  MyStack.Display();

  // Extension #1
  cout << "\n\nItem(2) : " << MyStack.GetItem(2);

  // Extension #2
  MyStack.Reverse();
  cout << "\n\nStack after reverse() : \n";
  MyStack.Display();

  // Extension #3
  MyStack.UpdateItem(2, 600);
  cout << "\n\nStack after updating Item(2) to 600 : \n";
  MyStack.Display();

  // Extension #4
  MyStack.InsertAfter(2, 800);
  cout << "\n\nStack after Inserting 800 after Item(2) : \n";
  MyStack.Display();

  // Extension #5
  MyStack.Clear();
  cout << "\n\nStack after Clear(): \n";

  return 0;
}