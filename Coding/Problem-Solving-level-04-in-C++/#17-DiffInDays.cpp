#include <iostream>
using namespace std;

short ReadDay()
{
  short Day;
  cout << "Please enter a Day? ";
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

int NumberOfDaysInYear(short Year)
{
  return isLeapYear(Year) ? 366 : 365;
}

int TotalDaysFromStart(short Day, short Month, short Year)
{
  int days = FinishedDays(Day, Month, Year);
  for (short i = 1; i < Year; i++)
  {
    days += NumberOfDaysInYear(i);
  }
  return days;
}

void PrintDifferenceInDates(bool IncludeEndingDay = false)
{
  short Day1, Day2, Month1, Month2, Year1, Year2;
  int Result;
  Day1 = ReadDay();
  Month1 = ReadMonth();
  Year1 = ReadYear();

  cout << "Please Enter the second Date: \n";
  Day2 = ReadDay();
  Month2 = ReadMonth();
  Year2 = ReadYear();
  Result = TotalDaysFromStart(Day2, Month2, Year2) - TotalDaysFromStart(Day1, Month1, Year1);
  if(IncludeEndingDay)
  {
    Result++;
    cout << "The Difference is (Including the end day): " << Result << " Day(s)\n";
  }
  else
    cout << "The Difference is: " << Result << " Day(s)\n";
}



int main()
{
  PrintDifferenceInDates();
  return 0;
}

// Course Code

/*
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

bool IsDate1BeforeDate2(stDate Date1, stDate Date2)
{
    return (Date1.Year < Date2.Year) ? true : ((Date1.Year == Date2.Year) ?
        (Date1.Month < Date2.Month ? true : (Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)) : false);
}

short NumberOfDaysInAMonth(short Month, short Year)
{
    if (Month < 1 || Month > 12)
        return 0;

    int days[12] = { 31,28,31,30,31,30,31,31,30,31,30,31 };
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

int GetDifferenceInDays(stDate Date1, stDate Date2, bool IncludeEndDay = false)
{
    int Days = 0;
    while (IsDate1BeforeDate2(Date1, Date2))
    {
        Days++;
        Date1 = IncreaseDateByOneDay(Date1);
    }
    return IncludeEndDay ? ++Days : Days;
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

int main()
{
    stDate Date1 = ReadFullDate();
    stDate Date2 = ReadFullDate();

    cout << "\nDiffrence is: "
         << GetDifferenceInDays(Date1, Date2) << " Day(s).";

    cout << "\nDiffrence (Including End Day) is: "
         << GetDifferenceInDays(Date1, Date2, true) << " Day(s).";

    system("pause>0");
    return 0;
}
*/