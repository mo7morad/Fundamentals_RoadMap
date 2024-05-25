#include <iostream>
#include <cmath>
using namespace std;

int main()
{

int inputed_secs;
int days, hours, mins, secs;
int secs_in_day, secs_in_hour, secs_in_min;

secs_in_day = 24*60*60;
secs_in_hour = 60*60;
secs_in_min = 60;


cout << "Enter the number of seconds: ";
cin >> inputed_secs;

days = (inputed_secs) / (secs_in_day);
int reminder = ((inputed_secs) % (secs_in_day));
hours = reminder / secs_in_hour;
reminder = reminder % secs_in_hour;
mins = reminder / secs_in_min;
reminder = reminder % secs_in_min;
secs = reminder;

cout << days << "Day: " << hours << "Hour: " << mins << "Minute: " << secs << "Second. \n";



return 0;
}