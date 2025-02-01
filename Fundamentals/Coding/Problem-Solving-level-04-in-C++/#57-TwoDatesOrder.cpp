#include <iostream>
using namespace std;

struct stDate
{
  short Year;
  short Month;
  short Day;
};

enum enDateComparison
{
  Before = -1,
  Equal = 0,
  After = 1
};

bool IsDate1BeforeDate2(stDate Date1, stDate Date2)
{
  return (Date1.Year < Date2.Year) ? true : ((Date1.Year == Date2.Year) ? (Date1.Month < Date2.Month ? true : (Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)) : false);
}

bool IsDate1EqualDate2(stDate Date1, stDate Date2)
{
  return (Date1.Year == Date2.Year) ? ((Date1.Month == Date2.Month) ? ((Date1.Day == Date2.Day) ? true : false) : false) : false;
}

bool IsDate1AfterDate2(stDate Date1, stDate Date2)
{
  return (Date1.Year > Date2.Year) ? true : ((Date1.Year == Date2.Year) ? (Date1.Month > Date2.Month ? true : (Date1.Month == Date2.Month ? Date1.Day > Date2.Day : false)) : false);
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

enDateComparison DateComparisonOrder(stDate Date1, stDate Date2)
{
  return (IsDate1BeforeDate2(Date1, Date2)) ? Before : ((IsDate1EqualDate2(Date1, Date2)) ? Equal : After);
}

int main()
{
  stDate Date1, Date2;
  cout << "Please enter the first date: ";
  Date1 = ReadFullDate();

  cout << "Please enter the second date: ";
  Date2 = ReadFullDate();

  cout << "The Result is: " << DateComparisonOrder(Date1, Date2); 

  return 0;
}

// Course Code

/*

*/