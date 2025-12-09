#include <iostream>
using namespace std;

int main()
{

  float a, b;
  float Pi = 3.14;

  cout << "Please enter a: ";
  cin >> a;
  
  cout << "Please enter b: ";
  cin >> b;


  float circle_area = (((Pi*b*b)/4) * ((2*a-b) / (2*a+b)));
  cout << "The circle area is: " << circle_area << endl;

  return 0;
}