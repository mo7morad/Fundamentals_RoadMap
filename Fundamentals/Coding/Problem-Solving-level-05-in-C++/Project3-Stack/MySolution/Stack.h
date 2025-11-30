#include <iostream>
#include <string>
#include "../../Project2-Queue/MySolution/Queue.h"
using namespace std;

template <class T>
class Stack : public Queue<T>
{
public:
  void push(const T &value)
  {
    Queue<T>::list.InsertFirst(value);
  }

  T Top() const
  {
    return Queue<T>::front();
  }

  T Bottom() const
  {
    return Queue<T>::back();
  }
};