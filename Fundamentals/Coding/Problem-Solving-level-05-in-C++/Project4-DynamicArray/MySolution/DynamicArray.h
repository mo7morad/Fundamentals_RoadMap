#include <iostream>
using namespace std;

template <class T>
class DynamicArray
{
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

  void Delete(int index)
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

  void Update(int index, int value)
  {
    if (index >= 0 && index < _Size)
    {
      _MyArray[index] = value;
    }
    else
      cout << "Index out of Array Range \n";
  }

  // void Enlarge(int newsize)
  // {
  //   if (newsize <= _Size)
  //   {
  //     cout << "New size must be larger than current size \n";
  //     return;
  //   }
  //   else
  //   {
  //     _Size = newsize;
  //     int *old = items;
  //     items = new int[newsize];
  //     for (int i = 0; i < length; i++)
  //     {
  //       items[i] = old[i];
  //     }
  //     delete[] old;
  //   }
  // }
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
