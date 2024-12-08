#include <iostream>
#include <cstdio>
using namespace std;

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

void CompareDate()
{
  short Day1, Day2, Month1, Month2, Year1, Year2;
  cout << "\nPlease enter the first date: ";
  Day1 = ReadDay();
  Month1 = ReadMonth();
  Year1 = ReadYear();
  cout << "\nPlease enter the second date: ";
  Day2 = ReadDay();
  Month2 = ReadMonth();
  Year2 = ReadYear();

  if (Year1 > Year2)
  {
    cout << "Date 1 Is greater than Date2";
  }
  else if (Year1 < Year2)
  {
    cout << "Date 2 Is greater than Date1";
  }
  else
  {
    if (Month1 > Month2)
    {
      cout << "Date 1 Is greater than Date2";
    }
    else if (Month1 < Month2)
    {
      cout << "Date 2 Is greater than Date1";
    }
    else
    {
      if (Day1 > Day2)
      {
        cout << "Date 1 Is greater than Date2";
      }
      else if (Day1 < Day2)
      {
        cout << "Date 2 Is greater than Date1";
      }
      else
      {
        cout << "Date 1 Is equal to Date2";
      }
  }
  }
}


int main()
{
  CompareDate();
  return 0;
}


// Course Code

/*
#include <iostream>
using namespace std;

struct stDate {
    short Year;
    short Month;
    short Day;
};

bool IsDate1BeforeDate2(stDate Date1, stDate Date2) {
    return (Date1.Year < Date2.Year) ? true :
            ((Date1.Year == Date2.Year) ?
            (Date1.Month < Date2.Month ? true :
            (Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)) : false);
}

short ReadDay() {
    short Day;
    cout << "\nPlease enter a Day? ";
    cin >> Day;
    return Day;
}

short ReadMonth() {
    short Month;
    cout << "Please enter a Month? ";
    cin >> Month;
    return Month;
}

short ReadYear() {
    short Year;
    cout << "Please enter a Year? ";
    cin >> Year;
    return Year;
}

stDate ReadFullDate() {
    stDate Date;
    Date.Day = ReadDay();
    Date.Month = ReadMonth();
    Date.Year = ReadYear();
    return Date;
}

int main() {
    stDate Date1 = ReadFullDate();
    stDate Date2 = ReadFullDate();

    if (IsDate1BeforeDate2(Date1, Date2))
        cout << "\nYes, Date1 is Less than Date2.";
    else
        cout << "\nNo, Date1 is NOT Less than Date2.";

    system("pause>0");
    return 0;
}
*/