#include <iostream>
using namespace std;

template <class T>
class DynamicArray
{
private:
  void _Enlarge(const int &newsize)
  {
    if (newsize <= _Size)
      return; // No need to enlarge if the size is already sufficient

    T *NewArray = new T[newsize];
    for (int i = 0; i < _Length; i++)
      NewArray[i] = _MyArray[i];

    delete[] _MyArray;
    _MyArray = NewArray;
    _Size = newsize;
  }

  void _Shrink(const int &newsize)
  {
    if (newsize >= _Size)
      return;

    T *NewArray = new T[newsize];
    for (int i = 0; i < newsize; i++)
      NewArray[i] = _MyArray[i];

    delete[] _MyArray;
    _MyArray = NewArray;
    _Size = newsize;
    _Length = newsize;
  }

protected:
  int _Size;
  int _Length;
  T *_MyArray;

public:
  DynamicArray(int arrsize = 0)
  {
    if (arrsize < 0)
    {
      cout << "Array size cannot be negative \n";
      return;
    }
    else
    {
      _Size = arrsize;
      _Length = 0;
      _MyArray = new T[arrsize];
    }
  }

  ~DynamicArray()
  {
    delete[] _MyArray;
  }

  void Fill()
  {
    int no_of_items;
    cout << "How many items you want to fill ? \n";
    cin >> no_of_items;
    if (no_of_items > _Size)
    {
      cout << "You cannot exceed the array size \n";
      return;
    }
    else
    {
      for (int i = 0; i < no_of_items; i++)
      {
        cout << "Enter item number " << i+1 << endl;
        cin >> _MyArray[i];
        _Length++;
      }
    }
  }

  void Display()
  {
    for (int i = 0; i < _Length; i++)
    {
      cout << _MyArray[i] << "\n";
    }
    cout << endl;
  }

  int GetSize()
  {
    return _Size;
  }

  int GetLength()
  {
    return _Length;
  }

  int Search(const T &value) const
  {
    for (int i = 0; i < _Length; i++)
    {
      if (_MyArray[i] == value)
      {
        return i;
      }
    }
    return -1;
  }

  int GetItem(const T &index) const
  {
    if (index >= 0 && index < _Length)
    {
      return _MyArray[index];
    }
    else
    {
      cout << "Index out of Range \n";
      return -1;
    }
  }

  void Append(const T &value)
  {
    if (_Length < _Size)
    {
      _MyArray[_Length] = value;
      _Length++;
    }
    else
      cout << "Array is full \n";
  }

void InsertAt(const int &index, const T &value)
  {
    if (index >= 0 && index < _Size && _Length < _Size)
    {
      for (int i = _Length; i > index; i--)
      {
        _MyArray[i] = _MyArray[i - 1];
      }
      _MyArray[index] = value;
      _Length++;
    }
    else
    {
      cout << " Error - Index out of Range \n";
    }
  }

  void InsertAtBeginning(const T &value)
  {
    InsertAt(0, value);
  }

  void InsertBefore(const T &index, const T &value)
  {
    int index = Search(index);
    if (index != -1)
    {
      InsertAt(index, value);
    }
    else
      cout << "Value not found \n";
  }

  void InsertAfter(const T &index, const T &value)
  {
    int index = Search(index);
    if (index != -1)
    {
      InsertAt(index + 1, value);
    }
    else
      cout << "Value not found \n";
  }

  void InsertAtEnd(const T &value)
  {
    InsertAt(_Length, value);
  }

  void DeleteAt(const int &index)
  {
    if (index >= 0 && index < _Size)
    {
      for (int i = index; i < _Length - 1; i++)
        _MyArray[i] = _MyArray[i + 1];
      _Length--;
    }
    else
      cout << "Index out of Array Range \n";
  }

  void DeleteByValue(const T &value)
  {
    int index = Search(value);
    if (index != -1)
    {
      DeleteAt(index);
    }
    else
      cout << "Value not found \n";
  }

  void Update(int index, int value)
  {
    if (index >= 0 && index < _Size)
    {
      _MyArray[index] = value;
    }
    else
      cout << "Index out of Array Range \n";
  }

  void Resize(const int &newsize)
  {
    if (newsize < 0)
    {
      cout << "Array size cannot be negative \n";
      return;
    }
    else if (newsize > _Size)
    {
      _Enlarge(newsize);
    }
    else if (newsize < _Size)
    {
      _Shrink(newsize);
    }
  }

  void Reverse()
  {
    // My solution
    /*
    int OldLength = _Length;

    T *NewArray = new T[_Size];
    for (int i = 0; i < OldLength; i++)
    {
      NewArray[i] = _MyArray[_Length - 1];
      _Length--;
    }
    delete[] _MyArray;
    _MyArray = NewArray;
    _Length = OldLength;
    */

    // Another solution
    int FirstOfArray = 0;
    int EndOfArray = _Length - 1;
    while (FirstOfArray < EndOfArray) // Swap the elements
    {
      T temp = _MyArray[FirstOfArray];               // temp = first element in the array that keeps changing
      _MyArray[FirstOfArray] = _MyArray[EndOfArray]; //  swap -->first element in the array = last element in the array
      _MyArray[EndOfArray] = temp;                   // last element in the array = temp 
      FirstOfArray++;
      EndOfArray--;
    }
  }

  void Clear()
  {
    delete[] _MyArray;
    _MyArray = nullptr; // Avoid dangling pointer
    _Length = 0;
    _Size = 0;
  }

  // void Merge(Array other)
  // {
  //   int newsize = size + other.getSize();
  //   size = newsize;
  //   int *old = items;
  //   items = new int[newsize];
  //   int i;
  //   for (i = 0; i < length; i++)
  //   {
  //     items[i] = old[i];
  //   }
  //   delete[] old;
  //   int j = i;
  //   for (int i = 0; i < other.getLength(); i++)
  //   {
  //     items[j++] = other.items[i];
  //     length++;
  //   }
  // }
};
