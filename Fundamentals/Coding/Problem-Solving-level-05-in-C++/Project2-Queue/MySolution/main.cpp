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
  cout << "Removing 2 items...\n";
  q.pop();
  q.pop();
  q.Display();

  // Front and Back
  cout << "Front: " << q.front() << endl;
  cout << "Back: " << q.back() << endl;

  // Getting Item at index
  cout << "Item at index 2: " << q.GetItem(2) << endl;

  // Checking if item exists
  cout << "Is 30 exists? " << boolalpha << q.IsExists(30) << endl;

  // Reverse the queue
  cout << "Reversing the queue...\n";
  q.Reverse();
  q.Display();

  // Updating item
  cout << "Updating item at index 2...\n";
  q.UpdateItem(2, 100);
  q.Display();

  // Clearing the queue
  cout << "Clearing the queue...\n";
  q.Clear();
  q.Display();

  cout << "Is queue empty? " << boolalpha << q.IsEmpty() << endl;
}