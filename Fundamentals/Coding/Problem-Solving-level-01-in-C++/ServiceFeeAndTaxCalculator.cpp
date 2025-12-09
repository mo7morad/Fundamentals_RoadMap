#include <iostream>
using namespace std;

int main()
{

float bill_value, totalBillAfterTaxes;

cout << "Please enter the bill value before the taxes: ";
cin >> bill_value;

totalBillAfterTaxes = bill_value * 1.1; // 10% service fee
totalBillAfterTaxes = totalBillAfterTaxes * 1.16; // 16% sales tax

cout << "Your total bill after taxes: " << totalBillAfterTaxes << endl;



  return 0;
}