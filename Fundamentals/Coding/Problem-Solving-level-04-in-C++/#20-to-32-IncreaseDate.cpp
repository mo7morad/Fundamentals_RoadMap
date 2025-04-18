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

stDate IncreaseDateByOneDay(stDate Date)
{
  if (IsLastDayInMonth(Date))
  {
    if (IsLastMonthInYear(Date.Month))
    {
      Date.Month = 1;
      Date.Day = 1;
      Date.Year++;
    }
    else
    {
      Date.Day = 1;
      Date.Month++;
    }
  }
  else
  {
    Date.Day++;
  }
  return Date;
}

stDate IncreaseDateByXDay(stDate Date, short Days) 
{
  for (int i = 0; i < Days; i++)
  {
    Date = IncreaseDateByOneDay(Date);
  }
  return Date;
}

stDate IncreaseDateByOneWeek(stDate Date)
{
  return Date = IncreaseDateByXDay(Date, 7);
}

stDate IncreaseDateByXWeek(stDate Date, short Weeks)
{
  return Date = IncreaseDateByXDay(Date, Weeks * 7);
}

stDate IncreaseDateByOneMonth(stDate Date)
{
  if (IsLastMonthInYear(Date.Month))
  {
    Date.Month = 1;
    Date.Year++;
  }
  else
  {
    Date.Month++;
  }
  
  //last check day in date should not exceed max days in the current month
  // example if date is 31/1/2022 increasing one month should not be 31/2/2022, it should be 28/2/2022

  short daysInNewMonth = NumberOfDaysInAMonth(Date.Month, Date.Year);
  if (Date.Day > daysInNewMonth)
  {
    Date.Day = daysInNewMonth;
  }
  
  return Date;
}

stDate IncreaseDateByXMonth(stDate Date, short Months)
{
  for(short i = 0; i < Months; i++)
  {
    Date = IncreaseDateByOneMonth(Date);
  }
  return Date;
}

stDate IncreaseDateByOneYear(stDate Date)
{
  Date.Year++;
  return Date;
}

stDate IncreaseDateByXYears(stDate Date, short Years)
{
  for(short i = 0; i < Years; i++)
  {
    Date = IncreaseDateByOneYear(Date);
  }
  return Date;
}

stDate IncreaseDateByXYearsFaster(stDate Date, short Years)
{
  Date.Year += Years;
  return Date;
}

stDate IncreaseDateByOneDecade(stDate Date)
{
  Date.Year += 10;
  return Date;
}

stDate IncreaseDateByXDecades(stDate Date, short Decades)
{
  for(short i = 0; i < Decades; i++)
  {
    Date = IncreaseDateByOneDecade(Date);
  }
  return Date;
}

stDate IncreaseDateByXDecadesFaster(stDate Date, short Decades)
{
  Date.Year += Decades * 10;
  return Date;
}

stDate IncreaseDateByOneCentury(stDate Date)
{
  Date.Year += 100;
  return Date;
}

stDate IncreaseDateByOneMillennium(stDate Date)
{
  Date.Year += 1000;
  return Date;
}




int main()
{
  stDate Date1 = ReadFullDate();

  Date1 = IncreaseDateByOneDay(Date1);
  cout << "\nDate after adding one day is: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year;

  Date1 = IncreaseDateByXDay(Date1, 5);
  cout << "\nDate after adding 5 days is: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year;

  Date1 = IncreaseDateByOneWeek(Date1);
  cout << "\nDate after adding one week is: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year;

  Date1 = IncreaseDateByXWeek(Date1, 2);
  cout << "\nDate after adding 2 weeks is: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year;

  Date1 = IncreaseDateByOneMonth(Date1);
  cout << "\nDate after adding one month is: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year;

  Date1 = IncreaseDateByXMonth(Date1, 3);
  cout << "\nDate after adding 3 months is: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year;

  Date1 = IncreaseDateByOneYear(Date1);
  cout << "\nDate after adding one year is: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year;

  Date1 = IncreaseDateByXYears(Date1, 2);
  cout << "\nDate after adding 2 years is: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year;

  Date1 = IncreaseDateByXYearsFaster(Date1, 5);
  cout << "\nDate after adding 5 years (faster) is: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year;

  Date1 = IncreaseDateByOneDecade(Date1);
  cout << "\nDate after adding one decade is: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year;

  Date1 = IncreaseDateByXDecades(Date1, 2);
  cout << "\nDate after adding 2 decades is: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year;

  Date1 = IncreaseDateByXDecadesFaster(Date1, 3);
  cout << "\nDate after adding 3 decades (faster) is: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year;

  Date1 = IncreaseDateByOneCentury(Date1);
  cout << "\nDate after adding one century is: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year;

  Date1 = IncreaseDateByOneMillennium(Date1);
  cout << "\nDate after adding one millennium is: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year;

  return 0;
}

// Course Code

/*

*/
