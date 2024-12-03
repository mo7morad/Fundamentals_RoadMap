#include <iostream>
#include <cstdio>
using namespace std;

short ReadMonth()
{
  short Month;
  cout << "\nPlease enter a Month? ";
  cin >> Month;
  return Month;
}

short ReadYear()
{
  short Year;
  cout << "\nPlease enter a year? ";
  cin >> Year;
  return Year;
}

bool isLeapYear(short Year)
{
  return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
}

short WhichDayOfTheWeek(short Day, short Month, short Year)
{
  short a, y, m;
  a = (14 - Month) / 12;
  y = Year - a;
  m = Month + (12 * a) - 2;
  return (Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
}

short NumberOfDaysInAMonth(short Month, short Year)
{
  if (Month < 1 || Month > 12)
    return 0;
  int days[12] = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
  return (Month == 2) ? (isLeapYear(Year) ? 29 : 28) : days[Month - 1];
}

string MonthShortName(short MonthNumber)
{
  string Months[12] = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
  return (Months[MonthNumber - 1]);
}

void PrintMonthCalendar(short Month, short Year)
{
  int NumberOfDays = NumberOfDaysInAMonth(Month, Year);
  int DayOrder = WhichDayOfTheWeek(1, Month, Year);

  printf("\n ____________%s____________\n\n", MonthShortName(Month).c_str());
  printf(" Sun Mon Tue Wed Thu Fri Sat\n");

  // Offset for the first day
  for (short i = 0; i < DayOrder; i++)
    printf("    "); // 4 spaces for alignment

  // Print days of the month
  for (short day = 1; day <= NumberOfDays; day++)
  {
    printf("%4d", day); // Ensure uniform width
    DayOrder++;

    if (DayOrder == 7) // Break line after Saturday
    {
      DayOrder = 0;
      printf("\n");
    }
  }

  printf("\n ___________________________\n");
}

void PrintYearCalendar(short Year)
{
  printf("\n ___________________________\n");
  printf("\n\tCalendar Year: %d\n", Year);
  printf("\n ___________________________\n");

  for (short i = 1; i <= 12; i++)
  {
    PrintMonthCalendar(i, Year);
  }
}


int main()
{
  short Year = ReadYear();
  PrintYearCalendar(Year);
  return 0;
}
