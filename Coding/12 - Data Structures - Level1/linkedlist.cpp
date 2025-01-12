#include <iostream>
using namespace std;

class Node
{
public:
  int value;
  Node* next;
};

class LinkedList
{
Node* HEAD = NULL;

public:
  ~LinkedList()
  {
    Node *current = HEAD;
    Node *next;
    while (current != NULL)
    {
      next = current->next;
      delete current;
      current = next;
    }
    HEAD = NULL;
  }

  bool IsEmpty()
  {
    return HEAD == NULL;
  }

  void Display()
  {
    Node* Iterator = HEAD;
    while(Iterator != NULL)
    {
      cout << Iterator->value << "  ";
      Iterator = Iterator->next;
    }
    cout << endl;
  }

  int Count()
  {
    Node* Iterator = HEAD;
    int Counter = 0;

    while(Iterator != NULL)
    {
      Counter++;
      Iterator = Iterator->next;
    }
    return Counter;
  }

  bool IsExists(int value)
  {
    Node *Iterator = HEAD;
    while (Iterator != NULL)
    {
      if (Iterator->value == value)
        return true;
      Iterator = Iterator->next;
    }
    return false;
  }

  void InsertFirst(int value)
  {
    Node* NewNode = new Node;
    NewNode->value = value;

    if (IsEmpty())
    {
      NewNode->next = NULL;
      HEAD = NewNode;
    }
    else
    {
      NewNode->next = HEAD;
      HEAD = NewNode;
    }
  }

  void InsertLast(int value)
  {
    Node* NewNode = new Node;
    NewNode->value = value;
    NewNode->next = NULL;

    if(IsEmpty())
    {
      HEAD = NewNode;
    }
    else
    {
      Node* Iterator = HEAD;
      while (Iterator->next != NULL)
      {
        Iterator = Iterator->next;
      }
      Iterator->next = NewNode;
    }
  }
};

int main()
{
  LinkedList list;

  // Insert elements at the beginning
  list.InsertFirst(10);
  list.InsertFirst(20);
  list.InsertFirst(30);

  // Insert elements at the end
  list.InsertLast(40);
  list.InsertLast(50);

  // Display elements
  cout << "Linked List: ";
  list.Display();

  // Count elements
  cout << "Count: " << list.Count() << endl;

  // Check if an element exists
  cout << "Is 20 in the list? " << (list.IsExists(20) ? "Yes" : "No") << endl;
  cout << "Is 60 in the list? " << (list.IsExists(60) ? "Yes" : "No") << endl;

  return 0;
}