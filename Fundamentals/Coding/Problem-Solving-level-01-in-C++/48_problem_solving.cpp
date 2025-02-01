#include <iostream>
using namespace std;

int main()
{

  float loanAmount, months;

  cout << "Please enter the loan amount: ";
  cin >> loanAmount;

  cout << "Please enter number of the months: ";
  cin >> months;

  cout << loanAmount / months << endl;

  return 0;
}