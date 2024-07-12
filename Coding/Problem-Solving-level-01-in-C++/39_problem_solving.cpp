#include <iostream>
using namespace std;

int main()
{

float total_bill, paid_cash;

cout << "Please enter the total of the bill: ";
cin >> total_bill;

cout << "Please enter the cash has been paid: ";
cin >> paid_cash;

float reminder = paid_cash - total_bill;

cout << "The reminder is: " << reminder << endl;



  return 0;
}