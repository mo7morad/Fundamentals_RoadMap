#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <iomanip>
#include <limits>
using namespace std;

const string ClientsFileName = "ClientsDataCourseCode.txt";

void PrintEqualSigns(short Num)
{
  for (short i = 0; i < Num; i++)
  {
    cout << "=";
  }
}

string ReadString(string msg)
{
  string S1;
  cout << msg << endl;
  getline(cin, S1);
  return S1;
}

string ReadClientAccountNumber()
{
  string AccountNumber = "";
  cout << "\nPlease enter AccountNumber? ";
  getline(cin, AccountNumber);
  return AccountNumber;
}

struct stClient
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

stClient ConvertLinetoRecord(string Line, string Seperator = "#//#")
{
  stClient Client;
  vector<string> vClientData;
  vClientData = SplitString(Line, Seperator);
  Client.AccountNumber = vClientData[0];
  Client.PinCode = vClientData[1];
  Client.Name = vClientData[2];
  Client.Phone = vClientData[3];
  Client.AccountBalance = stod(vClientData[4]); // cast string to double
  return Client;
}

vector<stClient> LoadClientsDataFromFile(string FileName)
{
  vector<stClient> vClients;
  fstream MyFile;
  MyFile.open(FileName, ios::in); // read Mode
  if (MyFile.is_open())
  {
    string Line;
    stClient Client;
    while (getline(MyFile, Line))
    {
      Client = ConvertLinetoRecord(Line);
      vClients.push_back(Client);
    }
    MyFile.close();
  }
  return vClients;
}

bool FetchClientByAccNum(string &AccNum, stClient &Client)
{
  vector<stClient> vClients = LoadClientsDataFromFile(ClientsFileName);

  for (stClient &C : vClients)
  {
    if (C.AccountNumber == AccNum)
    {
      Client = C;
      return 1;
    }
  }
  return 0;
}

stClient ReadNewClient()
{
  stClient Client;
  cout << "Enter Account Number? ";
  getline(cin >> ws, Client.AccountNumber); // Using ws to handle whitespace
  while (FetchClientByAccNum(Client.AccountNumber, Client))
  {
    cout << "Client with Account Number (" << Client.AccountNumber << ") is already exist!\n";
    cout << "Please try again with a different Account Number: ";
    Client.AccountNumber = ReadClientAccountNumber();
  }
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

void PrintClientCard(stClient &Client)
{
  cout << "\nThe following are the client details:\n";
  cout << "\nAccout Number: " << Client.AccountNumber;
  cout << "\nPin Code : " << Client.PinCode;
  cout << "\nName : " << Client.Name;
  cout << "\nPhone : " << Client.Phone;
  cout << "\nAccount Balance: " << Client.AccountBalance << endl;
}

string ConvertRecordToLine(const stClient &Client, string Seperator = "#//#")
{
  string ClientRecordLine = "";
  ClientRecordLine += Client.AccountNumber + Seperator;
  ClientRecordLine += Client.PinCode + Seperator;
  ClientRecordLine += Client.Name + Seperator;
  ClientRecordLine += Client.Phone + Seperator;
  ClientRecordLine += to_string(Client.AccountBalance);
  return ClientRecordLine;
}

void RewriteDataLineToFile(const string &FileName, const string &stDataLine)
{
  fstream MyFile;
  MyFile.open(FileName, ios::out);
  if (MyFile.is_open())
  {
    MyFile << stDataLine << endl;
    MyFile.close();
  }
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
  stClient Client = ReadNewClient();
  AddDataLineToFile(ClientsFileName, ConvertRecordToLine(Client));
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

void DeleteClientByAccountNumber(string AccountNumberToDelete, stClient &Client)
{
  char Choice;
  vector<stClient> vClients = LoadClientsDataFromFile(ClientsFileName);
  bool Flag = true;

  if (!FetchClientByAccNum(AccountNumberToDelete, Client))
  {
    cout << "Client with Account Number (" << AccountNumberToDelete << ") is Not Found!";
    return;
  }
  PrintClientCard(Client);
  cout << "Do you want to delete it? (Y/N): ";
  cin >> Choice;
  cin.ignore();
  if (Choice == 'Y' || Choice == 'y')
  {
    for (stClient c : vClients)
    {
      if (c.AccountNumber == AccountNumberToDelete)
      {
        continue;
      }
      if (Flag)
      {
        RewriteDataLineToFile(ClientsFileName, ConvertRecordToLine(c));
        Flag = false;
      }
      else
      {
        AddDataLineToFile(ClientsFileName, ConvertRecordToLine(c));
      }
    }
    cout << "Client with Account Number (" << AccountNumberToDelete << ") is Deleted!\n";
  }
  else
  {
    cout << "Aborting ! Client with Account Number (" << AccountNumberToDelete << ") is Not Deleted!\n";
  }
}

stClient UpdateClientPrompt(string &AccNum)
{
  stClient UpdatedClient;
  UpdatedClient.AccountNumber = AccNum;
  cout << "Enter The New PinCode? ";
  getline(cin, UpdatedClient.PinCode);
  cout << "Enter The New Name? ";
  getline(cin, UpdatedClient.Name);
  cout << "Enter The New Phone? ";
  getline(cin, UpdatedClient.Phone);
  cout << "Enter AccountBalance? ";
  cin >> UpdatedClient.AccountBalance;
  cin.ignore(); // Clear input buffer
  return UpdatedClient;
}

vector<stClient> SaveClientsDataToFile(string FileName, vector<stClient> vClients)
{
  fstream MyFile;
  MyFile.open(FileName, ios::out);
  string DataLine;
  if (MyFile.is_open())
  {
    for (stClient &C : vClients)
    {
      DataLine = ConvertRecordToLine(C);
      MyFile << DataLine << endl;
    }
    MyFile.close();
  }
  return vClients;
}

bool UpdateClientByAccountNumber(string AccountNumber, vector<stClient> &vClients)
{
  stClient Client;
  char Answer = 'n';
  if (FetchClientByAccNum(AccountNumber, Client))
  {
    PrintClientCard(Client);
    cout << "\n\nAre you sure you want update this client? y/n ? ";
    cin >> Answer;
    cin.ignore(); // Clear input buffer
    if (Answer == 'y' || Answer == 'Y')
    {
      for (stClient &C : vClients)
      {
        if (C.AccountNumber == AccountNumber)
        {
          C = UpdateClientPrompt(AccountNumber);
          break;
        }
      }
      SaveClientsDataToFile(ClientsFileName, vClients);
      cout << "\n\nClient Updated Successfully.\n";
      return true;
    }
  }
  else
  {
    cout << "\nClient with Account Number (" << AccountNumber << ") is Not Found!\n";
    return false;
  }
  return true;
}

void PrintClientRecord(stClient Client)
{
  cout << "| " << setw(15) << left << Client.AccountNumber;
  cout << "| " << setw(10) << left << Client.PinCode;
  cout << "| " << setw(40) << left << Client.Name;
  cout << "| " << setw(12) << left << Client.Phone;
  cout << "| " << setw(12) << left << Client.AccountBalance;
}

void PrintAllClientsData(vector<stClient> vClients)
{
  cout << "\n\t\t\t\t\tClient List (" << vClients.size() << ") Client(s).";
  cout << "\n_______________________________________________________";
  cout << "_________________________________________\n"
       << endl;
  cout << "| " << left << setw(15) << "Account Number";
  cout << "| " << left << setw(10) << "Pin Code";
  cout << "| " << left << setw(40) << "Client Name";
  cout << "| " << left << setw(12) << "Phone";
  cout << "| " << left << setw(12) << "Balance";
  cout << "\n_______________________________________________________";
  cout << "_________________________________________\n"
       << endl;
  for (stClient Client : vClients)
  {
    PrintClientRecord(Client);
    cout << endl;
  }
  cout << "\n_______________________________________________________";
  cout << "_________________________________________\n"
       << endl;
}

void PrintAllClientsBalances(vector<stClient> vClients)
{
  cout << "\n\t\t\t\t\tClient List (" << vClients.size() << ") Client(s).";
  cout << "\n_______________________________________________________";
  cout << "_________________________________________\n"
       << endl;
  cout << "| " << left << setw(15) << "Account Number";
  cout << "| " << left << setw(40) << "Client Name";
  cout << "| " << left << setw(12) << "Balance";
  cout << "\n_______________________________________________________";
  cout << "_________________________________________\n"
       << endl;
  for (stClient Client : vClients)
  {
    PrintClientRecord(Client);
    cout << endl;
  }
  cout << "\n_______________________________________________________";
  cout << "_________________________________________\n"
       << endl;
}

short DisplayMainMenu()
{
  short Choice;
  cout << endl;
  PrintEqualSigns(30);
  cout << "\n\t   Main Menu\n";
  PrintEqualSigns(30);
  cout << endl;
  cout << "\t 1. Show Client List.\n";
  cout << "\t 2. Add New Client.\n";
  cout << "\t 3. Delete Client.\n";
  cout << "\t 4. Update Client Details.\n";
  cout << "\t 5. Find Client Details.\n";
  cout << "\t 6. Transacitons Menu.\n";
  cout << "\t 7. Exit\n";
  PrintEqualSigns(30);
  cout << endl;
  cout << "Enter Your Choice: ";
  cin >> Choice;
  cin.ignore();
  return Choice;
}

short DisplayTransactionsScreen()
{
  short Choice;
  cout << endl;
  PrintEqualSigns(30);
  cout << "\n\t   Transactions Menu\n";
  PrintEqualSigns(30);
  cout << endl;
  cout << "\t 1. Deposit.\n";
  cout << "\t 2. Withdraw.\n";
  cout << "\t 3. Total Balances.\n";
  cout << "\t 4. Main Menu.\n";
  PrintEqualSigns(30);
  cout << endl;
  cout << "Enter Your Choice: ";
  cin >> Choice;
  cin.ignore();
  return Choice;
}

void Deposit()
{
  // Intailizing the variables.
  char Choice;
  double Amount;
  stClient Client;
  vector<stClient> vClients = LoadClientsDataFromFile(ClientsFileName);
  string AccountNumber = ReadClientAccountNumber();

  // Validating the Account Number.
  while(!FetchClientByAccNum(AccountNumber, Client))
  {
    cout << "Client with Account Number (" << AccountNumber << ") is Not Found!";
    AccountNumber = ReadClientAccountNumber();
  }
  PrintClientCard(Client);
  // Depositing code.
  cout << "Enter the amount to deposit: ";
  cin >> Amount;
  cin.ignore();
  cout << "Are you sure you want to deposit " << Amount << " to the account? (Y/N): ";
  cin >> Choice;
  if (Choice == 'Y' || Choice == 'y')
  {
    Client.AccountBalance += Amount;
    // Update the client in the vector and save the updated vector to the file.
    for (stClient &C : vClients)
    {
      if (C.AccountNumber == Client.AccountNumber)
      {
        C.AccountBalance = Client.AccountBalance;
        break;
      }
    }
    SaveClientsDataToFile(ClientsFileName, vClients);
    cout << "Deposit of " << Amount << " is done successfully.\n";
    cout << "The new balance is: " << Client.AccountBalance << endl;
  }
  else
  {
    cout << "Deposit is aborted!\n";
  }
}

void Withdraw()
{
  // Intailizing the variables.
  char Choice;
  double Amount;
  stClient Client;
  vector<stClient> vClients = LoadClientsDataFromFile(ClientsFileName);
  string AccountNumber = ReadClientAccountNumber();

  // Validating the Account Number.
  while(!FetchClientByAccNum(AccountNumber, Client))
  {
    cout << "Client with Account Number (" << AccountNumber << ") is Not Found!";
    AccountNumber = ReadClientAccountNumber();
  }
  PrintClientCard(Client);
  // withdrawing code.
  cout << "Enter the amount to withdraw: ";
  cin >> Amount;
  cin.ignore();
  if (Amount > Client.AccountBalance)
  {
    cout << "Sorry balanace is insuffcient, your balance is: "  << Client.AccountBalance << endl;
    return;
  }
  cout << "Are you sure you want to withdraw " << Amount << " to the account? (Y/N): ";
  cin >> Choice;
  if (Choice == 'Y' || Choice == 'y')
  {
    Client.AccountBalance -= Amount;
    // Update the client in the vector and save the updated vector to the file.
    for (stClient &C : vClients)
    {
      if (C.AccountNumber == Client.AccountNumber)
      {
        C.AccountBalance = Client.AccountBalance;
        break;
      }
    }
    SaveClientsDataToFile(ClientsFileName, vClients);
    cout << "withdraw of " << Amount << " is done successfully.\n";
    cout << "The new balance is: " << Client.AccountBalance << endl;
  }
  else
  {
    cout << "withdraw is aborted!\n";
  }
}

void PrintTotalBalances()
{
  vector<stClient> vClients = LoadClientsDataFromFile(ClientsFileName);
  PrintAllClientsBalances(vClients);
  double TotalBalance = 0;
  for (stClient &Client : vClients)
  {
    TotalBalance += Client.AccountBalance;
  }
  cout << "The total balance of all clients is: " << TotalBalance << endl;
}

void GoBackToTransactionsMenu();
void HandlingTransactionsMenu(short Choice)
{
  switch (Choice)
  {
  case 1:
  {
    Deposit();
    GoBackToTransactionsMenu();
    break;
  }
  case 2:
  {
    Withdraw();
    GoBackToTransactionsMenu();
    break;
  }
  case 3:
  {
    PrintTotalBalances();
    GoBackToTransactionsMenu();
    break;
  }
  case 4:
  {
    cout << "Returning to the Main Menu.\n";
    break;
  }
  }
}

void HandlingMainMenu(short Choice);
void GoBackToMainMenu()
{
  cout << "\n\nPress any key to go back to Main Menue...";
  cin.get();
  HandlingMainMenu(DisplayMainMenu());
}

void GoBackToTransactionsMenu()
{
  cout << "\n\nPress any key to go back to Transactions Menu...";
  cin.get();
  HandlingTransactionsMenu(DisplayTransactionsScreen());
}

void HandlingMainMenu(short Choice)
{
  vector<stClient> vClients = LoadClientsDataFromFile(ClientsFileName);
  switch (Choice)
  {
  case 1:
  {
    PrintAllClientsData(vClients);
    GoBackToMainMenu();
    break;
  }
  case 2:
  {
    AddClients();
    GoBackToMainMenu();
    break;
  }
  case 3:
  {
    stClient Client;
    string AccountNumberToDelete = ReadClientAccountNumber();
    DeleteClientByAccountNumber(AccountNumberToDelete, Client);
    GoBackToMainMenu();
    break;
  }
  case 4:
  {
    string AccountNumberToUpdate = ReadClientAccountNumber();
    UpdateClientByAccountNumber(AccountNumberToUpdate, vClients);
    GoBackToMainMenu();
    break;
  }
  case 5:
  {
    stClient Client;
    string AccountNumberToFind = ReadClientAccountNumber();
    FetchClientByAccNum(AccountNumberToFind, Client);
    PrintClientCard(Client);
    GoBackToMainMenu();
    break;
  }
  case 6:
  {
    HandlingTransactionsMenu(DisplayTransactionsScreen());
    HandlingMainMenu(DisplayMainMenu());
    break;
  }
  case 7:
  {
    cout << "Good Bye!\n";
    break;
  }
  }
}


int main()
{
  HandlingMainMenu(DisplayMainMenu());  
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


void ShowMainMenue();
void ShowTransactionsMenue();

struct sClient
{
    string AccountNumber;
    string PinCode;
    string Name;
    string Phone;
    double AccountBalance;
    bool MarkForDelete = false;


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

        S1.erase(0, pos + Delim.length());  // erase() until positon and move to next word.
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

string ConvertRecordToLine(sClient Client, string Seperator = "#//#")
{

  string stClientRecord = "";

  stClientRecord += Client.AccountNumber + Seperator;
  stClientRecord += Client.PinCode + Seperator;
  stClientRecord += Client.Name + Seperator;
  stClientRecord += Client.Phone + Seperator;
  stClientRecord += to_string(Client.AccountBalance);

  return stClientRecord;
}

bool ClientExistsByAccountNumber(string AccountNumber, string FileName)
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
      if (Client.AccountNumber == AccountNumber)
      {
        MyFile.close();
        return true;
      }

      vClients.push_back(Client);
    }

    MyFile.close();
  }

  return false;
}

sClient ReadNewClient()
{
  sClient Client;

  cout << "Enter Account Number? ";

  // Usage of std::ws will extract allthe whitespace character
  getline(cin >> ws, Client.AccountNumber);

  while (ClientExistsByAccountNumber(Client.AccountNumber, ClientsFileName))
  {
    cout << "\nClient with [" << Client.AccountNumber << "] already exists, Enter another Account Number? ";
    getline(cin >> ws, Client.AccountNumber);
  }

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

vector<sClient> LoadCleintsDataFromFile(string FileName)
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

void PrintClientRecordLine(sClient Client)
{

  cout << "| " << setw(15) << left << Client.AccountNumber;
  cout << "| " << setw(10) << left << Client.PinCode;
  cout << "| " << setw(40) << left << Client.Name;
  cout << "| " << setw(12) << left << Client.Phone;
  cout << "| " << setw(12) << left << Client.AccountBalance;
}

void PrintClientRecordBalanceLine(sClient Client)
{

  cout << "| " << setw(15) << left << Client.AccountNumber;
  cout << "| " << setw(40) << left << Client.Name;
  cout << "| " << setw(12) << left << Client.AccountBalance;
}

void ShowAllClientsScreen()
{

  vector<sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);

  cout << "\n\t\t\t\t\tClient List (" << vClients.size() << ") Client(s).";
  cout << "\n_______________________________________________________";
  cout << "_________________________________________\n"
       << endl;

  cout << "| " << left << setw(15) << "Accout Number";
  cout << "| " << left << setw(10) << "Pin Code";
  cout << "| " << left << setw(40) << "Client Name";
  cout << "| " << left << setw(12) << "Phone";
  cout << "| " << left << setw(12) << "Balance";
  cout << "\n_______________________________________________________";
  cout << "_________________________________________\n"
       << endl;

  if (vClients.size() == 0)
    cout << "\t\t\t\tNo Clients Available In the System!";
  else

    for (sClient Client : vClients)
    {

      PrintClientRecordLine(Client);
      cout << endl;
    }

  cout << "\n_______________________________________________________";
  cout << "_________________________________________\n"
       << endl;
}

void ShowTotalBalances()
{

  vector<sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);

  cout << "\n\t\t\t\t\tBalances List (" << vClients.size() << ") Client(s).";
  cout << "\n_______________________________________________________";
  cout << "_________________________________________\n"
       << endl;

  cout << "| " << left << setw(15) << "Accout Number";
  cout << "| " << left << setw(40) << "Client Name";
  cout << "| " << left << setw(12) << "Balance";
  cout << "\n_______________________________________________________";
  cout << "_________________________________________\n"
       << endl;

  double TotalBalances = 0;

  if (vClients.size() == 0)
    cout << "\t\t\t\tNo Clients Available In the System!";
  else

    for (sClient Client : vClients)
    {

      PrintClientRecordBalanceLine(Client);
      TotalBalances += Client.AccountBalance;

      cout << endl;
    }

  cout << "\n_______________________________________________________";
  cout << "_________________________________________\n"
       << endl;
  cout << "\t\t\t\t\t   Total Balances = " << TotalBalances;
}

void PrintClientCard(sClient Client)
{
  cout << "\nThe following are the client details:\n";
  cout << "-----------------------------------";
  cout << "\nAccout Number: " << Client.AccountNumber;
  cout << "\nPin Code     : " << Client.PinCode;
  cout << "\nName         : " << Client.Name;
  cout << "\nPhone        : " << Client.Phone;
  cout << "\nAccount Balance: " << Client.AccountBalance;
  cout << "\n-----------------------------------\n";
}

bool FindClientByAccountNumber(string AccountNumber, vector<sClient> vClients, sClient &Client)
{

  for (sClient C : vClients)
  {

    if (C.AccountNumber == AccountNumber)
    {
      Client = C;
      return true;
    }
  }
  return false;
}

sClient ChangeClientRecord(string AccountNumber)
{
  sClient Client;

  Client.AccountNumber = AccountNumber;

  cout << "\n\nEnter PinCode? ";
  getline(cin >> ws, Client.PinCode);

  cout << "Enter Name? ";
  getline(cin, Client.Name);

  cout << "Enter Phone? ";
  getline(cin, Client.Phone);

  cout << "Enter AccountBalance? ";
  cin >> Client.AccountBalance;

  return Client;
}

bool MarkClientForDeleteByAccountNumber(string AccountNumber, vector<sClient> &vClients)
{

  for (sClient &C : vClients)
  {

    if (C.AccountNumber == AccountNumber)
    {
      C.MarkForDelete = true;
      return true;
    }
  }

  return false;
}

vector<sClient> SaveCleintsDataToFile(string FileName, vector<sClient> vClients)
{

  fstream MyFile;
  MyFile.open(FileName, ios::out); // overwrite

  string DataLine;

  if (MyFile.is_open())
  {

    for (sClient C : vClients)
    {

      if (C.MarkForDelete == false)
      {
        // we only write records that are not marked for delete.
        DataLine = ConvertRecordToLine(C);
        MyFile << DataLine << endl;
      }
    }

    MyFile.close();
  }

  return vClients;
}

void AddDataLineToFile(string FileName, string stDataLine)
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
  sClient Client;
  Client = ReadNewClient();
  AddDataLineToFile(ClientsFileName, ConvertRecordToLine(Client));
}

void AddNewClients()
{
  char AddMore = 'Y';
  do
  {
    // system("cls");
    cout << "Adding New Client:\n\n";

    AddNewClient();
    cout << "\nClient Added Successfully, do you want to add more clients? Y/N? ";

    cin >> AddMore;

  } while (toupper(AddMore) == 'Y');
}

bool DeleteClientByAccountNumber(string AccountNumber, vector<sClient> &vClients)
{

  sClient Client;
  char Answer = 'n';

  if (FindClientByAccountNumber(AccountNumber, vClients, Client))
  {

    PrintClientCard(Client);

    cout << "\n\nAre you sure you want delete this client? y/n ? ";
    cin >> Answer;
    if (Answer == 'y' || Answer == 'Y')
    {
      MarkClientForDeleteByAccountNumber(AccountNumber, vClients);
      SaveCleintsDataToFile(ClientsFileName, vClients);

      // Refresh Clients
      vClients = LoadCleintsDataFromFile(ClientsFileName);

      cout << "\n\nClient Deleted Successfully.";
      return true;
    }
  }
  else
  {
    cout << "\nClient with Account Number (" << AccountNumber << ") is Not Found!";
    return false;
  }
}

bool UpdateClientByAccountNumber(string AccountNumber, vector<sClient> &vClients)
{

  sClient Client;
  char Answer = 'n';

  if (FindClientByAccountNumber(AccountNumber, vClients, Client))
  {

    PrintClientCard(Client);
    cout << "\n\nAre you sure you want update this client? y/n ? ";
    cin >> Answer;
    if (Answer == 'y' || Answer == 'Y')
    {

      for (sClient &C : vClients)
      {
        if (C.AccountNumber == AccountNumber)
        {
          C = ChangeClientRecord(AccountNumber);
          break;
        }
      }

      SaveCleintsDataToFile(ClientsFileName, vClients);

      cout << "\n\nClient Updated Successfully.";
      return true;
    }
  }
  else
  {
    cout << "\nClient with Account Number (" << AccountNumber << ") is Not Found!";
    return false;
  }
}

bool DepositBalanceToClientByAccountNumber(string AccountNumber, double Amount, vector<sClient> &vClients)
{

  char Answer = 'n';

  cout << "\n\nAre you sure you want perfrom this transaction? y/n ? ";
  cin >> Answer;
  if (Answer == 'y' || Answer == 'Y')
  {

    for (sClient &C : vClients)
    {
      if (C.AccountNumber == AccountNumber)
      {
        C.AccountBalance += Amount;
        SaveCleintsDataToFile(ClientsFileName, vClients);
        cout << "\n\nDone Successfully. New balance is: " << C.AccountBalance;

        return true;
      }
    }

    return false;
  }
}

string ReadClientAccountNumber()
{
  string AccountNumber = "";

  cout << "\nPlease enter AccountNumber? ";
  cin >> AccountNumber;
  return AccountNumber;
}

void ShowDeleteClientScreen()
{
  cout << "\n-----------------------------------\n";
  cout << "\tDelete Client Screen";
  cout << "\n-----------------------------------\n";

  vector<sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
  string AccountNumber = ReadClientAccountNumber();
  DeleteClientByAccountNumber(AccountNumber, vClients);
}

void ShowUpdateClientScreen()
{
  cout << "\n-----------------------------------\n";
  cout << "\tUpdate Client Info Screen";
  cout << "\n-----------------------------------\n";

  vector<sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
  string AccountNumber = ReadClientAccountNumber();
  UpdateClientByAccountNumber(AccountNumber, vClients);
}

void ShowAddNewClientsScreen()
{
  cout << "\n-----------------------------------\n";
  cout << "\tAdd New Clients Screen";
  cout << "\n-----------------------------------\n";

  AddNewClients();
}

void ShowFindClientScreen()
{
  cout << "\n-----------------------------------\n";
  cout << "\tFind Client Screen";
  cout << "\n-----------------------------------\n";

  vector<sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
  sClient Client;
  string AccountNumber = ReadClientAccountNumber();
  if (FindClientByAccountNumber(AccountNumber, vClients, Client))
    PrintClientCard(Client);
  else
    cout << "\nClient with Account Number[" << AccountNumber << "] is not found!";
}

void ShowEndScreen()
{
  cout << "\n-----------------------------------\n";
  cout << "\tProgram Ends :-)";
  cout << "\n-----------------------------------\n";
}

void ShowDepositScreen()
{
  cout << "\n-----------------------------------\n";
  cout << "\tDeposit Screen";
  cout << "\n-----------------------------------\n";

  sClient Client;

  vector<sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
  string AccountNumber = ReadClientAccountNumber();

  while (!FindClientByAccountNumber(AccountNumber, vClients, Client))
  {
    cout << "\nClient with [" << AccountNumber << "] does not exist.\n";
    AccountNumber = ReadClientAccountNumber();
  }

  PrintClientCard(Client);

  double Amount = 0;
  cout << "\nPlease enter deposit amount? ";
  cin >> Amount;

  DepositBalanceToClientByAccountNumber(AccountNumber, Amount, vClients);
}

void ShowWithDrawScreen()
{
  cout << "\n-----------------------------------\n";
  cout << "\tWithdraw Screen";
  cout << "\n-----------------------------------\n";

  sClient Client;

  vector<sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
  string AccountNumber = ReadClientAccountNumber();

  while (!FindClientByAccountNumber(AccountNumber, vClients, Client))
  {
    cout << "\nClient with [" << AccountNumber << "] does not exist.\n";
    AccountNumber = ReadClientAccountNumber();
  }

  PrintClientCard(Client);

  double Amount = 0;
  cout << "\nPlease enter withdraw amount? ";
  cin >> Amount;

  // Validate that the amount does not exceeds the balance
  while (Amount > Client.AccountBalance)
  {
    cout << "\nAmount Exceeds the balance, you can withdraw up to : " << Client.AccountBalance << endl;
    cout << "Please enter another amount? ";
    cin >> Amount;
  }

  DepositBalanceToClientByAccountNumber(AccountNumber, Amount * -1, vClients);
}

void ShowTotalBalancesScreen()
{

  ShowTotalBalances();
}

enum enTransactionsMenueOptions
{
  eDeposit = 1,
  eWithdraw = 2,
  eShowTotalBalance = 3,
  eShowMainMenue = 4
};

enum enMainMenueOptions
{
  eListClients = 1,
  eAddNewClient = 2,
  eDeleteClient = 3,
  eUpdateClient = 4,
  eFindClient = 5,
  eShowTransactionsMenue = 6,
  eExit = 7
};

void GoBackToMainMenue()
{
  cout << "\n\nPress any key to go back to Main Menue...";
  system("pause>0");
  ShowMainMenue();
}
void GoBackToTransactionsMenue()
{
  cout << "\n\nPress any key to go back to Transactions Menue...";
  system("pause>0");
  ShowTransactionsMenue();
}
short ReadTransactionsMenueOption()
{
  cout << "Choose what do you want to do? [1 to 4]? ";
  short Choice = 0;
  cin >> Choice;

  return Choice;
}

void PerfromTranactionsMenueOption(enTransactionsMenueOptions TransactionMenueOption)
{
  switch (TransactionMenueOption)
  {
  case enTransactionsMenueOptions::eDeposit:
  {
    system("cls");
    ShowDepositScreen();
    GoBackToTransactionsMenue();
    break;
  }

  case enTransactionsMenueOptions::eWithdraw:
  {
    system("cls");
    ShowWithDrawScreen();
    GoBackToTransactionsMenue();
    break;
  }

  case enTransactionsMenueOptions::eShowTotalBalance:
  {
    system("cls");
    ShowTotalBalancesScreen();
    GoBackToTransactionsMenue();
    break;
  }

  case enTransactionsMenueOptions::eShowMainMenue:
  {

    ShowMainMenue();
  }
  }
}

void ShowTransactionsMenue()
{
  system("cls");
  cout << "===========================================\n";
  cout << "\t\tTransactions Menue Screen\n";
  cout << "===========================================\n";
  cout << "\t[1] Deposit.\n";
  cout << "\t[2] Withdraw.\n";
  cout << "\t[3] Total Balances.\n";
  cout << "\t[4] Main Menue.\n";
  cout << "===========================================\n";
  PerfromTranactionsMenueOption((enTransactionsMenueOptions)ReadTransactionsMenueOption());
}

short ReadMainMenueOption()
{
  cout << "Choose what do you want to do? [1 to 7]? ";
  short Choice = 0;
  cin >> Choice;

  return Choice;
}

void PerfromMainMenueOption(enMainMenueOptions MainMenueOption)
{
  switch (MainMenueOption)
  {
  case enMainMenueOptions::eListClients:
  {
    system("cls");
    ShowAllClientsScreen();
    GoBackToMainMenue();
    break;
  }
  case enMainMenueOptions::eAddNewClient:
    system("cls");
    ShowAddNewClientsScreen();
    GoBackToMainMenue();
    break;

  case enMainMenueOptions::eDeleteClient:
    system("cls");
    ShowDeleteClientScreen();
    GoBackToMainMenue();
    break;

  case enMainMenueOptions::eUpdateClient:
    system("cls");
    ShowUpdateClientScreen();
    GoBackToMainMenue();
    break;

  case enMainMenueOptions::eFindClient:
    system("cls");
    ShowFindClientScreen();
    GoBackToMainMenue();
    break;

  case enMainMenueOptions::eShowTransactionsMenue:
    system("cls");
    ShowTransactionsMenue();
    break;

  case enMainMenueOptions::eExit:
    system("cls");
    ShowEndScreen();
    break;
  }
}

void ShowMainMenue()
{
  system("cls");
  cout << "===========================================\n";
  cout << "\t\tMain Menue Screen\n";
  cout << "===========================================\n";
  cout << "\t[1] Show Client List.\n";
  cout << "\t[2] Add New Client.\n";
  cout << "\t[3] Delete Client.\n";
  cout << "\t[4] Update Client Info.\n";
  cout << "\t[5] Find Client.\n";
  cout << "\t[6] Transactions.\n";
  cout << "\t[7] Exit.\n";
  cout << "===========================================\n";
  PerfromMainMenueOption((enMainMenueOptions)ReadMainMenueOption());
}

int main()

{
  ShowMainMenue();
  system("pause>0");
  return 0;
}

*/