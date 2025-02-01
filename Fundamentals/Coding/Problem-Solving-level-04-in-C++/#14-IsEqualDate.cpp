#include <iostream>
using namespace std;

struct stDate
{
  short Year;
  short Month;
  short Day;
};

bool IsDate1EqualDate2(stDate Date1, stDate Date2)
{
  return (Date1.Year == Date2.Year) ? ((Date1.Month == Date2.Month) ? (Date1.Day == Date2.Day) : false) : false;
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

  if (IsDate1EqualDate2(Date1, Date2))
    cout << "\nYes, Date1 is Equal To Date2.";
  else
    cout << "\nNo, Date1 is NOT Equal To Date2.";

  system("pause>0");
  return 0;
}
