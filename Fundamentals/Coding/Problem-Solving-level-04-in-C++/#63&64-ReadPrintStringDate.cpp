#include <iostream>
#include <string>
#include <vector>
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

bool IsValidDate(stDate Date)
{
  return (Date.Day >= 1 && Date.Day <= NumberOfDaysInAMonth(Date.Month, Date.Year) && Date.Year > 0);
}

vector<string> SplitString(string S1, string Delim)
{
  short pos = 0;
  string sWord;
  vector<string> vWords;

  // Use find() function to get the position of the delimiters
  while ((pos = S1.find(Delim)) != std::string::npos)
  {
    sWord = S1.substr(0, pos); // store the word
    if (sWord != "")
    {
      vWords.push_back(sWord);
    }
    S1.erase(0, pos + Delim.length()); // erase() until position and move to next word
  }

  if (S1 != "")
  {
    vWords.push_back(S1);
  }
  return vWords;
}

stDate StringtoDate(string Date);

string ReadDate()
{
  string Date;
  stDate sDate;
  do
  {
    cout << "\nPlease enter a Date dd/mm/yyyy? ";
    cin >> Date;
    sDate = StringtoDate(Date);
  } while (!IsValidDate(sDate));
  return Date;
}

stDate StringtoDate(string Date)
{
  stDate sDate;
  vector<string> vDate = SplitString(Date, "/");
  sDate.Day = stoi(vDate[0]);
  sDate.Month = stoi(vDate[1]);
  sDate.Year = stoi(vDate[2]);
  return sDate;
}

string DatetoString(stDate Date)
{
  return to_string(Date.Day) + "/" + to_string(Date.Month) + "/" + to_string(Date.Year);
}

void PrintDate(stDate Date)
{
  cout << "\nThe Date you entered is: " << DatetoString(Date);
}

int main()
{
  stDate sDate;
  string UserDate = ReadDate();
  sDate = StringtoDate(UserDate);
  cout << "\nDay: " << sDate.Day << "\nMonth: " << sDate.Month << "\nYear: " << sDate.Year;
  PrintDate(sDate);
  return 0;
}


// Course Code

/*

#include <iostream>
#include <string>
#include <vector>
using namespace std;

struct stDate {
    short Year;
    short Month;
    short Day;
};

// Function to split a string based on a delimiter
vector<string> SplitString(string S1, string Delim) {
    vector<string> vString;
    size_t pos = 0; // Use size_t for positions
    string sWord; // Define a string variable

    // Use find() function to get the position of the delimiters
    while ((pos = S1.find(Delim)) != string::npos) {
        sWord = S1.substr(0, pos); // Store the word
        if (!sWord.empty()) {
            vString.push_back(sWord);
        }
        S1.erase(0, pos + Delim.length());
    }
    if (!S1.empty()) {
        vString.push_back(S1); // Add the last word of the string
    }
    return vString;
}

// Function to convert a stDate to a string
string DateToString(stDate Date) {
    return to_string(Date.Day) + "/" + to_string(Date.Month) + "/" + to_string(Date.Year);
}

// Function to convert a string to stDate
stDate StringToDate(string DateString) {
    stDate Date;
    vector<string> vDate = SplitString(DateString, "/");

    // Ensure there are exactly 3 parts
    if (vDate.size() == 3) {
        Date.Day = stoi(vDate[0]);
        Date.Month = stoi(vDate[1]);
        Date.Year = stoi(vDate[2]);
    } else {
        cout << "Invalid date format. Please use dd/mm/yyyy." << endl;
    }

    return Date;
}

// Function to read a string date from user input
string ReadStringDate(string Message) {
    string DateString;
    cout << Message;
    getline(cin >> ws, DateString); // Read the entire line
    return DateString;
}

int main() {
    string DateString = ReadStringDate("\nPlease Enter Date dd/mm/yyyy? ");
    stDate Date = StringToDate(DateString);

    // Output the parsed date
    cout << "\nDay: " << Date.Day << endl;
    cout << "Month: " << Date.Month << endl;
    cout << "Year: " << Date.Year << endl;
    cout << "\nYou Entered: " << DateToString(Date) << "\n";

    system("pause>0");
    return 0;
}

*/