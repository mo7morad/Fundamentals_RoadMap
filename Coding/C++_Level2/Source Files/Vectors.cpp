#include <vector>
#include <iostream>
using namespace std;

int main()
{
  // Create a vector of integers
  vector<int> vNumbers = {10, 20, 30, 40, 50};

  // Print elements using a ranged for loop
  cout << "Numbers Vector = ";
  for (int &Number : vNumbers) // used by ref to be faster, we don't want
                              // to copy each elemnt cuz it will take space and time
  {
    cout << Number << " ";
  }
  cout << endl;

  vNumbers.push_back(60); // adding new number in the end.
  vNumbers.pop_back(); // Removing the last added element in the vector.
  vNumbers.clear(); // Clearing the whole vector.

  // Accessing first and last elements
  cout << "First Element: " << vNumbers.front() << endl;
  cout << "Last Element: " << vNumbers.back() << endl;

  // Size and Capacity
  cout << "Size: " << vNumbers.size() << endl;
  cout << "Capacity: " << vNumbers.capacity() << endl;

  // Checking if empty
  cout << "Empty: " << vNumbers.empty() << endl; // Prints 0 (false)


  return 0;
}

/*
#include <iostream>
#include <numeric>
#include <limits>
#include <vector>
using namespace std;

int ReadNumber()
{
    int Number;
    cout << "Please enter a number: ";
    cin >> Number;
    cout << endl;

    while (cin.fail())
    {
        // Clear the error flag on cin
        cin.clear();
        // Ignore the invalid input up to the maximum stream size or until a newline character
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        cout << "Invalid number, please enter a valid one: ";
        cin >> Number;
        cout << endl;
    }
    return Number; // This was missing
}

bool ValidateAddMore()
{
    char validation;
    while (true)
    {
        cout << "Do you want to add more numbers? Y/N\n";
        cin >> validation;
        validation = tolower(validation);

        if (validation == 'y')
        {
            return true;
        }
        else if (validation == 'n')
        {
            return false;
        }
        else
        {
            cout << "Invalid input. Please enter 'Y' or 'N'.\n";
        }
    }
}

void FillVectorNumbers(vector<int> &vNumbers)
{
    do
    {
        Numbers.push_back(ReadNumber());
    } while (ValidateAddMore());
}

void PrintVectorNumbers(const vector<int> &vNumbers) // const reference
{
    for (int Number : Numbers)
        cout << Number << " ";
    cout << endl;
}

int main()
{
    vector<int> vNumbers;
    FillVectorNumbers(Numbers);
    PrintVectorNumbers(Numbers);

    return 0;
}
*/

/*
#include <iostream>
#include <numeric>
#include <limits>
#include <vector>
using namespace std;

struct stEmployee
{
  string FirstName;
  string LastName;
  float Salary;
};

stEmployee ReadEmployeeInfo()
{
  stEmployee Employee;
  cout << "Please enter the Employee's first name: ";
  cin >> Employee.FirstName;
  cout << "Please enter the Employee's last name: ";
  cin >> Employee.LastName;
  cout << "Please enter the Employee's Salary: ";
  cin >> Employee.Salary;
  return Employee; // Returning the Employee object
}

bool ValidateAddMore()
{
  char validation;
  while (true)
  {
    cout << "Do you want to add more employees? Y/N\n";
    cin >> validation;
    validation = tolower(validation);

    if (validation == 'y')
    {
      return true;
    }
    else if (validation == 'n')
    {
      return false;
    }
    else
    {
      cout << "Invalid input. Please enter 'Y' or 'N'.\n";
    }
  }
}

void FillEmployeeVector(vector<stEmployee> &Employees)
{
  do
  {
    Employees.push_back(ReadEmployeeInfo());
  } while (ValidateAddMore());
}

void PrintEmployeeVector(const vector<stEmployee> &Employees)
{
  for (const stEmployee &Employee : Employees)
  {
    cout << "First Name: " << Employee.FirstName << "\n";
    cout << "Last Name: " << Employee.LastName << "\n";
    cout << "Salary: " << Employee.Salary << "\n";
    cout << "--------------------------\n";
  }
}

int main()
{
  vector<stEmployee> Employees;
  FillEmployeeVector(Employees);
  PrintEmployeeVector(Employees);
  return 0;
}
*/

// Vector Iterator

/*
#include <iostream>
#include <vector>
using namespace std;

int main() {
    // Create a vector of integers
    vector<int> num = {1, 2, 3, 4, 5};

    // Declare an iterator for the vector
    vector<int>::iterator iter;

    // Use iterator with a for loop to iterate through the vector
    for (iter = num.begin(); iter != num.end(); iter++) {
        // Access and print the value at the current iterator position
        cout << *iter << " ";
    }

    cout << endl; // Add a newline character at the end

    return 0;
}
*/