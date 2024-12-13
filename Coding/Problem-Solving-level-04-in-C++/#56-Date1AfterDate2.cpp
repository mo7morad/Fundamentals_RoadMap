#include <iostream>
using namespace std;

struct stDate
{
  short Year;
  short Month;
  short Day;
};

bool IsDate1BeforeDate2(stDate Date1, stDate Date2)
{
  return (Date1.Year < Date2.Year) ? true : ((Date1.Year == Date2.Year) ? (Date1.Month < Date2.Month ? true : (Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)) : false);
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


int main()
{
  stDate Date1, Date2;
  cout << "Please enter the first date: ";
  Date1 = ReadFullDate();

  cout << "Please enter the second date: ";
  Date2 = ReadFullDate();

  if (IsDate1AfterDate2(Date1, Date2))
    cout << "Yes, the first date is after the second date.";
  else
    cout << "No, the first date is not after the second date.";
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
    return (Date1.Year < Date2.Year) ? true : ((Date1.Year == Date2.Year) ? (Date1.Month < Date2.Month ? true : (Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)) : false);
}

bool IsDate1EqualDate2(stDate Date1, stDate Date2) {
    return (Date1.Year == Date2.Year) ? ((Date1.Month == Date2.Month) ? ((Date1.Day == Date2.Day) ? true : false) : false) : false;
}

bool IsDate1AfterDate2(stDate Date1, stDate Date2) {
    return (!IsDate1BeforeDate2(Date1, Date2) && !IsDate1EqualDate2(Date1, Date2));
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
    cout << "\nEnter Date1:";
    stDate Date1 = ReadFullDate();

    cout << "\nEnter Date2:";
    stDate Date2 = ReadFullDate();

    if (IsDate1AfterDate2(Date1, Date2))
        cout << "\nYes, Date1 is After Date2.";
    else
        cout << "\nNo, Date1 is NOT After Date2.";

    system("pause>0");
    return 0;
}

*/