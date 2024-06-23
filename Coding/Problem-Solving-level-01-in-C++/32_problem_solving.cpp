#include <iostream>
#include <cmath>
using namespace std;

int main()
{

float num,expo,result;
result = 1;


cout << "Please enter the number: ";
cin >> num;

cout << "Please enter the exponent: ";
cin >> expo;

for(int i = 0; i < expo; i++){

  if(expo == 0){
    cout << result;
  }
  else{
    result *= num;

  }
}

cout << "The result is: " << result << endl;


  return 0;
}