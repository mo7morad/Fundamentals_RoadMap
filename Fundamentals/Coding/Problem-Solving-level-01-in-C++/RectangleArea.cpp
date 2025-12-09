#include <iostream>
using namespace std;

int main(){

//calculating rectangel area

float length, width;

cout << "Please enter the highet of the rectangel: ";
cin>> length;
cout << "Please enter the width of the rectangel: ";
cin>> width;

float rectangle_area = length * width;

cout << "The rectangle area is: " << rectangle_area << endl;


  return 0;
}