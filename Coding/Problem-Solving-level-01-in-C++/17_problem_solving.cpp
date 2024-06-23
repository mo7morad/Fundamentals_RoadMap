#include <iostream>
using namespace std;

int main(){

float base, height;

cout << "Please enter the base of the triangle: ";
cin >> base;


cout << "Please enter the height of the triangle: ";
cin >> height;

float triangel_area = (base * height) / 2;

cout << "The area of the triangle is: " << triangel_area << endl;

return 0;
}