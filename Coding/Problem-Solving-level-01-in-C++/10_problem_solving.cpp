#include <iostream>
using namespace std;


float MarksAvg(float mark1, float mark2, float mark3){
  return  (mark1 + mark2 + mark3)/3;
}

int main(){

float mark1,mark2,mark3;

cout<< "please enter your marks: ";
cin >> mark1 >> mark2 >> mark3;

cout << "Your average mark is: " << MarksAvg(mark1,mark2,mark3) << endl;

  return 0;
}