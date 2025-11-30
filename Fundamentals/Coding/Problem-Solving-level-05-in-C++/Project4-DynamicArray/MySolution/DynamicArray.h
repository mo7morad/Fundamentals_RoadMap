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

  // Copy Constructor (Deep Copy)
  DynamicArray(const DynamicArray& other)
  {
    _Size = other._Size;
    _Length = other._Length;
    _MyArray = new T[_Size]; // Allocate new memory
    for (int i = 0; i < _Length; i++)
    {
      _MyArray[i] = other._MyArray[i]; // Copy elements
    }
  }

  // Copy Assignment Operator (Deep Copy)
  DynamicArray& operator=(const DynamicArray& other)
  {
    if (this != &other) // Prevent self-assignment
    {
      delete[] _MyArray; // Free old memory
      _Size = other._Size;
      _Length = other._Length;
      _MyArray = new T[_Size]; // Allocate new memory
      for (int i = 0; i < _Length; i++)
      {
        _MyArray[i] = other._MyArray[i]; // Copy elements
      }
    }
    return *this;
  }

  ~DynamicArray()
  {
    delete[] _MyArray;
  }

  void Display()
  {
    for (int i = 0; i < _Length; i++)
    {
      cout << _MyArray[i] << "\n";
    }
    cout << endl;
  }

  int GetSize() const
  {
    return _Size;
  }

  int GetLength() const
  {
    return _Length;
  }

  bool IsEmpty() const
  {
    return _Length == 0;
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

  int GetIndex(const T &index) const
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
  
  T GetItem(const int &index) const
  {
    if (index >= 0 && index < _Length)
    {
      return _MyArray[index];
    }
    else
    {
      cout << "Index out of Range \n";
      return T();
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
    {
      _Enlarge(_Size + 1);
      _MyArray[_Length] = value;
      _Length++;
    }
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
      _Enlarge(_Size + 1);
      for (int i = _Length; i > index; i--)
      {
        _MyArray[i] = _MyArray[i - 1];
      }
      _MyArray[index] = value;
      _Length++;
    }
  }

  void InsertAtBeginning(const T &value)
  {
    InsertAt(0, value);
  }

  void InsertBefore(const T &index, const T &value)
  {
    InsertAt(index - 1, value);
  }

  void InsertAfter(const T &index, const T &value)
  {
    InsertAt(index + 1, value);
  }

  void InsertAtEnd(const T &value)
  {
    Append(value);
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

  void Update(const int &index, const T &value)
  {
    if (index >= 0 && index < _Size)
    {
      _MyArray[index] = value;
    }
    else
      cout << "Index out of Array Range \n";
  }

  void Merge(const DynamicArray &Arr)
  {
    int NewSize = _Size + Arr.GetSize();
    if (_Size < NewSize)
      _Enlarge(NewSize);

    // Append elements from the input array (Arr) to the current array
    for (int i = 0; i < Arr.GetLength(); i++)
    {
      Append(Arr.GetItem(i));
    }
  }

  static DynamicArray Merge(const DynamicArray &Arr1, const DynamicArray &Arr2)
  {
    DynamicArray merged = Arr1;

    int NewSize = merged.GetSize() + Arr2.GetSize();
    if (merged.GetSize() < NewSize)
      merged._Enlarge(NewSize);

    for (int i = 0; i < Arr2.GetLength(); i++)
    {
      merged.Append(Arr2.GetItem(i));
    }
    return merged;
  }

  // Another Merge Way that I like
  /*
  void Merge(DynamicArray &Arr)
  {
    // Create a new DynamicArray object to hold the merged result
    DynamicArray<T> MergedArray(_Size + Arr.GetSize());

    // Append elements from the current array
    for (int i = 0; i < _Length; i++)
    {
      MergedArray.Append(_MyArray[i]);
    }

    // Append elements from the input array (Arr)
    for (int i = 0; i < Arr.GetLength(); i++)
    {
      MergedArray.Append(Arr[i]);
    }

    // Delete the old array
    delete[] _MyArray;

    _MyArray = MergedArray;   // Assign the pointer
    _Size = MergedArray.GetSize();     // Update size
    _Length = MergedArray.GetLength(); // Update length

    MergedArray.Clear();
  }
  */

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
};
