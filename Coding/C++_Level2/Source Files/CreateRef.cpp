#include <iostream>

using namespace std;

int main()
{
  // Declare an integer variable 'a' and initialize it with 10
  int a = 10;

  // Declare a reference variable 'x' that refers to the memory location of 'a'
  int &x = a;

  // Print the memory addresses of 'a' and 'x' (they will be the same)
  cout << "&a (address of a): " << &a << endl;
  cout << "&x (address of a through x): " << &x << endl;

  // Print the values of 'a' and 'x' (they will have the same value)
  cout << "a: " << a << endl;
  cout << "x: " << x << endl;

  // Modify the value at the memory location referenced by 'x' (which also affects 'a')
  x = 20;

  // Print the values of 'a' and 'x' again (both will be updated to 20)
  cout << "a (after modification through x): " << a << endl;
  cout << "x: " << x << endl;

  // Modify the value of 'a' directly (which also affects 'x')
  a = 30;

  // Print the values of 'a' and 'x' again (both will be updated to 30)
  cout << "a (after direct modification): " << a << endl;
  cout << "x: " << x << endl;

  return 0;
}
