#include <iostream>
using namespace std;

int main(){

int n1,n2,temp;

cout << "Please enter your two numbers: ";
cin >> n1;
cin >> n2;

cout << "before swap, n1 is: "<< n1 << ", and n2 is: "<< n2 << "\n";

temp = n1;
n1 = n2;
n2 = temp;

cout << "after swap, n1 is: "<<n1<<", and n2 is: "<< n2<<endl;

  return 0;
}