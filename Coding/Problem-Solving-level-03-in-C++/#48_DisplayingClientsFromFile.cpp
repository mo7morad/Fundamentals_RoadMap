#include <string>
#include <iostream>
#include <vector>
#include <fstream>
#include <limits>
#include <iomanip>
using namespace std;
const string FileName = "ClientsDataCourseCode.txt";

string ReadString(const string &msg)
{
  string S1;
  cout << msg;
  getline(cin, S1);
  return S1;
}

string Tabs(short count)
{
  string tabs = "";
  for (short i = 0; i < count; ++i)
  {
    tabs += "\t";
  }
  return tabs;
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
struct stBankInfo
{
  string Name;
  string AccountNumber;
  string Balance;
  string Phone;
  string PinCode;
};

stBankInfo FillBankInfo(string &Record, string Delimiter)
{
  stBankInfo BankInfo;
  vector<string> Info = SplitString(Record, Delimiter);
  BankInfo.AccountNumber = Info[0];
  BankInfo.Balance = Info[1];
  BankInfo.Name = Info[2];
  BankInfo.Phone = Info[3];
  BankInfo.PinCode = Info[4];
  return BankInfo;
}

void PrintHeader()
{
  cout << setw(15) << left << "Account Number"
       << setw(15) << left << "Pin Code"
       << setw(20) << left << "Client Name"
       << setw(15) << left << "Phone"
       << setw(15) << left << "Balance" << endl;
  for (int i = 0; i < 80; ++i)
  {
    cout << "-";
  }
  cout << endl;
}

void PrintDetailedRecordFromFile(stBankInfo Info)
{
  cout << setw(15) << left << Info.AccountNumber
       << setw(15) << left << Info.PinCode
       << setw(20) << left << Info.Name
       << setw(15) << left << Info.Phone
       << setw(15) << left << Info.Balance << endl;
}

int CountLinesInFile(const string &FileName)
{
  ifstream file(FileName);
  short LineCount = 0;
  string line;

  if (file.is_open())
  {
    while (getline(file, line))
    {
      ++LineCount;
    }
    file.close();
  }
  return LineCount;
}

void PrintClientsRecords()
{
  string line = "";
  ifstream file(FileName);
  short LinesCount = CountLinesInFile(FileName);

  PrintHeader();
  for (short i = 0; i < LinesCount; ++i)
  {
    if (file.is_open())
    {
      getline(file, line);
      PrintDetailedRecordFromFile(FillBankInfo(line, "#//#"));
    }
  }
}

int main()
{
  PrintClientsRecords();
  return 0;
}



// Course Code

/*
#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <iomanip>
using namespace std;

const string ClientsFileName = "Clients.txt";

struct sClient
{
    string AccountNumber;
    string PinCode;
    string Name;
    string Phone;
    double AccountBalance;
};

vector<string> SplitString(string S1, string Delim)
{
    vector<string> vString;
    short pos = 0;
    string sWord; // define a string variable
    // use find() function to get the position of the delimiters
    while ((pos = S1.find(Delim)) != std::string::npos)
    {
        sWord = S1.substr(0, pos); // store the word
        if (sWord != "")
        {
            vString.push_back(sWord);
        }
        S1.erase(0, pos + Delim.length());
    }
    if (S1 != "")
    {
        vString.push_back(S1); // it adds last word of the string.
    }
    return vString;
}

sClient ConvertLinetoRecord(string Line, string Seperator = "#//#")
{
    sClient Client;
    vector<string> vClientData;
    vClientData = SplitString(Line, Seperator);
    Client.AccountNumber = vClientData[0];
    Client.PinCode = vClientData[1];
    Client.Name = vClientData[2];
    Client.Phone = vClientData[3];
    Client.AccountBalance = stod(vClientData[4]); // cast string to double
    return Client;
}

vector<sClient> LoadClientsDataFromFile(string FileName)
{
    vector<sClient> vClients;
    fstream MyFile;
    MyFile.open(FileName, ios::in); // read Mode
    if (MyFile.is_open())
    {
        string Line;
        sClient Client;
        while (getline(MyFile, Line))
        {
            Client = ConvertLinetoRecord(Line);
            vClients.push_back(Client);
        }
        MyFile.close();
    }
    return vClients;
}

void PrintClientRecord(sClient Client)
{
    cout << "| " << setw(15) << left << Client.AccountNumber;
    cout << "| " << setw(10) << left << Client.PinCode;
    cout << "| " << setw(40) << left << Client.Name;
    cout << "| " << setw(12) << left << Client.Phone;
    cout << "| " << setw(12) << left << Client.AccountBalance;
}

void PrintAllClientsData(vector<sClient> vClients)
{
    cout << "\n\t\t\t\t\tClient List (" << vClients.size() << ") Client(s).";
    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;
    cout << "| " << left << setw(15) << "Account Number";
    cout << "| " << left << setw(10) << "Pin Code";
    cout << "| " << left << setw(40) << "Client Name";
    cout << "| " << left << setw(12) << "Phone";
    cout << "| " << left << setw(12) << "Balance";
    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;
    for (sClient Client : vClients)
    {
        PrintClientRecord(Client);
        cout << endl;
    }
    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;
} // Added closing brace here
*/