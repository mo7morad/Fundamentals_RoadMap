#pragma once
#include <iostream>
#include <string>
#include "../../Project4-DynamicArray/MySolution/DynamicArray.h"
using namespace std;

template <class T>
class QueueArray
{

protected:
  DynamicArray<T> _Array;

public:
  void push(const T &value)
  {
    _Array.InsertAtEnd(value);
  }

  void pop()
  { 
    _Array.DeleteAt(0);
  }

  void Display()
  {
    _Array.Display();
  }

  int Size() const
  {
    return _Array.GetSize();
  }

  bool IsEmpty() const
  {
    return _Array.IsEmpty();
  }

  T front() const
  {
    return _Array.GetItem(0);
  }

  T back() const
  {
    return _Array.GetItem(Size() - 1);
  }

  T GetItem(const int &index) const
  {
    return _Array.GetItem(index);
  }

  void Reverse()
  {
    _Array.Reverse();
  }

  void Update(const int &index, const T &NewValue)
  {
    _Array.Update(index, NewValue);
  }

  void InsertAfter(const int &index, const T &NewValue)
  {
    _Array.InsertAfter(index, NewValue);
  }

  void InsertAtFront(const T &value)
  {
    _Array.InsertAtBeginning(value);
  }

  void InsertAtBack(const T &value)
  {
    _Array.InsertAtEnd(value);
  }

  void Clear()
  {
    _Array.Clear();
  }
};
