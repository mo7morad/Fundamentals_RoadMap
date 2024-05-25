#include <iostream>
#include <cmath>
using namespace std;

int main (){

float a,b,c,p,Pi,circle_area;
Pi = 3.14;

cout << "Please enter a, b and c: ";
cin >> a >> b >> c;


p = (a+b+c)/2;
circle_area = round(Pi*pow((a*b*c)/(4*sqrt(p*(p-a)*(p-b)*(p-c))),2));

cout << "The circle area is: " << circle_area << endl;


  return 0;
}