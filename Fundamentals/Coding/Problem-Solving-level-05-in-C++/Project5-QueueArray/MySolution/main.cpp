#include <iostream>
#include "QueueArray.h"

using namespace std;

int main()
{

  QueueArray<int> MyQueueArray;

  MyQueueArray.push(10);
  MyQueueArray.push(20);
  MyQueueArray.push(30);
  MyQueueArray.push(40);
  MyQueueArray.push(50);

  cout << "\nQueue: \n";
  MyQueueArray.Display();

  cout << "\nQueue Size: " << MyQueueArray.Size();
  cout << "\nQueue Front: " << MyQueueArray.front();
  cout << "\nQueue Back: " << MyQueueArray.back();

  MyQueueArray.pop();

  cout << "\n\nQueue after pop() : \n";
  MyQueueArray.Display();

  cout << "\n\n Item(2) : " << MyQueueArray.GetItem(2);

  MyQueueArray.Reverse();
  cout << "\n\nQueue after reverse() : \n";
  MyQueueArray.Display();

  MyQueueArray.Update(2, 600);
  cout << "\n\nQueue after updating Item(2) to 600 : \n";
  MyQueueArray.Display();

  MyQueueArray.InsertAfter(2, 800);
  cout << "\n\nQueue after Inserting 800 after Item(2) : \n";
  MyQueueArray.Display();

  MyQueueArray.InsertAtFront(1000);
  cout << "\n\nQueue after Inserting 1000 at front: \n";
  MyQueueArray.Display();

  MyQueueArray.InsertAtBack(2000);
  cout << "\n\nQueue after Inserting 2000 at back: \n";
  MyQueueArray.Display();

  MyQueueArray.Clear();
  cout << "\n\nQueue after Clear(): \n";
  MyQueueArray.Display();

  system("exit");
}