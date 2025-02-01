// #include <string>
// #include <iostream>
// #include <vector>
// #include <fstream>
// #include <limits>
// #include <iomanip>

// using namespace std;

// string ReadString(const string &msg)
// {
//   string S1;
//   cout << msg;
//   getline(cin, S1);
//   return S1;
// }

// struct stBankInfo
// {
//   string Name;
//   string AccountNumber;
//   string Balance;
//   string Phone;
//   string PinCode;
// };

// void FillClientBankInfo(stBankInfo &BankInfo)
// {
//   BankInfo.AccountNumber = ReadString("Enter Account Number: ");
//   BankInfo.Balance = ReadString("Enter Balance: ");
//   BankInfo.Name = ReadString("Enter Name: ");
//   BankInfo.Phone = ReadString("Enter Phone Number: ");
//   BankInfo.PinCode = ReadString("Enter Pin Code: ");
// }

// void AddNewClient()
// {
//   fstream ClientsDataPersonalCode;
//   char answer = 'y';

//   while (answer == 'y')
//   {
//     stBankInfo BankInfo;
//     FillClientBankInfo(BankInfo);
//     cout << "\n=== Adding new client to DataBase ===\n";
//     ClientsDataPersonalCode.open("ClientsData.txt", ios::out | ios::app);
//     ClientsDataPersonalCode << "---------------\n";
//     ClientsDataPersonalCode << "Name: " << BankInfo.Name << endl;
//     ClientsDataPersonalCode << "Account: " << BankInfo.AccountNumber << endl;
//     ClientsDataPersonalCode << fixed << setprecision(2);
//     ClientsDataPersonalCode << "Balance: " << BankInfo.Balance << "$"<< endl;
//     ClientsDataPersonalCode << "Phone: " << BankInfo.Phone << endl;
//     ClientsDataPersonalCode << "PIN: " << BankInfo.PinCode << endl;
//     ClientsDataPersonalCode << "---------------\n";
//     ClientsDataPersonalCode << "\n";
//     ClientsDataPersonalCode.close();
//     cout << "Client added to DataBase successfully. Do you want to add more clients? (y/n): ";
//     cin >> answer;
//     cin.ignore(numeric_limits<streamsize>::max(), '\n');
//   }
// }

// int main()
// {
//   AddNewClient();
//   return 0;
// }



// Course Code

#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <limits>
using namespace std;

const string ClientsDataCourseCode = "ClientsDataCourseCode.txt";

struct sClient
{
  string AccountNumber;
  string PinCode;
  string Name;
  string Phone;
  double AccountBalance;
};

sClient ReadNewClient()
{
  sClient Client;
  cout << "Enter Account Number? ";
  getline(cin >> ws, Client.AccountNumber); // Using ws to handle whitespace
  cout << "Enter PinCode? ";
  getline(cin, Client.PinCode);
  cout << "Enter Name? ";
  getline(cin, Client.Name);
  cout << "Enter Phone? ";
  getline(cin, Client.Phone);
  cout << "Enter Account Balance? ";
  cin >> Client.AccountBalance;
  cin.ignore(numeric_limits<streamsize>::max(), '\n'); // Clear the input buffer
  return Client;
}

string ConvertRecordToLine(const sClient &Client, string Seperator = "#//#")
{
  string stClientRecord = "";
  stClientRecord += Client.AccountNumber + Seperator;
  stClientRecord += Client.PinCode + Seperator;
  stClientRecord += Client.Name + Seperator;
  stClientRecord += Client.Phone + Seperator;
  stClientRecord += to_string(Client.AccountBalance);
  return stClientRecord;
}

void AddDataLineToFile(const string &FileName, const string &stDataLine)
{
  fstream MyFile;
  MyFile.open(FileName, ios::out | ios::app);
  if (MyFile.is_open())
  {
    MyFile << stDataLine << endl;
    MyFile.close();
  }
}

void AddNewClient()
{
  sClient Client = ReadNewClient();
  AddDataLineToFile(ClientsDataCourseCode, ConvertRecordToLine(Client));
}

void AddClients()
{
  char AddMore = 'Y';
  do
  {
    cout << "Adding New Client:\n\n";
    AddNewClient();
    cout << "\nClient Added Successfully. Do you want to add more clients? (Y/N): ";
    cin >> AddMore;
    cin.ignore(numeric_limits<streamsize>::max(), '\n'); // Clear input buffer
  } while (toupper(AddMore) == 'Y');
}

int main()
{
  AddClients();
  return 0;
}
