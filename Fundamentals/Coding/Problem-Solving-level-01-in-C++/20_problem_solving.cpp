#include <iostream>
using namespace std;

int main(){


float square_area, circle_area;
float Pi = 3.14;

cout << "Please enter the square area: ";
cin >> square_area;

circle_area = (Pi * square_area * square_area) / 4;
cout << "The circle area is: " << circle_area << endl;




  return 0;
}