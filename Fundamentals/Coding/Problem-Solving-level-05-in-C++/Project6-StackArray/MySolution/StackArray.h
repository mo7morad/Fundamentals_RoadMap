#pragma once
#include <iostream>
#include "../../Project5-QueueArray/MySolution/QueueArray.h"
using namespace std;

template <class T>
class StackArray : public QueueArray<T>
{
public:
  void push(const T &value)
  {
    QueueArray<T>::InsertAtFront(value);
  }

  T Top() const
  {
    return QueueArray<T>::front();
  }

  T Bottom() const
  {
    return QueueArray<T>::back();
  }
};