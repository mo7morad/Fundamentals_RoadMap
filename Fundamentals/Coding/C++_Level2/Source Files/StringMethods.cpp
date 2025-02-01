#include <iostream> // Include header for input/output operations
#include <string>   // Include header for string manipulation

using namespace std; // Use the std namespace for standard C++ objects

int main()
{
  // Create a string variable named S1 and initialize it with text
  string S1 = "My Name is Mohammed Abu-Hadhoud, I Love Programming.";

  // **String Methods:**

  // Print the length of the string (number of characters)
  cout << S1.length() << endl;

  // Access and print the character at index 3 (zero-based indexing)
  cout << S1.at(3) << endl;

  // Append "@ProgrammingAdvices" to the end of the string
  S1.append(" @ProgrammingAdvices");

  // Print the entire string after appending
  cout << S1 << endl;

  // Insert " Ali " at position 7 (between "Name" and "is")
  S1.insert(7, " Ali ");

  // Print the string after inserting the substring
  cout << S1 << endl;

  // Extract and print 8 characters starting from index 16
  cout << S1.substr(16, 8) << endl;

  // Add the character 'X' to the end of the string
  S1.push_back('X');

  // Print the string after pushing the character
  cout << S1 << endl;

  // Remove the last character from the string
  S1.pop_back();

  // Print the string after popping the character
  cout << S1 << endl;

  // Find the starting position of the substring "Ali" (case-sensitive)
  int ali_pos = S1.find("Ali");
  if (ali_pos != string::npos)
  {
    cout << "'Ali' found at position: " << ali_pos << endl;
  }
  else
  {
    cout << "'Ali' not found in the string (case-sensitive)" << endl;
  }

  // Find the starting position of the substring "ali" (case-sensitive)
  int lowercase_ali_pos = S1.find("ali");
  if (lowercase_ali_pos != string::npos)
  {
    cout << "'ali' found at position (case-insensitive): " << lowercase_ali_pos << endl;
  }
  else
  {
    cout << "'ali' not found in the string (case-sensitive search)" << endl;
  }

  // Remove all characters from the string
  S1.clear();

  // Print the string after clearing (it should be empty)
  cout << S1 << endl;

  return 0; // Indicate successful program termination
}
