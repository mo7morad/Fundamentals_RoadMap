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

// Function to split a string based on a delimiter
vector<string> SplitString(string S1, string Delim)
{
  vector<string> vString;
  size_t pos = 0; // Use size_t for positions
  string sWord;   // Define a string variable

  // Use find() function to get the position of the delimiters
  while ((pos = S1.find(Delim)) != string::npos)
  {
    sWord = S1.substr(0, pos); // Store the word
    if (!sWord.empty())
    {
      vString.push_back(sWord);
    }
    S1.erase(0, pos + Delim.length()); // Erase until position and move to next word
  }
  if (!S1.empty())
  {
    vString.push_back(S1); // Add the last word of the string
  }
  return vString;
}

// Function to replace a word in a string
string ReplaceWordInString(string S1, string StringToReplace, string sReplaceTo)
{
  size_t pos = S1.find(StringToReplace);
  while (pos != string::npos)
  {
    S1.replace(pos, StringToReplace.length(), sReplaceTo);
    pos = S1.find(StringToReplace); // Find next
  }
  return S1;
}

// Function to convert stDate to string
string DateToString(stDate Date)
{
  return to_string(Date.Day) + "/" + to_string(Date.Month) + "/" + to_string(Date.Year);
}

// Function to convert a string to stDate
stDate StringToDate(string DateString)
{
  stDate Date;
  vector<string> vDate = SplitString(DateString, "/");

  // Ensure there are exactly 3 parts
  if (vDate.size() == 3)
  {
    Date.Day = stoi(vDate[0]);
    Date.Month = stoi(vDate[1]);
    Date.Year = stoi(vDate[2]);
  }
  else
  {
    cout << "Invalid date format. Please use dd/mm/yyyy." << endl;
  }

  return Date;
}

// Function to format a date based on a specified format
string FormateDate(stDate Date, string DateFormat = "dd/mm/yyyy")
{
  string FormattedDateString = DateFormat;
  FormattedDateString = ReplaceWordInString(FormattedDateString, "dd", to_string(Date.Day));
  FormattedDateString = ReplaceWordInString(FormattedDateString, "mm", to_string(Date.Month));
  FormattedDateString = ReplaceWordInString(FormattedDateString, "yyyy", to_string(Date.Year));
  return FormattedDateString;
}

// Function to read a string date from user input
string ReadStringDate(string Message)
{
  string DateString;
  cout << Message;
  getline(cin >> ws, DateString); // Read the entire line
  return DateString;
}

int main()
{
  string DateString = ReadStringDate("\nPlease Enter Date dd/mm/yyyy? ");
  stDate Date = StringToDate(DateString);

  // Output formatted dates
  cout << "\nFormatted Date (default): " << FormateDate(Date) << "\n";
  cout << "\nFormatted Date (yyyy/dd/mm): " << FormateDate(Date, "yyyy/dd/mm") << "\n";
  cout << "\nFormatted Date (mm/dd/yyyy): " << FormateDate(Date, "mm/dd/yyyy") << "\n";
  cout << "\nFormatted Date (mm-dd-yyyy): " << FormateDate(Date, "mm-dd-yyyy") << "\n";
  cout << "\nFormatted Date (dd-mm-yyyy): " << FormateDate(Date, "dd-mm-yyyy") << "\n";
  cout << "\nFormatted Date (Day:dd, Month:mm, Year:yyyy): " << FormateDate(Date, "Day:dd, Month:mm, Year:yyyy") << "\n";

  return 0;
}

// Course Code

/*



*/