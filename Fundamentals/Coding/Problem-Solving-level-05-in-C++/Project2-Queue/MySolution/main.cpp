#include <iostream>
#include <string>
#include "Queue.h"
using namespace std;


int main()
{
  // Testing MyQueue class
  Queue<int> q;
  cout << "Is queue empty? " << boolalpha << q.IsEmpty() << endl;

  // Adding Items
  cout << "Adding items...\n";
  q.push(10);
  q.push(20);
  q.push(30);
  q.push(40);
  q.push(50);
  q.Display();

  // Removing Items
  q.pop();
  q.pop();
  q.Display();

  // Front and Back
  cout << "Front: " << q.front() << endl;
  cout << "Back: " << q.back() << endl;

  // Clearing the queue
}