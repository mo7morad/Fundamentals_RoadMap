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

struct stBankInfo{
  string Name;
  string AccountNumber;
  string Balance;
  string Phone;
  string PinCode;
};

stBankInfo ReadBankInfo()
{
  stBankInfo BankInfo;
  BankInfo.Name = ReadString("Enter Name: ");
  BankInfo.AccountNumber = ReadString("Enter Account Number: ");
  BankInfo.Balance = ReadString("Enter Balance: ");
  BankInfo.Phone = ReadString("Enter Phone: ");
  BankInfo.PinCode = ReadString("Enter Pin Code: ");
  return BankInfo;
}

void DisplayBankInfoOneLine(stBankInfo Client, string Separator = "#//#")
{
  cout << Client.AccountNumber + Separator + Client.Balance + Separator + Client.Name + Separator + Client.Phone + Separator + Client.PinCode;
}

int main()
{
  stBankInfo Client = ReadBankInfo();
  DisplayBankInfoOneLine(Client);
  return 0;
}

// Course Code

/*
#include<iostream>
#include<fstream>
#include<string>
#include<vector>
using namespace std;

struct sClient {
    string AccountNumber;
    string PinCode;
    string Name;
    string Phone;
    double AccountBalance;
};

sClient ReadNewClient() {
    sClient Client;
    cout << "Enter Account Number? ";
    getline(cin, Client.AccountNumber);
    cout << "Enter PinCode? ";
    getline(cin, Client.PinCode);
    cout << "Enter Name? ";
    getline(cin, Client.Name);
    cout << "Enter Phone? ";
    getline(cin, Client.Phone);
    cout << "Enter AccountBalance? ";
    cin >> Client.AccountBalance;
    return Client;
}

string ConvertRecordToLine(sClient Client, string Seperator = "#//#") {
    string stClientRecord = "";
    stClientRecord += Client.AccountNumber + Seperator;
    stClientRecord += Client.PinCode + Seperator;
    stClientRecord += Client.Name + Seperator;
    stClientRecord += Client.Phone + Seperator;
    stClientRecord += to_string(Client.AccountBalance);
    return stClientRecord;
}

int main() {
    cout << "\nPlease Enter Client Data: \n\n";
    sClient Client;
    Client = ReadNewClient();
    cout << "\n\nClient Record for Saving is: \n";
    cout << ConvertRecordToLine(Client);
    system("pause>0");
    return 0;
}
*/