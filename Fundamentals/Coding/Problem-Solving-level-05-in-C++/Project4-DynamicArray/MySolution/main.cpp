#include <iostream>
#include "DynamicArray.h"
using namespace std;

// This is for testing MyDynamicArray class
int main()
{
  DynamicArray<int> myarray(5);
  myarray.Fill();
  cout << "\nArray size = " << myarray.GetSize() << "   while length = " << myarray.GetLength() << "\n";
  cout << "Array elements are \n";
  myarray.Display();

  cout << "Inserting 100 at index 2 \n";
  myarray.InsertAt(2, 100);
  myarray.Display();

  cout << "Deleting the item at index 2 \n";
  myarray.Delete(2);
  myarray.Display();

  cout << "The index of 100 is " << myarray.Search(100) << "\n";

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
  myarray.Delete(10);

  cout << "Appending while array is full \n";
  myarray.Append(500);


  // cout << "New array other \n";
  // DynamicArray other(3);
  // other.Fill();
  // myarray.Merge(other);
  // cout << "Array size = " << myarray.getSize() << "   while length = " << myarray.getLength() << "\n";
  // myarray.Display();
}