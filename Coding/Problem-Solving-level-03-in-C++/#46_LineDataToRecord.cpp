#include <string>
#include <iostream>
#include <vector>
using namespace std;

string ReadString(string msg)
{
  string S1;
  cout << msg << endl;
  getline(cin, S1);
  return S1;
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

stBankInfo FillBankInfo(string Record, string Delimiter){
  stBankInfo BankInfo;
  vector<string> Info = SplitString(Record, Delimiter);
  BankInfo.AccountNumber = Info[0];
  BankInfo.Balance = Info[1];
  BankInfo.Name = Info[2];
  BankInfo.Phone = Info[3];
  BankInfo.PinCode = Info[4];
  return BankInfo;
}

void PrintDetailedRecord(stBankInfo Info){
  cout << "The following are the extracted client info:\n";
  cout << "Account Number: " << Info.AccountNumber << endl;
  cout << "Balance: " << Info.Balance << endl;
  cout << "Name: " << Info.Name << endl;
  cout << "Phone: " << Info.Phone << endl;
  cout << "Pin Code: " << Info.PinCode << endl;
}


int main()
{
  string BankRecord = ReadString("Please eneter your record here:\n");
  PrintDetailedRecord(FillBankInfo(BankRecord, "#//#"));
  return 0;
}

// Course Code

/*
#include <iostream>
#include <fstream>
#include <string>
#include <vector>
using namespace std;

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

void PrintClientRecord(sClient Client)
{
    cout << "\n\nThe following is the extracted client record:\n";
    cout << "\nAccount Number: " << Client.AccountNumber;
    cout << "\nPin Code : " << Client.PinCode;
    cout << "\nName : " << Client.Name;
    cout << "\nPhone : " << Client.Phone;
    cout << "\nAccount Balance: " << Client.AccountBalance;
}

int main()
{
    string stLine = "A150#//#1234#//#Mohammed Abu-Hadhoud#//#079999#//#5270.000000";
    cout << "\nLine Record is:\n";
    cout << stLine;
    sClient Client = ConvertLinetoRecord(stLine);
    PrintClientRecord(Client);
    system("pause>0");
    return 0;
}
*/