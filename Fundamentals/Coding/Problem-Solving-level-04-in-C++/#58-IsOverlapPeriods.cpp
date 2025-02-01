#include <iostream>
using namespace std;

struct stDate
{
  short Year;
  short Month;
  short Day;
};

struct stPeriods
{
  stDate StartDate, EndDate;
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

stPeriods ReadFullPeriod()
{
  stPeriods Period;
  cout << "Enter Start Date: \n";
  Period.StartDate = ReadFullDate();

  cout << "Enter End Date: \n";
  Period.EndDate = ReadFullDate();
  return Period;
}

enDateComparison DateComparisonOrder(stDate Date1, stDate Date2)
{
  return (IsDate1BeforeDate2(Date1, Date2)) ? Before : ((IsDate1EqualDate2(Date1, Date2)) ? Equal : After);
}

bool IsOverlapPeriods(stPeriods Period1, stPeriods Period2)
{
  return (IsDate1AfterDate2(Period1.EndDate, Period2.StartDate) && IsDate1BeforeDate2(Period1.StartDate, Period2.EndDate));
}

int main()
{
  stPeriods Period1, Period2;
  cout << "Enter Period 1: \n";
  Period1 = ReadFullPeriod();

  cout << "Enter Period 2: \n";
  Period2 = ReadFullPeriod();

  if (IsOverlapPeriods(Period1, Period2))
    cout << "\nYes, Periods Overlap.";
  else
    cout << "\nNo, Periods Do Not Overlap.";

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

struct stPeriod {
    stDate StartDate;
    stDate EndDate;
};

bool IsDate1BeforeDate2(stDate Date1, stDate Date2) {
    return (Date1.Year < Date2.Year) ? true :
           ((Date1.Year == Date2.Year) ?
           (Date1.Month < Date2.Month ? true :
           (Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)) : false);
}

bool IsDate1EqualDate2(stDate Date1, stDate Date2) {
    return (Date1.Year == Date2.Year) ?
           ((Date1.Month == Date2.Month) ?
           (Date1.Day == Date2.Day) : false) : false;
}

bool IsDate1AfterDate2(stDate Date1, stDate Date2) {
    return (!IsDate1BeforeDate2(Date1, Date2) &&
            !IsDate1EqualDate2(Date1, Date2));
}

enum enDateCompare { Before = -1, Equal = 0, After = 1 };

enDateCompare CompareDates(stDate Date1, stDate Date2) {
    if (IsDate1BeforeDate2(Date1, Date2))
        return enDateCompare::Before;
    if (IsDate1EqualDate2(Date1, Date2))
        return enDateCompare::Equal;
    return enDateCompare::After; // this is faster
}

bool IsOverlapPeriods(stPeriod Period1, stPeriod Period2) {
    if (CompareDates(Period2.EndDate, Period1.StartDate) == enDateCompare::Before ||
        CompareDates(Period2.StartDate, Period1.EndDate) == enDateCompare::After)
        return false;
    else
        return true;
}
// bool IsOverlapPeriods(stPeriod Period1, stPeriod Period2) {
//   return (CompareDates(Period2.EndDate, Period1.StartDate) == Before ||
//          (CompareDates(Period2.StartDate, Period1.EndDate) == After)) ? false : true;
// }

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

stPeriod ReadPeriod() {
    stPeriod Period;
    cout << "\nEnter Start Date:\n";
    Period.StartDate = ReadFullDate();
    cout << "\nEnter End Date:\n";
    Period.EndDate = ReadFullDate();
    return Period;
}

int main() {
    cout << "\nEnter Period 1:";
    stPeriod Period1 = ReadPeriod();
    cout << "\nEnter Period 2:";
    stPeriod Period2 = ReadPeriod();

    if (IsOverlapPeriods(Period1, Period2))
        cout << "\nYes, Periods Overlap\n";
    else
        cout << "\nNo, Periods do not Overlap\n";

    system("pause>0");
    return 0;
}

*/