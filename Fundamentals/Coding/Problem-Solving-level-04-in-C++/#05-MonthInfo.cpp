#include <iostream>
using namespace std;

bool isLeapYear(short Year)
{
  // If year is divisible by 4 AND not divisible by 100
  // OR if year is divisible by 400, then it is a leap year
  return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
}

short NumberOfDaysInAMonth(short Month, short Year)
{
  if (Month < 1 || Month > 12)
  {
    return 0; // Invalid month
  }
  if (Month == 2)
  {
    return isLeapYear(Year) ? 29 : 28; // February
  }
  short arr31Days[7] = {1, 3, 5, 7, 8, 10, 12};
  for (short i = 0; i < 7; i++)
  {
    if (arr31Days[i] == Month)
    {
      return 31; // Months with 31 days
    }
  }
  // If you reach here, it's a month with 30 days
  return 30;
}

short NumberOfHoursInAMonth(short Month, short Year)
{
  return NumberOfDaysInAMonth(Month, Year) * 24;
}

int NumberOfMinutesInAMonth(short Month, short Year)
{
  return NumberOfHoursInAMonth(Month, Year) * 60;
}

int NumberOfSecondsInAMonth(short Month, short Year)
{
  return NumberOfMinutesInAMonth(Month, Year) * 60;
}

short ReadMonth()
{
  short Month;
  cout << "\nPlease enter a Month to check (1-12): ";
  cin >> Month;
  return Month;
}

short ReadYear()
{
  short Year;
  cout << "\nPlease enter a year to check: ";
  cin >> Year;
  return Year;
}

int main()
{
  short Year = ReadYear();
  short Month = ReadMonth();
  cout << "\nNumber of Days in Month [" << Month << "] is "
      << NumberOfDaysInAMonth(Month, Year);
  cout << "\nNumber of Hours in Month [" << Month << "] is "
      << NumberOfHoursInAMonth(Month, Year);
  cout << "\nNumber of Minutes in Month [" << Month << "] is "
      << NumberOfMinutesInAMonth(Month, Year);
  cout << "\nNumber of Seconds in Month [" << Month << "] is "
      << NumberOfSecondsInAMonth(Month, Year);
  system("pause>0");
  return 0;
}