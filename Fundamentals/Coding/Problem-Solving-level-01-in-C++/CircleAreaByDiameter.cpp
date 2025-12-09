#include <iostream>
using namespace std;

int main (){


float circle_diameter;
float Pi = 3.14;

cout << "Please enter the diameter of the cricle: ";
cin >> circle_diameter;

float circle_area = (Pi * circle_diameter * circle_diameter) / 4;

cout << "The area of the circle is: " << circle_area << endl;




  return 0;
}