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

bool IsLastDayInMonth(int Day, int Month, int Year)
{
  return Day == NumberOfDaysInAMonth(Month, Year);
}

bool IsLastMonthInYear(int Month)
{
  return Month == 12;
}

void CheckLastDayAndMonth(int Day, int Month, int Year)
{
  if (IsLastDayInMonth(Day, Month, Year))
    cout << "Yes, it is the last day of the month." << endl;
  if (IsLastMonthInYear(Month))
    cout << "Yes, it is the last month of the year." << endl;
}

void IncreaseDateByOneDay(int Day, int Month, int Year)
{
  if (IsLastDayInMonth(Day, Month, Year) && IsLastMonthInYear(Month))
  {
    Day = 1; Month = 1; Year++;
    cout << "The next day is: " << Day << "/" << Month << "/" << Year << endl;
  }
  else if(IsLastDayInMonth(Day, Month, Year))
  {
    Day = 1; Month++;
    cout << "The next day is: " << Day << "/" << Month << "/" << Year << endl;
  }
  else
  {
    Day++;
    cout << "The next day is: " << Day << "/" << Month << "/" << Year << endl;
  }
}

int main()
{
  IncreaseDateByOneDay(ReadDay(), ReadMonth(), ReadYear());
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

bool isLeapYear(short Year) {
    return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
}

short NumberOfDaysInAMonth(short Month, short Year) {
    if (Month < 1 || Month > 12)
        return 0;
    int days[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    return (Month == 2) ? (isLeapYear(Year) ? 29 : 28) : days[Month - 1];
}

bool IsLastDayInMonth(stDate Date) {
    return (Date.Day == NumberOfDaysInAMonth(Date.Month, Date.Year));
}

bool IsLastMonthInYear(short Month) {
    return (Month == 12);
}

stDate IncreaseDateByOneDay(stDate Date) {
    if (IsLastDayInMonth(Date)) {
        if (IsLastMonthInYear(Date.Month)) {
            Date.Month = 1;
            Date.Day = 1;
            Date.Year++;
        } else {
            Date.Day = 1;
            Date.Month++;
        }
    } else {
        Date.Day++;
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
    Date1 = IncreaseDateByOneDay(Date1);
    cout << "\nDate after adding one day is: " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year;

    system("pause>0");
    return 0;
}
*/