#include <iostream>
using namespace std;
class Array
{
private:
  int size;
  int length;
  int *items;

public:
  Array(int arrsize)
  {
    size = arrsize;
    length = 0;
    items = new int[arrsize];
  }
  void Fill()
  {
    int no_of_items;
    cout << "How many items you want to fill ? \n";
    cin >> no_of_items;
    if (no_of_items > size)
    {
      cout << "You cannot exceed the array size \n";
      return;
    }
    else
    {
      for (int i = 0; i < no_of_items; i++)
      {
        cout << "Enter item no " << i << endl;
        cin >> items[i];
        length++;
      }
    }
  }
  void Display()
  {
    cout << "Display Array content \n";
    for (int i = 0; i < length; i++)
    {
      cout << items[i] << "\t";
    }
    cout << endl;
  }
  int getSize()
  {
    return size;
  }
  int getLength()
  {
    return length;
  }

  int Search(int key)
  {
    int index = -1;
    for (int i = 0; i < length; i++)
    {
      if (items[i] == key)
      {
        index = i;
        break;
      }
    }
    return index;
  }

  void Append(int newitem)
  {
    if (length < size)
    {
      items[length] = newitem;
      length++;
    }
    else
      cout << "Array is full \n";
  }

  void Insert(int index, int newitem)
  {
    if (index >= 0 && index < size)
    {
      for (int i = length; i > index; i--)
      {
        items[i] = items[i - 1];
      }
      items[index] = newitem;
      length++;
    }
    else
    {
      cout << " Error - Index out of Range \n";
    }
  }
  void Delete(int index)
  {
    if (index >= 0 && index < size)
    {
      for (int i = index; i < length - 1; i++)
        items[i] = items[i + 1];
      length--;
    }
    else
      cout << "Index out of Array Range \n";
  }
  void Enlarge(int newsize)
  {
    if (newsize <= size)
    {
      cout << "New size must be larger than current size \n";
      return;
    }
    else
    {
      size = newsize;
      int *old = items;
      items = new int[newsize];
      for (int i = 0; i < length; i++)
      {
        items[i] = old[i];
      }
      delete[] old;
    }
  }
  void Merge(Array other)
  {
    int newsize = size + other.getSize();
    size = newsize;
    int *old = items;
    items = new int[newsize];
    int i;
    for (i = 0; i < length; i++)
    {
      items[i] = old[i];
    }
    delete[] old;
    int j = i;
    for (int i = 0; i < other.getLength(); i++)
    {
      items[j++] = other.items[i];
      length++;
    }
  }
};
int main()
{

  cout << "Hello This is Array ADT demo\n";
  int arraysize;
  cout << "Enter the Array Size \n";
  cin >> arraysize;
  Array myarray(arraysize);
  myarray.Fill();
  cout << "Array size = " << myarray.getSize() << "   while length = " << myarray.getLength() << "\n";
  myarray.Display();
  
  cout << "New array other \n";
  Array other(3);
  other.Fill();
  myarray.Merge(other);
  cout << "Array size = " << myarray.getSize() << "   while length = " << myarray.getLength() << "\n";
  myarray.Display();
}