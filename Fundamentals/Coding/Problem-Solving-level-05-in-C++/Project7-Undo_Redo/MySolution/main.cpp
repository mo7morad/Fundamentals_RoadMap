#include "MyString.h"

int main()
{
  MyString myString;

  // Test 1: Initial state
  cout << "Initial Value: " << myString.GetValue() << endl; // Expected: ""

  // Test 2: Set a new value
  myString.SetValue("Hello");
  cout << "After SetValue('Hello'): " << myString.GetValue() << endl; // Expected: "Hello"

  // Test 3: Set another value
  myString.SetValue("World");
  cout << "After SetValue('World'): " << myString.GetValue() << endl; // Expected: "World"

  // Test 4: Undo to previous state
  if (myString.Undo())
  {
    cout << "After Undo: " << myString.GetValue() << endl; // Expected: "Hello"
  }
  else
  {
    cout << "Undo failed (nothing to undo)." << endl;
  }

  // Test 5: Redo to next state
  if (myString.Redo())
  {
    cout << "After Redo: " << myString.GetValue() << endl; // Expected: "World"
  }
  else
  {
    cout << "Redo failed (nothing to redo)." << endl;
  }

  // Test 6: Undo again
  if (myString.Undo())
  {
    cout << "After Undo: " << myString.GetValue() << endl; // Expected: "Hello"
  }
  else
  {
    cout << "Undo failed (nothing to undo)." << endl;
  }

  // Test 7: Set a new value after undo (should clear redo stack)
  myString.SetValue("C++");
  cout << "After SetValue('C++'): " << myString.GetValue() << endl; // Expected: "C++"

  // Test 8: Try to redo (should fail because redo stack was cleared)
  if (myString.Redo())
  {
    cout << "After Redo: " << myString.GetValue() << endl;
  }
  else
  {
    cout << "Redo failed (nothing to redo)." << endl; // Expected: This message
  }

  // Test 9: Undo to previous state
  if (myString.Undo())
  {
    cout << "After Undo: " << myString.GetValue() << endl; // Expected: "Hello"
  }
  else
  {
    cout << "Undo failed (nothing to undo)." << endl;
  }

  // Test 10: Undo again (should fail because nothing left to undo)
  if (myString.Undo())
  {
    cout << "After Undo: " << myString.GetValue() << endl;
  }
  else
  {
    cout << "Undo failed (nothing to undo)." << endl; // Expected: This message
  }

  return 0;
}