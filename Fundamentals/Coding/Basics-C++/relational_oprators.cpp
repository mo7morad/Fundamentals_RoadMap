#include <iostream>
using namespace std;

int main()
{

  int a, b;
  cout << "Please enter your first number: ";
  cin >> a;

  cout << "Please enter your second number: ";
  cin >> b;

cout << a << " = " << b << " is: " <<  (a == b) << endl;
cout << a << " != " << b << " is: " <<  (a != b) << endl;
cout << a << " > " << b << " is: " <<  (a > b) << endl;
cout << a << " < " << b << " is: " <<  (a < b) << endl;
cout << a << " >= " << b << " is: " <<  (a >= b) << endl;
cout << a << " <= " << b << " is: " <<  (a <= b) << endl;



  return 0;
}