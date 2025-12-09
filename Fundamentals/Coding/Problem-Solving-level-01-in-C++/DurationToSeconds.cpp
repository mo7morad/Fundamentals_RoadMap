#include <iostream>
using namespace std;

int main()
{

float days,hours,mins,secs;

cout << "Please enter the number of days, hours, minutes, seconds on a row: " << "\n";

cin >> days;
cin >> hours;
cin >> mins;
cin >> secs;

float total_seconds = ((days*24*60*60) +  (hours*60*60) +  (mins*60) + secs);

cout << total_seconds << " Second" << endl;




  return 0;
}