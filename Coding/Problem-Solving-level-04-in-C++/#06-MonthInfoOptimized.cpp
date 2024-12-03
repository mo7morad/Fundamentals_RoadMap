#include <iostream>
using namespace std;

bool isLeapYear(short Year)
{
  return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
}

short NumberOfDaysInAMonth(short Month, short Year)
{
  if (Month < 1 || Month > 12)
    return 0;
  int NumberOfDays[12] = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
  return (Month == 2) ? (isLeapYear(Year) ? 29 : 28) : NumberOfDays[Month - 1];
}

short ReadMonth()
{
  short Month;
  cout << "\nPlease enter a Month to check? ";
  cin >> Month;
  return Month;
}

short ReadYear()
{
  short Year;
  cout << "\nPlease enter a year to check? ";
  cin >> Year;
  return Year;
}

int main()
{
  short Year = ReadYear();
  short Month = ReadMonth();
  cout << "\nNumber of Days in Month [" << Month << "] is " << NumberOfDaysInAMonth(Month, Year);
  return 0;
}