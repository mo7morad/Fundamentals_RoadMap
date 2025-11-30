#include <iostream>
#include <string>
#include "../../Project1-DoublyLinkedList/MySolution/DoublyLinkedList.h"
using namespace std;

template <class T>
class Queue
{

protected:
  DoublyLinkedList<T> list;

public:
  bool IsEmpty() const
  {
    return list.IsEmpty();
  }

  void Display() const
  {
    list.Display();
  }

  int Size() const
  {
    return list.Size();
  }

  bool IsExists(const T &value) const
  {
    return list.IsExists(value);
  }

  int IndexOf(const T &value) const
  {
    return list.IndexOf(value);
  }

  int GetItem(const int &index) const
  {
    return list.GetItem(index);
  }

  T front() const
  {
    return list.GetItem(0);
  }

  T back() const
  {
    return list.GetItem(list.Size() - 1);
  }

  void push(const T &value)
  {
    list.InsertLast(value);
  }

  void pop()
  {
    if (IsEmpty())
    {
      cout << "Error: Queue is empty.\n";
      return;
    }
    list.DeleteFirstNode();
  }

  void InsertAfter(const int &index, const T &value)
  {
    list.InsertAfter(index, value);
  }

  void UpdateItem(const int &index, const T &value)
  {
    list.UpdateItem(index, value);
  }

  void Reverse()
  {
    list.Reverse();
  }

  void Clear()
  {
    list.Clear();
  }
};
// I was using this way before, but I found it more convenient to use DoublyLinkedList class.

/* private:
  Node<T> *HEAD = nullptr;
  Node<T> *REAR = nullptr;
  int _Size = 0;

  void _DeleteAllNodes()
  {
    Node<T> *current = HEAD;
    while (current != nullptr)
    {
      Node<T> *temp = current;
      current = current->next;
      delete temp;
    }
    HEAD = REAR = nullptr;
  }

public:
  ~Queue()
  {
    _DeleteAllNodes();
  }

  bool IsEmpty() const
  {
    return _Size == 0;
  }

  void Display() const
  {
    Node<T> *current = HEAD;
    while (current != nullptr)
    {
      cout << current->value << " ";
      current = current->next;
    }
    cout << endl;
  }

  int Size() const
  {
    return _Size;
  }

  bool IsExists(const T &value) const
  {
    Node<T> *current = HEAD;
    while (current != nullptr)
    {
      if (current->value == value)
        return true;
      current = current->next;
    }
    return false;
  }

  int IndexOf(const T &value) const
  {
    int index = 0;
    Node<T> *current = HEAD;
    while (current != nullptr)
    {
      if (current->value == value)
        return index;
      current = current->next;
      index++;
    }
    cout << "Error: Value not found.\n";
    return -1;
  }

  void push(T value)
  {
    Node<T> *NewNode = new Node<T>(value);
    if (IsEmpty())
    {
      HEAD = REAR = NewNode;
    }
    else
    {
      REAR->next = NewNode;
      REAR = NewNode;
    }
    _Size++;
  }

  void pop()
  {
    if (IsEmpty())
    {
      cout << "Error: Queue is empty.\n";
      return;
    }

    Node<T> *Delptr = HEAD;
    HEAD = HEAD->next;
    delete Delptr;
    _Size--;
  }

  T front() const
  {
    if (IsEmpty())
    {
      cout << "Error: Queue is empty.\n";
      return T();
    }
    return HEAD->value;
  }

  T back() const
  {
    if (IsEmpty())
    {
      cout << "Error: Queue is empty.\n";
      return T();
    }
    return REAR->value;
  }
*/


