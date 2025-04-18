#include <iostream>
#include <cstdio>
using namespace std;

struct stDate
{
  short Year;
  short Month;
  short Day;
};

short ReadDay()
{
  short Day;
  cout << "\nPlease enter a Day? ";
  cin >> Day;
  return Day;
}

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

short NumberOfDaysInYear(short Year)
{
  return isLeapYear(Year) ? 366 : 365;
}

short NumberOfDaysInAMonth(short Month, short Year)
{
  if (Month < 1 || Month > 12)
    return 0;
  int days[12] = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
  return (Month == 2) ? (isLeapYear(Year) ? 29 : 28) : days[Month - 1];
}

short FinishedDays(short Day, short Month, short Year)
{
  short Days = 0;
  for (short i = 1; i < Month; i++)
    Days += NumberOfDaysInAMonth(i, Year);
  Days += Day;
  return Days;
  // cout << "\n" << Days << " days have passed since the beginning of the year.\n";
  // PassedDaysToDate(Days, Year);
}

short WhichDayOfTheWeek(short Day, short Month, short Year)
{
  short a, y, m;
  a = (14 - Month) / 12;
  y = Year - a;
  m = Month + (12 * a) - 2;
  return (Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
}

short WhichDayOfTheWeek(stDate Date)
{
  return WhichDayOfTheWeek(Date.Day, Date.Month, Date.Year);
}

string DayShortName(short WhichDayOfTheWeek)
{
  string arrDayNames[] = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};
  return arrDayNames[WhichDayOfTheWeek];
}

bool IsEndOfWeek(stDate Date)
{
  return (WhichDayOfTheWeek(Date) == 6);
}

bool IsWeekEnd(stDate Date)
{
  return (WhichDayOfTheWeek(Date) == 5 || WhichDayOfTheWeek(Date) == 6);
}

bool IsBusinessDay(stDate Date)
{
  return (!IsWeekEnd(Date));
}

short DaysUntilTheEndOfWeek(stDate Date)
{
  if (!IsEndOfWeek(Date))
  {
    short CurrentIndexOfDay = WhichDayOfTheWeek(Date);
    return (6 - CurrentIndexOfDay);
  }
  return 0;
}

short DaysUntilTheEndOfMonth(stDate Date)
{
  return (NumberOfDaysInAMonth(Date.Month, Date.Year) - Date.Day);
}

short DaysUntilTheEndOfYear(stDate Date)
{
  return (NumberOfDaysInYear(Date.Year) - FinishedDays(Date.Day, Date.Month, Date.Year));
}

stDate GetSystemDate()
{
  stDate Date;
  time_t t = time(0);
  tm *now = localtime(&t);
  Date.Year = now->tm_year + 1900;
  Date.Month = now->tm_mon + 1;
  Date.Day = now->tm_mday;
  return Date;
}


int main()
{
  stDate Date;
  Date = GetSystemDate();
  cout << "Today is: " << DayShortName(WhichDayOfTheWeek(Date)) << " , " << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;
  
  cout << "Is it end of the week?\n";
  if(IsEndOfWeek(Date))
    cout << "Yes it is the end of the week.\n";
  else
    cout << "No, It's not the end of the week.\n";
  
  cout << "Is It Week End?\n";
  if(IsWeekEnd(Date))
    cout << "Yes, it is a Weekend!\n";
  else
    cout << "No, it's not a Weekend!\n";
  
  cout << "Is it a Business Day?\n";
  if(IsBusinessDay(Date))
    cout << "Yes it is a Business day!\n";
  else
    cout << "No, it is not a Business day";
  
  cout << "Days Until end of week " << DaysUntilTheEndOfWeek(Date) << " Day(s).\n";
  cout << "Days Until end of Month " << DaysUntilTheEndOfMonth(Date) << " Day(s).\n";
  cout << "Days Until end of Year " << DaysUntilTheEndOfYear(Date) << " Day(s).\n";

  return 0;
}

// Course Code

/*



*/
