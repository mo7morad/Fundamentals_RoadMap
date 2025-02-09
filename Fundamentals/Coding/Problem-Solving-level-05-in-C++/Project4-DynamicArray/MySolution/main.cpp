#include <iostream>
#include "DynamicArray.h"
using namespace std;

// This is for testing MyDynamicArray class
int main()
{
  DynamicArray<int> myarray(5);

  myarray.Append(10);
  myarray.Append(20);
  myarray.Append(30);
  myarray.Append(40);
  myarray.Append(50);
  
  cout << "\nArray size = " << myarray.GetSize() << "   while length = " << myarray.GetLength() << "\n";
  cout << "Array elements are \n";
  myarray.Display();

  cout << "Inserting 100 at index 2 \n";
  myarray.InsertAt(2, 100);
  myarray.Display();

  cout << "Deleting the item at index 2 \n";
  myarray.DeleteAt(2);
  myarray.Display();

  cout << "Deleting the item by value 100 (Doesn't Exist) \n";
  myarray.DeleteByValue(100);
  cout << "Deleting the item by value 21 (Exist) \n";
  myarray.DeleteByValue(21);
  cout << "after deleteing\n";
  myarray.Display();

  cout << "The index of 100 is " << myarray.Search(100) << "\n";
  cout << "The index of 200 is " << myarray.Search(200) << "\n";

  myarray.Append(200);
  cout << "The array after appending 200 \n";
  myarray.Display();

  cout << "Updating the item at index 2 to 300 \n";
  myarray.Update(2, 300);
  myarray.Display();

  cout << "Appending 400 \n";
  myarray.Append(400);
  myarray.Display();

  cout << "Trying to insert at outbound index \n";
  myarray.InsertAt(10, 500);

  cout << "Trying to delete at outbound index \n";
  myarray.DeleteAt(10);

  cout << "Appending while array is full \n";
  myarray.Append(500);

  // Shrinking the array
  cout << "\nShrinking the array to size 3 \n";
  myarray.Resize(3);
  cout << "Array after shrinking \n";
  myarray.Display();

  // Enlarging the array
  cout << "\nEnlarging the array to size 10 \n";
  myarray.Resize(10);
  cout << "Array after enlarging \n";
  myarray.Display();
  cout << "Size after enlarging = " << myarray.GetSize() << "\n";

  // Reverse the array
  cout << "\nReversing the array \n";
  cout << "\nArray before reversing \n";
  myarray.Display();
  myarray.Reverse();
  cout << "\nArray after reversing \n";
  myarray.Display();

  cout << "\nClear the array \n";
  myarray.Clear();
  myarray.Display();

  // cout << "New array other \n";
  // DynamicArray other(3);
  // other.Fill();
  // myarray.Merge(other);
  // cout << "Array size = " << myarray.getSize() << "   while length = " << myarray.getLength() << "\n";
  // myarray.Display();
}