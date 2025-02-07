#include <iostream>
#include "clsMyDynamicArray.h"

using namespace std;

int main()
{

  clsDynamicArray<int> MyDynamicArray(5);

  MyDynamicArray.SetItem(0, 10);
  MyDynamicArray.SetItem(1, 20);
  MyDynamicArray.SetItem(2, 30);
  MyDynamicArray.SetItem(3, 40);
  MyDynamicArray.SetItem(4, 50);

  cout << "Is Array Empty: " << MyDynamicArray.IsEmpty() ? cout << "Yes\n" : cout << "No\n";
  cout << "\nArray Size: " << MyDynamicArray.Size() << "\n";
  cout << "\nArray Items: \n";

  MyDynamicArray.PrintList();

  system("exit");
}