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


  cout << "----------------------------\n";
  cout << "Testing Merge function \n";

  myarray.Append(10);
  myarray.Append(20);
  myarray.Append(30);
  myarray.Append(40);
  myarray.Append(50);

  DynamicArray<int> myarray2(5);
  myarray2.Append(1);
  myarray2.Append(2);
  myarray2.Append(3);
  myarray2.Append(4);
  myarray2.Append(5);

  cout << "Array 1 \n";
  myarray.Display();

  cout << "Array 2 \n";
  myarray2.Display();

  cout << "Merging Array 1 and Array 2 \n";
  myarray.Merge(myarray2);
  myarray.Display();

  cout << "Array 2 after merging \n";
  myarray2.Display();

  cout << "----------------------------\n";
  cout << "Testing Merge function using static function \n";
  DynamicArray<int> array1(5);
  DynamicArray<int> array2(5);
  // Fill array1 with some integers.
  array1.Append(10);
  array1.Append(20);
  array1.Append(30);
  // Fill array2 with some integers.
  array2.Append(40);
  array2.Append(50);
  array2.Append(60);
  // Display the original arrays.
  cout << "Array 1:" << endl;
  array1.Display();
  cout << "Array 2:" << endl;
  array2.Display();
  // Use the static Merge function to combine array1 and array2 into a new array.
  DynamicArray<int> mergedArray = DynamicArray<int>::Merge(array1, array2);
  // Display the merged array.
  cout << "Merged Array:" << endl;
  mergedArray.Display();

  
  return 0;
}