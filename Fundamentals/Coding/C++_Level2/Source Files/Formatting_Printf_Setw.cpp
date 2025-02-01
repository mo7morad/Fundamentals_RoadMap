#include <iostream>
#include <cstdio>

using namespace std;

int main()
{
  int Page = 1, TotalPages = 10;

  // Print string and int variable
  printf("The page number = %d \n", Page);
  printf("You are in Page %d of %d \n", Page, TotalPages);

  // Width specification
  printf("The page number = %0*d \n", 2, Page); // %0 this is the filling.
  printf("The page number = %0*d \n", 3, Page); // the Num after the column is how much is the filling
  printf("The page number = %0*d \n", 4, Page);
  printf("The page number = %0*d \n", 5, Page);

  int Number1 = 20, Number2 = 30;
  printf("The Result of %d + %d = %d \n", Number1, Number2, Number1 + Number2);

  return 0;
}

/*
#include <iostream>
#include <cstdio>

using namespace std;

int main() {
  float PI = 3.14159265;

  // Precision specification
  printf("Precision specification of %.1f\n", PI);
  printf("Precision specification of %.2f\n", PI);
  printf("Precision specification of %.3f\n", PI);
  printf("Precision specification of %.4f\n", PI);

  float x = 7.0, y = 9.0;

  // Float division with specified precision
  printf("\nThe float division is: %.3f / %.3f = %.3f \n\n", x, y, x / y);

  double d = 12.45;

  // Double value with different precisions
  printf("The double value is: %.3f\n", d);
  printf("The double value is: %.4f\n", d);

  return 0;
}

*/

/*

#include <iostream>  // Optional for this code
#include <cstdio>

int main() {
  char name[] = "Mohammed Abu-Hadhoud";
  char school_name[] = "Programming Advices";
  char c = 'S';

  // Print strings with newlines
  printf("Dear %s, How are you?\n\n", name);
  printf("Welcome to %s School!\n\n", school_name);

  // Print character with varying widths
  printf("Setting the width of c: %*c\n", 1, c);
  printf("Setting the width of c: %*c\n", 2, c);
  printf("Setting the width of c: %*c\n", 3, c);
  printf("Setting the width of c: %*c\n", 4, c);
  printf("Setting the width of c: %*c\n", 5, c);

  return 0;
}


*/

/*

#include <iostream>
#include <iomanip>

using namespace std;

int main() {
  // Header for the table
  cout << "---------|--------------------------------|---------|" << endl;
  cout << " Code | Name | Mark |" << endl;
  cout << "---------|--------------------------------|---------|" << endl;

  // Using setw manipulator for formatting
  cout << setw(9) << "C101" << "|" << setw(32) << "Introduction to Programming 1" << "|" << setw(9) << "95" << "|" << endl;
  cout << setw(9) << "C102" << "|" << setw(32) << "Computer Hardware" << "|" << setw(9) << "88" << "|" << endl;
  cout << setw(9) << "C1035243" << "|" << setw(32) << "Network" << "|" << setw(9) << "75" << "|" << endl;

  // Closing table header
  cout << "---------|--------------------------------|---------|" << endl;

  return 0;
}


*/