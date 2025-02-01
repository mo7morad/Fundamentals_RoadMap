#include <iostream>
using namespace std;

int main(){

float loanAmount, monthlyPayment;

cout << "Please enter the loan amount: ";
cin  >> loanAmount;

cout << "Please enter the monthly payment: ";
cin >> monthlyPayment;

cout << loanAmount / monthlyPayment << " Months." << endl;


  return 0;
}