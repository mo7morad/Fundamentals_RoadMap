#pragma once
#include <iostream>
#include "../Project1-DoublyLinkedList/clsDblLinkedList.h"
using namespace std;

template <class T>
class clsMyQueue
{

protected:
  clsDblLinkedList<T> _MyList;

public:
  void push(T Item)
  {
    _MyList.InsertAtEnd(Item);
  }

  void pop()
  {
    _MyList.DeleteFirstNode();
  }

  void Print()
  {
    _MyList.PrintList();
  }

  int Size()
  {
    return _MyList.Size();
  }

  bool IsEmpty()
  {
    return _MyList.IsEmpty();
  }

  T front()
  {
    return _MyList.GetItem(0);
  }

  T back()
  {
    return _MyList.GetItem(Size() - 1);
  }

  T GetItem(int Index)
  {
    return _MyList.GetItem(Index);
  }

  void Reverse()
  {

    _MyList.Reverse();
  }

  void UpdateItem(int Index, T NewValue)
  {
    _MyList.UpdateItem(Index, NewValue);
  }

  void InsertAfter(int Index, T NewValue)
  {
    _MyList.InsertAfter(Index, NewValue);
  }

  void InsertAtFront(T Value)
  {
    _MyList.InsertAtBeginning(Value);
  }

  void InsertAtBack(T Value)
  {
    _MyList.InsertAtEnd(Value);
  }

  void Clear()
  {
    _MyList.Clear();
  }
};
