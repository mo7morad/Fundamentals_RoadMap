#include <iostream>
#include <string>
using namespace std;

template <class T>
class Node
{
public:
  T value;
  Node *next;
};

template <class T>
class LinkedList
{
private:
  Node<T> *HEAD = nullptr;

public:
  ~LinkedList()
  {
    Node<T> *current = HEAD;
    Node<T> *next;
    while (current != nullptr)
    {
      next = current->next;
      delete current;
      current = next;
    }
    HEAD = nullptr;
  }

  bool IsEmpty()
  {
    return HEAD == nullptr;
  }

  void Display()
  {
    Node<T> *Iterator = HEAD;
    while (Iterator != nullptr)
    {
      cout << Iterator->value << " ";
      Iterator = Iterator->next;
    }
    cout << endl;
  }

  int Size()
  {
    Node<T> *Iterator = HEAD;
    int Counter = 0;
    while (Iterator != nullptr)
    {
      Counter++;
      Iterator = Iterator->next;
    }
    return Counter;
  }

  bool IsExists(T value)
  {
    Node<T> *Iterator = HEAD;
    while (Iterator != nullptr)
    {
      if (Iterator->value == value)
        return true;
      Iterator = Iterator->next;
    }
    return false;
  }

  void InsertFirst(T value)
  {
    Node<T> *NewNode = new Node<T>;
    NewNode->value = value;
    NewNode->next = HEAD;
    HEAD = NewNode;
  }

  void InsertLast(T value)
  {
    Node<T> *NewNode = new Node<T>;
    NewNode->value = value;
    NewNode->next = nullptr;

    if (IsEmpty())
    {
      HEAD = NewNode;
    }
    else
    {
      Node<T> *Iterator = HEAD;
      while (Iterator->next != nullptr)
      {
        Iterator = Iterator->next;
      }
      Iterator->next = NewNode;
    }
  }

  void InsertAt(int index, T value)
  {
    if (index < 0 || index > Size())
    {
      cout << "Error: Index out of bounds. Valid range is [0, " << Size() << "].\n";
      return;
    }

    if (index == 0)
    {
      InsertFirst(value);
      return;
    }
    if (index == Size())
    {
      InsertLast(value);
      return;
    }

    Node<T> *NewNode = new Node<T>;
    NewNode->value = value;

    Node<T> *Iterator = HEAD;
    for (int i = 1; i < index; i++)
    {
      Iterator = Iterator->next;
    }

    NewNode->next = Iterator->next;
    Iterator->next = NewNode;
  }
};

int main()
{
  LinkedList<int> list;

  // Insert elements at the beginning
  list.InsertFirst(10);
  list.InsertFirst(20);
  list.InsertFirst(30);

  // Insert elements at the end
  list.InsertLast(40);
  list.InsertLast(50);
  list.InsertAt(3, 99);

  // Display elements
  cout << "Linked List: ";
  list.Display();

  // Count elements
  cout << "Size: " << list.Size() << endl;

  // Check if an element exists
  cout << "Is 20 in the list? " << (list.IsExists(20) ? "Yes" : "No") << endl;
  cout << "Is 60 in the list? " << (list.IsExists(60) ? "Yes" : "No") << endl;

  LinkedList<string> strList;

  // Insert elements at the beginning
  strList.InsertFirst("apple");
  strList.InsertFirst("banana");
  strList.InsertFirst("cherry");

  // Insert elements at the end
  strList.InsertLast("date");
  strList.InsertLast("elderberry");
  strList.InsertAt(3, "fig");

  // Display elements
  cout << "String Linked List: ";
  strList.Display();

  // Count elements
  cout << "Size: " << strList.Size() << endl;

  // Check if an element exists
  cout << "Is 'banana' in the list? " << (strList.IsExists("banana") ? "Yes" : "No") << endl;
  cout << "Is 'grape' in the list? " << (strList.IsExists("grape") ? "Yes" : "No") << endl;

  return 0;
}
