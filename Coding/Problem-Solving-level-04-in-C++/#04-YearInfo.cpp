#include <iostream>
#include <iomanip>
using namespace std;

short ReadYear()
{
  short Year;
  cout << "\nPlease enter a year to check? ";
  cin >> Year;
  return Year;
}

bool IsLeapYear(short Year)
{
  return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
}

int NumberOfDaysInYear(short Year)
{
  return IsLeapYear(Year) ? 366 : 365;
}

int NumberOfHoursInYear(short Year)
{
  return NumberOfDaysInYear(Year) * 24;
}

int NumberOfMinutesInYear(short Year)
{
  return NumberOfHoursInYear(Year) * 60;
}

double NumberOfSecondsInYear(short Year)
{
  return NumberOfMinutesInYear(Year) * 60;
}

void RunTheApp()
{
  short Year = ReadYear();
  cout << "\nYear [" << Year << "] has [" << NumberOfDaysInYear(Year) << "] days.\n";
  cout << "Year [" << Year << "] has [" << NumberOfHoursInYear(Year) << "] hours.\n";
  cout << "Year [" << Year << "] has [" << NumberOfMinutesInYear(Year) << "] minutes.\n";
  cout << "Year [" << Year << "] has [" << fixed << setprecision(0) << NumberOfSecondsInYear(Year) << "] seconds.\n";
}

int main()
{
  RunTheApp();
}
