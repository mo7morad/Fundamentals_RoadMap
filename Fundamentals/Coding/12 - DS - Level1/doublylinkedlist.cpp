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
  // Constructor to initialize pointers to nullptr.
  Node(const T &val) : value(val), prev(nullptr), next(nullptr) {}
};

template <class T>
class DoublyLinkedList
{
private:
  Node<T> *HEAD = nullptr;
  Node<T> *REAR = nullptr;
  int SizeOfList = 0;

  void _InsertAtUsingHEAD(int index, const T &value)
  {
    Node<T> *NewNode = new Node<T>(value);
    Node<T> *current = HEAD;
    for (int i = 1; i < index; i++)
    {
      current = current->next;
    }
    // Insert NewNode after 'current'
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
    // Insert NewNode before 'current'
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
    Node<T> *current = HEAD;
    while (current != nullptr)
    {
      Node<T> *temp = current;
      current = current->next;
      delete temp;
    }
  }

  bool IsEmpty() const
  {
    return HEAD == nullptr;
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

  void InsertFirst(const T &value)
  {
    Node<T> *NewNode = new Node<T>(value);
    NewNode->prev = nullptr;
    // If the list is empty, HEAD and REAR becomes the NewNode.
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
    // If the list is empty, HEAD and REAR becomes the NewNode.
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
    // Choose direction of traversal for efficiency.
    if (index < Size() / 2)
    {
      _InsertAtUsingHEAD(index, value);
    }
    else
    {
      _InsertAtUsingREAR(Size() - index, value);
    }
  }

  void Delete(const T &val)
  {
    if (IsEmpty()) // Check if the list is empty
    {
      cout << "Error: List is empty.\n";
      return;
    }

    // Case 1: Deleting the head node
    if (HEAD->value == val)
    {
      Node<T> *Delptr = HEAD;
      HEAD = HEAD->next;
      HEAD ? HEAD->prev = nullptr : REAR = nullptr;
      delete Delptr;
      --SizeOfList;
      return;
    }

    // Search for the node
    Node<T> *Delptr = HEAD;
    while (Delptr && Delptr->value != val)
      Delptr = Delptr->next;

    // Case 2: Value not found
    if (!Delptr)
    {
      cout << "Error: Value not found.\n";
      return;
    }

    // Case 3: Deleting a middle or rear node
    if (Delptr->prev)
      Delptr->prev->next = Delptr->next;
    if (Delptr->next)
      Delptr->next->prev = Delptr->prev;
    else
      REAR = Delptr->prev; // Update REAR if the last node is deleted

    delete Delptr;
    --SizeOfList;
  }
};

int main()
{
  DoublyLinkedList<int> list;

  // Test InsertFirst
  list.InsertFirst(10);
  list.InsertFirst(20);
  list.InsertFirst(30);
  cout << "List after InsertFirst operations: ";
  list.Display(); // Expected output: 30 20 10

  // Test InsertLast
  list.InsertLast(40);
  list.InsertLast(50);
  cout << "List after InsertLast operations: ";
  list.Display(); // Expected output: 30 20 10 40 50

  // Test InsertAt
  list.InsertAt(2, 25);
  cout << "List after InsertAt(2, 25): ";
  list.Display(); // Expected output: 30 20 25 10 40 50

  // Test IsExists
  cout << "IsExists(25): " << (list.IsExists(25) ? "true" : "false") << endl;   // Expected output: true
  cout << "IsExists(100): " << (list.IsExists(100) ? "true" : "false") << endl; // Expected output: false

  // Test IndexOf
  cout << "IndexOf(25): " << list.IndexOf(25) << endl;   // Expected output: 2
  cout << "IndexOf(100): " << list.IndexOf(100) << endl; // Expected output: Error: Value not found. -1

  // Test Delete
  list.Delete(25);
  cout << "List after Delete(25): ";
  list.Display(); // Expected output: 30 20 10 40 50

  // Test Size
  cout << "Size of the list: " << list.Size() << endl; // Expected output: 5

  // Test IsEmpty
  cout << "IsEmpty: " << (list.IsEmpty() ? "true" : "false") << endl; // Expected output: false

  return 0;
}
