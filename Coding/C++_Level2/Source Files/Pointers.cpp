#include <iostream>
using namespace std;

int main()
{
  // Declare an integer variable 'a' and initialize it with 10
  int a = 10;
  int &x = a; // this is alias for a, like Mohamed and Hamoksha same person,
              // but different names or alias. Also refs like this can't be changed
              // thru the run time, but pointers can since it's a variable has a value in memory.

  // Print the value and address of 'a'
  cout << "a value = " << a << endl;
  cout << "a address = " << &a << endl;

  // Declare an integer pointer 'p'
  // Pointers are existied to store ref of anything you want.
  // it know by the (*) sign, and it only allows you to store ref(s) only.
  int *p;

  // Assign the address of 'a' to the pointer 'p'
  p = &a;

  // Print the value stored in the pointer 'p' (which is the memory address of 'a')
  cout << "Pointer Value = " << p << endl;
  // Derefrence the address of the pointer
  cout << "Value inside the address = " << *p << endl;

  // Changing the value of the var thru the pointer
  *p = 20; // this will change the value.

  cout << "Value after changing thru the pointer = " << *p << endl;

  a = 30;
  cout << "Value after changing thru the var itself = " << a << endl;

  return 0;
}


// Swap with pointers.

/*
#include <iostream>

using namespace std;

// Swap function that takes two integer pointers as parameters
void swap(int *n1, int *n2) {
  // Temporary variable to hold the value pointed to by n1
  int temp = *n1;

  // Swap the values using pointers
  *n1 = *n2;  // Dereference n1 to modify the value at the memory location it points to
  *n2 = temp;  // Dereference n2 to modify the value at the memory location it points to
}

int main() {
  int a = 1, b = 2;

  cout << "Before swapping" << endl;
  cout << "a = " << a << endl;
  cout << "b = " << b << endl;

  // Call the swap function, passing the addresses of a and b
  swap(&a, &b);

  cout << "\nAfter swapping" << endl;
  cout << "a = " << a << endl;
  cout << "b = " << b << endl;

  return 0;
}
*/

// Pointers and Array.

/*
#include <iostream>

using namespace std;

int main() {
  // Declare an array 'arr' of 4 integers and initialize it with values
  int arr[4] = {10, 20, 30, 40};

  // Declare an integer pointer 'ptr'
  int *ptr;

  // Assign the address of the first element of 'arr' to 'ptr'
  ptr = arr; // This is equivalent to ptr = &arr[0];

  // Print a message about array name and pointer relationship
  cout << "Array name 'arr' and pointer 'ptr' relationship:\n";
  cout << "arr: " << arr << endl; // Array name decays to the address of its first element
  cout << "ptr: " << ptr << endl;  // ptr points to the first element's address

  // Explain pointer arithmetic relationship with array elements
  cout << "\nPointer arithmetic relationship with array elements:\n";
  cout << "ptr + 0 (equivalent to &arr[0]): " << ptr << endl;
  cout << "ptr + 1 (equivalent to &arr[1]): " << ptr + 1 << endl;
  cout << "ptr + 2 (equivalent to &arr[2]): " << ptr + 2 << endl;
  cout << "ptr + 3 (equivalent to &arr[3]): " << ptr + 3 << endl;

  // Print values
  cout << "\nValues of elements accessed through the pointer:\n";
  cout << "*ptr (value at ptr): " << *ptr << endl;
  cout << "*(ptr + 1) (value at ptr + 1): " << *(ptr + 1) << endl;
  cout << "*(ptr + 2) (value at ptr + 2): " << *(ptr + 2) << endl;
  cout << "*(ptr + 3) (value at ptr + 3): " << *(ptr + 3) << endl;

  for (int i = 0; i < arr.length; i++){
    cout << *(ptr + i) << " "
  }

  return 0;
}
*/


// Pointers and struct.

/*
#include <iostream>

using namespace std;

// Structure to represent an employee
struct Employee {
  string Name;
  float Salary;
};

int main() {
  // Create an Employee object named Employee1
  Employee Employee1;

  // Assign values to Employee1's members
  Employee1.Name = "Mohammed Abu-Hadhoud";
  Employee1.Salary = 5000;

  // Print the member values of Employee1 directly
  cout << "Employee Details (using member access):\n";
  cout << "Name: " << Employee1.Name << endl;
  cout << "Salary: " << Employee1.Salary << endl;

  // Declare a pointer to an Employee object
  Employee *ptr;

  // Assign the address of Employee1 to the pointer
  ptr = &Employee1;

  // Print a message about using a pointer
  cout << "\nEmployee Details (using pointer):\n";

  // Access Employee1's members using the pointer and arrow operator (->)
  cout << "Name: " << ptr->Name << endl;
  cout << "Salary: " << ptr->Salary << endl;

  return 0;
}
*/

// Generic Pointers (Void)

/*
#include <iostream>
using namespace std;

int main() {
  // Declare a void pointer 'ptr'
  void *ptr;

  float f1 = 10.5;
  int x = 50;

  // Assign the address of 'f1' to the void pointer 'ptr'
  // (Caution: This can be risky without proper casting)
  ptr = &f1;

  // Print the address stored in 'ptr'
  cout << "Address stored in ptr (pointing to f1): " << ptr << endl;

  // Dereference 'ptr' after casting it to float*
  // This is necessary because 'ptr' is a void pointer and cannot directly access data
  cout << "Value at the address pointed to by ptr (cast to float): "
       << *(static_cast<float*>(ptr)) << endl;

  // Assign the address of 'x' to the void pointer 'ptr'
  ptr = &x;

  // Print the address stored in 'ptr' (now pointing to x)
  cout << "Address stored in ptr (pointing to x): " << ptr << endl;

  // Dereference 'ptr' after casting it to int*
  // Casting is again necessary to ensure compatibility
  cout << "Value at the address pointed to by ptr (cast to int): "
       << *(static_cast<int*>(ptr)) << endl;

  return 0;
}
*/

/*
#include <iostream>

using namespace std;

int main() {
    // Declare integer and float pointers
    int* ptrX;
    float* ptrY;

    // Dynamically allocate memory for integer and float
    ptrX = new int;
    ptrY = new float;

    // Assign values to the allocated memory
    *ptrX = 45;
    *ptrY = 58.35f;

    // Print the values
    cout << *ptrX << endl;
    cout << *ptrY << endl;

    // Deallocate the memory (crucial to avoid memory leaks)
    delete ptrX;
    delete ptrY;

    return 0;
}
*/