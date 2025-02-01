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

void PassedDaysToDate(short Days, short Year)
{
  short PassedDays = Days;
  short Month = 1;
  if (Days < 31)
  {
    printf("\nDate: %d/%d/%d\n", Days, Month, Year);
    return;
  }
  // looping to know how many months in the days
  while (Days > NumberOfDaysInAMonth(Month, Year)) // loop until the total days are less than the number of days in the month
  {
    Days -= NumberOfDaysInAMonth(Month, Year);
    Month++;
  }
  printf("\nDate for [%d days] in %d is: %d/%d/%d\n", PassedDays, Year, Days, Month, Year);
}

void DateAfterAddingDays(short Days, short Month, short Year)
{
  short ToBeAddedDays = 0;
  short TotalDays = 0;
  
  cout << "How many days you want to add to this date? ";
  cin >> ToBeAddedDays;

  TotalDays = Days + ToBeAddedDays;
  if (TotalDays <= NumberOfDaysInAMonth(Month, Year)) // Checking if the sum is exceeding the days in a month.
  {
    cout << "\nDate after adding " << ToBeAddedDays << " days is: " << TotalDays << "/" << Month << "/" << Year << "\n";
  }
  else
  {
    while (TotalDays > NumberOfDaysInAMonth(Month, Year)) // loop until the total days are less than the number of days in the month
    {
      TotalDays -= NumberOfDaysInAMonth(Month, Year);
      Month++;
      if (Month > 12)
      {
        Month = 1;
        Year++;
      }
    }
    cout << "\nDate after adding " << ToBeAddedDays << " days is: " << TotalDays << "/" << Month << "/" << Year << "\n";
  }
  // looping to know how many months in the days
}

void FinishedDays(short Day, short Month, short Year)
{
  short Days = 0;
  for (short i = 1; i < Month; i++)
    Days += NumberOfDaysInAMonth(i, Year);
  Days += Day;
  cout << "\n" << Days << " days have passed since the beginning of the year.\n";
  PassedDaysToDate(Days, Year);
}

int main()
{
  DateAfterAddingDays(ReadDay(), ReadMonth(), ReadYear());
  return 0;
}


// Course Code

/*
#include <iostream>
using namespace std;

struct sDate {
    short Year;
    short Month;
    short Day;
};

bool isLeapYear(short Year) {
    return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
}

short NumberOfDaysInAMonth(short Month, short Year) {
    if (Month < 1 || Month > 12)
        return 0;
    int days[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    return (Month == 2) ? (isLeapYear(Year) ? 29 : 28) : days[Month - 1];
}

short NumberOfDaysFromTheBeginingOfTheYear(short Day, short Month, short Year) {
    short TotalDays = 0;
    for (int i = 1; i <= Month - 1; i++) {
        TotalDays += NumberOfDaysInAMonth(i, Year);
    }
    TotalDays += Day;
    return TotalDays;
}

sDate DateAddDays(short Days, sDate Date) {
    short RemainingDays = Days + NumberOfDaysFromTheBeginingOfTheYear(Date.Day, Date.Month, Date.Year);
    short MonthDays = 0;
    Date.Month = 1;

    while (true) {
        MonthDays = NumberOfDaysInAMonth(Date.Month, Date.Year);
        if (RemainingDays > MonthDays) {
            RemainingDays -= MonthDays;
            Date.Month++;
            if (Date.Month > 12) {
                Date.Month = 1;
                Date.Year++;
            }
        } else {
            Date.Day = RemainingDays;
            break;
        }
    }
    return Date;
}

short ReadDay() {
    short Day;
    cout << "\nPlease enter a Day? ";
    cin >> Day;
    return Day;
}

short ReadMonth() {
    short Month;
    cout << "\nPlease enter a Month? ";
    cin >> Month;
    return Month;
}

short ReadYear() {
    short Year;
    cout << "\nPlease enter a Year? ";
    cin >> Year;
    return Year;
}

sDate ReadFullDate() {
    sDate Date;
    Date.Day = ReadDay();
    Date.Month = ReadMonth();
    Date.Year = ReadYear();
    return Date;
}

short ReadDaysToAdd() {
    short Days;
    cout << "\nHow many days to add? ";
    cin >> Days;
    return Days;
}

int main() {
    sDate Date = ReadFullDate();
    short Days = ReadDaysToAdd();
    Date = DateAddDays(Days, Date);

    cout << "\nDate after adding [" << Days << "] days is: ";
    cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;

    system("pause>0");
    return 0;
}
*/