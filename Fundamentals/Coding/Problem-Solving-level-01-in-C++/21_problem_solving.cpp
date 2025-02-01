#include <iostream>
using namespace std;

int main()
{

  float circumference, circle_area;
  float Pi = 3.14;

  cout << "Please enter the square area: ";
  cin >> circumference;

  circle_area = (circumference * circumference) / (4 * Pi);
  cout << "The circle area is: " << circle_area << endl;

  return 0;
}