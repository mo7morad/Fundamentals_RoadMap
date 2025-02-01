#include <iostream>
using namespace std;

struct stDate
{
  short Year;
  short Month;
  short Day;
};

bool isLeapYear(short Year)
{
  return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
}

short NumberOfDaysInAMonth(short Month, short Year)
{
  if (Month < 1 || Month > 12)
    return 0;
  int days[12] = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
  return (Month == 2) ? (isLeapYear(Year) ? 29 : 28) : days[Month - 1];
}

bool IsLastDayInMonth(stDate Date)
{
  return (Date.Day == NumberOfDaysInAMonth(Date.Month, Date.Year));
}

bool IsLastMonthInYear(short Month)
{
  return (Month == 12);
}

bool IsFirstMonthInYear(short Month)
{
  return (Month == 1);
}

bool IsFirstDayInMonth(short Day)
{
  return (Day == 1);
}

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
  cout << "Please enter a Month? ";
  cin >> Month;
  return Month;
}

short ReadYear()
{
  short Year;
  cout << "Please enter a Year? ";
  cin >> Year;
  return Year;
}

stDate ReadFullDate()
{
  stDate Date;
  Date.Day = ReadDay();
  Date.Month = ReadMonth();
  Date.Year = ReadYear();
  return Date;
}

stDate DecreaseDateByOneDay(stDate Date)
{
  if (IsFirstDayInMonth(Date.Day))
  {
    if (IsFirstMonthInYear(Date.Month))
    {
      Date.Month = 12;
      Date.Day = 31;
      Date.Year--;
    }
    else
    {
      Date.Month--;
      Date.Day = NumberOfDaysInAMonth(Date.Month, Date.Year);
    }
  }
  else
  {
    Date.Day--;
  }
  return Date;
}

stDate DecreaseDateByXDay(stDate Date, short Days)
{
  for (int i = 0; i < Days; i++)
  {
    Date = DecreaseDateByOneDay(Date);
  }
  return Date;
}

stDate DecreaseDateByOneWeek(stDate Date)
{
  return Date = DecreaseDateByXDay(Date, 7);
}

stDate DecreaseDateByXWeek(stDate Date, short Weeks)
{
  return Date = DecreaseDateByXDay(Date, Weeks * 7);
}

stDate DecreaseDateByOneMonth(stDate Date)
{
  if (IsFirstMonthInYear(Date.Month))
  {
    Date.Month = 12;
    Date.Year--;
  }
  else
  {
    Date.Month--;
  }

  // last check day in date should not exceed max days in the current month
  //  example if date is 31/1/2022 increasing one month should not be 31/2/2022, it should be 28/2/2022

  short daysInNewMonth = NumberOfDaysInAMonth(Date.Month, Date.Year);
  if (Date.Day > daysInNewMonth)
  {
    Date.Day = daysInNewMonth;
  }

  return Date;
}

stDate DecreaseDateByXMonth(stDate Date, short Months)
{
  for (short i = 0; i < Months; i++)
  {
    Date = DecreaseDateByOneMonth(Date);
  }
  return Date;
}

stDate DecreaseDateByOneYear(stDate Date)
{
  Date.Year--;
  return Date;
}

stDate DecreaseDateByXYears(stDate Date, short Years)
{
  for (short i = 0; i < Years; i++)
  {
    Date = DecreaseDateByOneYear(Date);
  }
  return Date;
}

stDate DecreaseDateByXYearsFaster(stDate Date, short Years)
{
  Date.Year -= Years;
  return Date;
}

stDate DecreaseDateByOneDecade(stDate Date)
{
  Date.Year -= 10;
  return Date;
}

stDate DecreaseDateByXDecades(stDate Date, short Decades)
{
  for (short i = 0; i < Decades; i++)
  {
    Date = DecreaseDateByOneDecade(Date);
  }
  return Date;
}

stDate DecreaseDateByXDecadesFaster(stDate Date, short Decades)
{
  Date.Year -= Decades * 10;
  return Date;
}

stDate DecreaseDateByOneCentury(stDate Date)
{
  Date.Year -= 100;
  return Date;
}

stDate DecreaseDateByOneMillennium(stDate Date)
{
  Date.Year -= 1000;
  return Date;
}

int main()
{
  stDate Date1 = ReadFullDate();

  cout << "\nOriginal Date: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year << endl;

  Date1 = DecreaseDateByOneDay(Date1);
  cout << "Date after decreasing by one day: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year << endl;

  Date1 = DecreaseDateByXDay(Date1, 5);
  cout << "Date after decreasing by 5 days: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year << endl;

  Date1 = DecreaseDateByOneWeek(Date1);
  cout << "Date after decreasing by one week: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year << endl;

  Date1 = DecreaseDateByXWeek(Date1, 2);
  cout << "Date after decreasing by 2 weeks: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year << endl;

  Date1 = DecreaseDateByOneMonth(Date1);
  cout << "Date after decreasing by one month: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year << endl;

  Date1 = DecreaseDateByXMonth(Date1, 3);
  cout << "Date after decreasing by 3 months: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year << endl;

  Date1 = DecreaseDateByOneYear(Date1);
  cout << "Date after decreasing by one year: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year << endl;

  Date1 = DecreaseDateByXYears(Date1, 2);
  cout << "Date after decreasing by 2 years: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year << endl;

  Date1 = DecreaseDateByXYearsFaster(Date1, 5);
  cout << "Date after decreasing by 5 years (faster): " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year << endl;

  Date1 = DecreaseDateByOneDecade(Date1);
  cout << "Date after decreasing by one decade: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year << endl;

  Date1 = DecreaseDateByXDecades(Date1, 2);
  cout << "Date after decreasing by 2 decades: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year << endl;

  Date1 = DecreaseDateByXDecadesFaster(Date1, 3);
  cout << "Date after decreasing by 3 decades (faster): " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year << endl;

  Date1 = DecreaseDateByOneCentury(Date1);
  cout << "Date after decreasing by one century: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year << endl;

  Date1 = DecreaseDateByOneMillennium(Date1);
  cout << "Date after decreasing by one millennium: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year << endl;

  return 0;
}

// Course Code

/*

*/