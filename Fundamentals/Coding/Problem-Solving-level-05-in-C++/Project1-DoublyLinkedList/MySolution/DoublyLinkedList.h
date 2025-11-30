#include <iostream>
#include <string>
using namespace std;

template <class T>
class Node
{
public:
  T value;
  Node *prev;
  Node *next;
  Node(const T &val) : value(val), prev(nullptr), next(nullptr) {}
};

template <class T>
class DoublyLinkedList
{
private:
  Node<T> *HEAD = nullptr;
  Node<T> *REAR = nullptr;
  int SizeOfList = 0;

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

  void _InsertAtUsingHEAD(int index, const T &value)
  {
    Node<T> *NewNode = new Node<T>(value);
    Node<T> *current = HEAD;
    for (int i = 1; i < index; i++)
    {
      current = current->next;
    }
    NewNode->next = current->next;
    NewNode->prev = current;
    if (current->next != nullptr)
    {
      current->next->prev = NewNode;
    }
    current->next = NewNode;
    SizeOfList++;
  }

  void _InsertAtUsingREAR(int indexFromEnd, const T &value)
  {
    Node<T> *NewNode = new Node<T>(value);
    Node<T> *current = REAR;
    for (int i = 1; i < indexFromEnd; i++)
    {
      current = current->prev;
    }
    NewNode->prev = current->prev;
    NewNode->next = current;
    if (current->prev != nullptr)
    {
      current->prev->next = NewNode;
    }
    current->prev = NewNode;
    SizeOfList++;
  }

public:
  ~DoublyLinkedList()
  {
    _DeleteAllNodes();
  }

  bool IsEmpty() const
  {
    return SizeOfList == 0;
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
    return SizeOfList;
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

  void Find(const T &value) const
  {
    Node<T> *current = HEAD;
    int index = 0;
    while (current != nullptr)
    {
      if (current->value == value)
      {
        cout << "Value found at index " << index << ".\n";
        return;
      }
      current = current->next;
      index++;
    }
    cout << "Error: Value not found.\n";
  }

  T GetItem(const T &index) const
  {
    Node<T> *current = GetNode(index);
    return current ? current->value : T();
  }

  Node<T> *GetNode(const T &index) const
  {
    if (index < 0 || index >= Size())
    {
      cout << "Error: Index out of bounds. Valid range is [0, " << Size() - 1 << "].\n";
      return nullptr;
    }

    Node<T> *current = nullptr;
    if (index < Size() / 2)
    {
      // Traverse from HEAD
      current = HEAD;
      for (int i = 0; i < index; i++)
      {
        current = current->next;
      }
    }
    else
    {
      // Traverse from REAR
      current = REAR;
      for (int i = Size() - 1; i > index; i--)
      {
        current = current->prev;
      }
    }
    return current;
  }

  void InsertFirst(const T &value)
  {
    Node<T> *NewNode = new Node<T>(value);
    if (IsEmpty())
    {
      HEAD = REAR = NewNode;
    }
    else
    {
      NewNode->next = HEAD;
      HEAD->prev = NewNode;
      HEAD = NewNode;
    }
    SizeOfList++;
  }

  void InsertLast(const T &value)
  {
    Node<T> *NewNode = new Node<T>(value);
    if (IsEmpty())
    {
      HEAD = REAR = NewNode;
    }
    else
    {
      REAR->next = NewNode;
      NewNode->prev = REAR;
      REAR = NewNode;
    }
    SizeOfList++;
  }

  void InsertAt(int index, const T &value)
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
    if (index < Size() / 2)
    {
      _InsertAtUsingHEAD(index, value);
    }
    else
    {
      _InsertAtUsingREAR(Size() - index, value);
    }
  }

  void InsertAfter(const T &index, const T &value)
  {
    InsertAt(index + 1, value);
  }

  bool UpdateItem(const T &index, const T &value)
  {
    Node<T> *current = GetNode(index);
    if (current)
    {
      current->value = value;
      return true;
    }
    return false;
  }

  void DeleteFirstNode()
  {
    if (IsEmpty())
    {
      cout << "Error: List is empty.\n";
      return;
    }

    Node<T> *Delptr = HEAD;
    HEAD = HEAD->next;
    HEAD ? HEAD->prev = nullptr : REAR = nullptr;
    delete Delptr;
    --SizeOfList;
  }

  void DeleteLastNode()
  {
    if (IsEmpty())
    {
      cout << "Error: List is empty.\n";
      return;
    }

    Node<T> *Delptr = REAR;
    REAR = REAR->prev;
    REAR ? REAR->next = nullptr : HEAD = nullptr;
    delete Delptr;
    --SizeOfList;
  }

  void Delete(const T &val)
  {
    if (IsEmpty())
    {
      cout << "Error: List is empty.\n";
      return;
    }

    if (HEAD->value == val)
    {
      DeleteFirstNode();
      return;
    }

    if (REAR->value == val)
    {
      DeleteLastNode();
      return;
    }

    Node<T> *current = HEAD;
    while (current != nullptr)
    {
      if (current->value == val)
      {
        current->prev->next = current->next;
        current->next->prev = current->prev;
        delete current;
        --SizeOfList;
        return;
      }
      current = current->next;
    }
  }

  void Clear()
  {
    _DeleteAllNodes();
    SizeOfList = 0;
  }

  void Reverse()
  {
    Node<T> *current = HEAD;
    Node<T> *temp = nullptr;

    // Swap HEAD and REAR
    HEAD = REAR;
    REAR = current;

    // Traverse and reverse pointers using swap function
    while (current != nullptr)
    {
      temp = current;                    // Save the current node
      current = current->next;           // Move to the next node
      swap(temp->prev, temp->next); // Swap prev and next pointers
    }

    /*OR
    Traverse and reverse pointers manually
    while (current != nullptr)
    {
      temp = current->prev;          // Save the previous node
      current->prev = current->next; // Swap prev and next
      current->next = temp;          // Update next to the saved previous
      current = current->prev;       // Move to the next node (original next)
    }
    */
  }
};