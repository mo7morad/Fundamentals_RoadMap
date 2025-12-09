#include <iostream>
using namespace std;

int main()
{

short Nickel = 5;
short Dime = 10;
short Quarter = 25;
short Dollar = 100;

cout << "Please enter how many Pennies, Nickles, Dimes, Quarters, Dollars do you have on a row: \n";

float n_pennies, n_nickles, n_dimes, n_quarters, n_dollars;

cin >> n_pennies;
cin >> n_nickles;
cin >> n_dimes;
cin >> n_quarters;
cin >> n_dollars;

float total_pennies = (n_pennies + (n_nickles*Nickel) + (n_dimes*Dime) + (n_quarters*Quarter) + (n_dollars*Dollar));
float total_in_dollars = (total_pennies/100);

cout <<  "You have " << total_pennies << " Penny\n" << total_in_dollars << "$ Dollars." ;
    return 0;
}