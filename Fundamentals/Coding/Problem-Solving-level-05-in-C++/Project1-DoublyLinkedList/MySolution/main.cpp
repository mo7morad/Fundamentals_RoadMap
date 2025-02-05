#include <iostream>
#include "DoublyLinkedList.h"

int main()
{
  DoublyLinkedList<int> list;

  // Test InsertFirst
  cout << "Insert First tests: \n";
  list.InsertFirst(10);
  list.InsertFirst(20);
  list.InsertFirst(30);
  cout << "List after InsertFirst operations: ";
  list.Display(); // Expected output: 30 20 10
  cout << "============================================\n";

  // Test InsertLast
  cout << "Insert Last tests: \n";
  list.InsertLast(40);
  list.InsertLast(50);
  cout << "List after InsertLast operations: ";
  list.Display(); // Expected output: 30 20 10 40 50
  cout << "============================================\n";

  // Test InsertAt
  cout << "Insert At tests: \n";
  list.InsertAt(2, 25);
  cout << "List after InsertAt(2, 25): ";
  list.Display(); // Expected output: 30 20 25 10 40 50
  cout << "============================================\n";

  // Test IsExists
  cout << "IsExsits tests: \n";
  cout << "IsExists(25): " << (list.IsExists(25) ? "true" : "false") << endl;   // Expected output: true
  cout << "IsExists(100): " << (list.IsExists(100) ? "true" : "false") << endl; // Expected output: false
  cout << "============================================\n";

  // Test IndexOf
  cout << "IndexOf tests: \n";
  cout << "IndexOf(25): " << list.IndexOf(25) << endl;   // Expected output: 2
  cout << "IndexOf(100): " << list.IndexOf(100) << endl; // Expected output: Error: Value not found. -1
  cout << "============================================\n";

  // Test GetNode
  cout << "GetNode tests: \n";
  Node<int> *node = list.GetNode(25);
  if (node)
    cout << "GetNode(25): " << node->value << endl; // Expected output: 25

  node = list.GetNode(100);
  if (node)
    cout << "GetNode(100): " << node->value << endl; // Expected output: Error: Index out of bounds. Valid range is [0, 5]. -1
  
  cout << "============================================\n";

  // Test GetItem
  cout << "GetItem tests: \n";
  cout << "GetItem of index(2): " << list.GetItem(2) << endl;   // Expected output: 25
  cout << "GetItem of index(100): " << list.GetItem(100) << endl; // Expected output: Error: Index out of bounds. Valid range is [0, 5]. 0
  cout << "============================================\n";

  // Test UpdateItem
  cout << "UpdateItem tests: \n";
  list.UpdateItem(2, 35);
  cout << "List after UpdateItem(2, 35): ";
  list.Display(); // Expected output: 30 20 35 10 40 50
  cout << "============================================\n";

  // Test Delete
  cout << "Delete tests: \n";
  list.Delete(25);
  cout << "List after Delete(25): ";
  list.Display(); // Expected output: 30 20 10 40 50
  cout << "============================================\n";

  // Test Size
  cout << "Size tests: \n";
  cout << "Size of the list: " << list.Size() << endl; // Expected output: 5
  cout << "============================================\n";

  // Test IsEmpty
  cout << "IsEmpty Before Clear: " << (list.IsEmpty() ? "true" : "false") << endl; // Expected output: false
  cout << "============================================\n";

  // Test Reverse
  cout << "Reverse tests: \n";

  cout << "List before Reverse: ";
  list.Display(); // Expected output: 30 20 10 40 50
  
  cout << "List after Reverse: ";
  list.Reverse();
  list.Display(); // Expected output: 50 40 10 20 30
  cout << "============================================\n";

  // Test Clear
  cout << "Clear tests: \n";
  list.Clear();
  cout << "List size after Clear: " << list.Size() << endl; // Expected output: 0
  cout << "IsEmpty after Clear: " << (list.IsEmpty() ? "true" : "false") << endl; // Expected output: true
  cout << "============================================\n";

  return 0;
}
