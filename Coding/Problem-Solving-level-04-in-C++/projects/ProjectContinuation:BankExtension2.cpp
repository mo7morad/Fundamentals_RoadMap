#include <iostream>
#include <cstdlib>
#include <fstream>
#include <string>
#include <vector>
#include <iomanip>
#include <limits>
using namespace std;

const string ClientsFileName = "clients.txt";
const string UsersFileName = "users.txt";

struct stUser
{
  string UserName, Password;
  short Permissions;
};
static stUser UsedUser;

struct stClient
{
  string AccountNumber;
  string PinCode;
  string Name;
  string Phone;
  double AccountBalance;
};

enum enPermissions
{
  None = 0,                 // 00000000
  ShowClientsList = 1 << 0, // 00000001
  AddClient = 1 << 1,       // 00000010
  DeleteClient = 1 << 2,    // 00000100
  UpdateClient = 1 << 3,    // 00001000
  FindClient = 1 << 4,      // 00010000
  Transactions = 1 << 5,    // 00100000
  ManageUsers = 1 << 6,     // 01000000
  AllPermissions = ~0       // 11111111 (enables all bits)
};

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

string ReadUserName()
{
  string UserName = "";
  cout << "\nPlease enter User Name? ";
  getline(cin, UserName);
  return UserName;
}

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

stClient ConvertLinetoClientRecord(string Line, string Seperator = "#//#")
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

stUser ConvertLinetoUserRecord(string Line, string Seperator = "#//#")
{
  stUser User;
  vector<string> vUsersData;
  vUsersData = SplitString(Line, Seperator);
  User.UserName = vUsersData[0];
  User.Password = vUsersData[1];
  User.Permissions = stoi(vUsersData[2]);
  return User;
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
      Client = ConvertLinetoClientRecord(Line);
      vClients.push_back(Client);
    }
    MyFile.close();
  }
  return vClients;
}

vector<stUser> LoadUsersDataFromFile(string FileName)
{
  vector<stUser> vUsers;
  fstream MyFile;
  MyFile.open(FileName, ios::in); // read Mode
  if (MyFile.is_open())
  {
    string Line;
    stUser User;
    while (getline(MyFile, Line))
    {
      User = ConvertLinetoUserRecord(Line);
      vUsers.push_back(User);
    }
    MyFile.close();
  }
  return vUsers;
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

bool FetchUserByUserName(string &UserName, stUser &User)
{
  vector<stUser> vUsers = LoadUsersDataFromFile(UsersFileName);

  for (stUser &U : vUsers)
  {
    if (U.UserName == UserName)
    {
      User = U;
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

enPermissions ReadUserPermissions()
{
  short Permissions = 0;
  char Answer = 'n';

  // Check for all permissions
  cout << "\nDo you want to give the user All Permissions? (y/n): ";
  cin >> Answer;
  if (tolower(Answer) == 'y')
  {
    return enPermissions::AllPermissions;
  }

  // Array of permission names and values
  struct PermissionInfo
  {
    string Name;
    enPermissions Value;
  };

  PermissionInfo permissionList[] = {
      {"Show Clients List", enPermissions::ShowClientsList},
      {"Add New Client", enPermissions::AddClient},
      {"Delete Client", enPermissions::DeleteClient},
      {"Update Client", enPermissions::UpdateClient},
      {"Find Client", enPermissions::FindClient},
      {"Transactions", enPermissions::Transactions},
      {"Manage Users", enPermissions::ManageUsers},
  };

  for (const auto &perm : permissionList)
  {
    cout << "\nDo you want to give the user the permission to " << perm.Name << "? (y/n): ";
    cin >> Answer;
    if (tolower(Answer) == 'y')
    {
      Permissions |= perm.Value;
    }
  }

  return static_cast<enPermissions>(Permissions);
}

stUser ReadNewUser()
{
  stUser User;
  User.UserName = ReadUserName();
  while (FetchUserByUserName(User.UserName, User))
  {
    cout << "User with user name:  (" << User.UserName << ") is already exist!\n";
    cout << "Please try again with a different user name: ";
    User.UserName = ReadUserName();
  }

  cout << "Enter Password: ";
  getline(cin, User.Password);
  User.Permissions = ReadUserPermissions();

  cin.ignore(numeric_limits<streamsize>::max(), '\n'); // Clear the input buffer
  return User;
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

void PrintUserCard(stUser &User)
{
  cout << "\nThe following are the user details:\n";
  cout << "\nUser Name: " << User.UserName;
  cout << "\nPassword : " << User.Password;
  cout << "\nPermissions : " << User.Permissions << endl;
}

string ConvertClientRecordToLine(const stClient &Client, string Seperator = "#//#")
{
  string ClientRecordLine = "";
  ClientRecordLine += Client.AccountNumber + Seperator;
  ClientRecordLine += Client.PinCode + Seperator;
  ClientRecordLine += Client.Name + Seperator;
  ClientRecordLine += Client.Phone + Seperator;
  ClientRecordLine += to_string(Client.AccountBalance);
  return ClientRecordLine;
}

string ConvertUserRecordToLine(const stUser &User, string Seperator = "#//#")
{
  string UserDataLine = "";
  UserDataLine += User.UserName + Seperator;
  UserDataLine += User.Password + Seperator;
  UserDataLine += to_string(User.Permissions);
  return UserDataLine;
}

void RewriteClientDataLineToFile(const string &FileName, const string &stDataLine)
{
  fstream MyFile;
  MyFile.open(FileName, ios::out);
  if (MyFile.is_open())
  {
    MyFile << stDataLine << endl;
    MyFile.close();
  }
}

void RewriteUserDataLineToFile(const string &FileName, const string &stDataLine)
{
  fstream MyFile;
  MyFile.open(FileName, ios::out);
  if (MyFile.is_open())
  {
    MyFile << stDataLine << endl;
    MyFile.close();
  }
}

void AddClientDataLineToFile(const string &FileName, const string &stDataLine)
{
  fstream MyFile;
  MyFile.open(FileName, ios::out | ios::app);
  if (MyFile.is_open())
  {
    MyFile << stDataLine << endl;
    MyFile.close();
  }
}

void AddUserDataLineToFile(const string &FileName, const string &stDataLine)
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
  AddClientDataLineToFile(ClientsFileName, ConvertClientRecordToLine(Client));
}

void AddNewUser()
{
  stUser User = ReadNewUser();
  AddUserDataLineToFile(UsersFileName, ConvertUserRecordToLine(User));
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

void AddUsers()
{
  char AddMore = 'Y';
  do
  {
    cout << "Adding New user:\n\n";
    AddNewUser();
    cout << "\nUser Added Successfully. Do you want to add more clients? (Y/N): ";
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
        RewriteClientDataLineToFile(ClientsFileName, ConvertClientRecordToLine(c));
        Flag = false;
      }
      else
      {
        AddClientDataLineToFile(ClientsFileName, ConvertClientRecordToLine(c));
      }
    }
    cout << "Client with Account Number (" << AccountNumberToDelete << ") is Deleted!\n";
  }
  else
  {
    cout << "Aborting!\nClient with Account Number (" << AccountNumberToDelete << ") is Not Deleted!\n";
  }
}

void DeleteUserByUserName(string UserNameToDelete, stUser &User)
{
  char Choice;
  vector<stUser> vUsers = LoadUsersDataFromFile(UsersFileName);
  bool Flag = true;

  if (!FetchUserByUserName(UserNameToDelete, User))
  {
    cout << "user with user name (" << UserNameToDelete << ") is Not Found!";
    return;
  }
  PrintUserCard(User);
  cout << "Do you want to delete it? (Y/N): ";
  cin >> Choice;
  cin.ignore();
  if (tolower(Choice))
  {
    for (stUser u : vUsers)
    {
      if (u.UserName == UserNameToDelete)
      {
        continue;
      }
      if (Flag)
      {
        RewriteUserDataLineToFile(UsersFileName, ConvertUserRecordToLine(u));
        Flag = false;
      }
      else
      {
        AddUserDataLineToFile(UsersFileName, ConvertUserRecordToLine(u));
      }
    }
    cout << "user with User name (" << UserNameToDelete << ") is Deleted!\n";
  }
  else
  {
    cout << "Aborting!\nUser with user name (" << UserNameToDelete << ") is Not Deleted!\n";
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

stUser UpdateUserPrompt()
{
  stUser UpdatedUser;
  cout << "Enter The New User Name: ";
  getline(cin, UpdatedUser.UserName);
  cout << "Enter The New Password: ";
  getline(cin, UpdatedUser.Password);
  UpdatedUser.Permissions = ReadUserPermissions();
  cin.ignore(); // Clear input buffer
  return UpdatedUser;
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
      DataLine = ConvertClientRecordToLine(C);
      MyFile << DataLine << endl;
    }
    MyFile.close();
  }
  return vClients;
}

vector<stUser> SaveUsersDataToFile(string FileName, vector<stUser> vUsers)
{
  string DataLine;
  fstream MyFile;
  MyFile.open(FileName, ios::out);
  if (MyFile.is_open())
  {
    for (stUser &U : vUsers)
    {
      DataLine = ConvertUserRecordToLine(U);
      MyFile << DataLine << endl;
    }
    MyFile.close();
  }
  return vUsers;
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
    else
    {
      cout << "\n\nClient Update is Aborted!\n";
      return false;
    }
  }
  return false;
}

bool UpdateUserByUserName(string UserName, vector<stUser> &vUsers)
{
  stUser User;
  char Answer = 'n';
  if (FetchUserByUserName(UserName, User))
  {
    PrintUserCard(User);
    cout << "\n\nAre you sure you want update this user? y/n ? ";
    cin >> Answer;
    cin.ignore(); // Clear input buffer
    if (Answer == 'y' || Answer == 'Y')
    {
      for (stUser &U : vUsers)
      {
        if (U.UserName == UserName)
        {
          U = UpdateUserPrompt();
          break;
        }
      }
      SaveUsersDataToFile(UsersFileName, vUsers);
      cout << "\n\nUser Updated Successfully.\n";
      return true;
    }
    else
    {
      cout << "\n\nUser Update is Aborted!\n";
      return false;
    }
  }
  return false;
}

void PrintClientRecord(stClient Client)
{
  cout << "| " << setw(15) << left << Client.AccountNumber;
  cout << "| " << setw(10) << left << Client.PinCode;
  cout << "| " << setw(40) << left << Client.Name;
  cout << "| " << setw(12) << left << Client.Phone;
  cout << "| " << setw(12) << left << Client.AccountBalance;
}

void PrintUserRecord(stUser User)
{
  cout << "| " << setw(15) << left << User.UserName;
  cout << "| " << setw(10) << left << User.Password;
  cout << "| " << setw(40) << left << User.Permissions;
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

void PrintAllUsersData()
{
  vector<stUser> vUsers = LoadUsersDataFromFile(UsersFileName);
  cout << "\n\t\t\t\t\tUsers List (" << vUsers.size() << ") User(s).";
  cout << "\n_______________________________________________________";
  cout << "_________________________________________\n"
       << endl;
  cout << "| " << left << setw(15) << "User Name";
  cout << "| " << left << setw(10) << "Password";
  cout << "| " << left << setw(40) << "Permissions";
  cout << "\n_______________________________________________________";
  cout << "_________________________________________\n"
       << endl;
  for (stUser User : vUsers)
  {
    PrintUserRecord(User);
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
  cout << "\n\n| You are logged as: - " << UsedUser.UserName << endl;
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
  cout << "\t 7. Manage Users\n";
  cout << "\t 8. User Logout\n";
  cout << "\t 9. Exit the app\n";
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
  while (!FetchClientByAccNum(AccountNumber, Client))
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
  while (!FetchClientByAccNum(AccountNumber, Client))
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
    cout << "Sorry balanace is insuffcient, your balance is: " << Client.AccountBalance << endl;
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

void DisplayLoginScreen()
{
  cout << endl;
  PrintEqualSigns(30);
  cout << "\n\t Login Screen\n";
  PrintEqualSigns(30);
  cout << endl;
}

void HandlingLoginScreen()
{
  stUser User;
  string UserName, Password;
  cout << "\nEnter your user name: ";
  getline(cin, UserName);
  cout << "Enter your password: ";
  getline(cin, Password);
  if (FetchUserByUserName(UserName, User))
  {
    if (User.Password == Password)
    {
      UsedUser = User;
      cout << "_______________________________________";
      cout << "\n\t -- Welcome " << UserName << "! --\n";
      cout << "_______________________________________";
      HandlingMainMenu(DisplayMainMenu());
    }
    else
    {
      cout << "Invalid UserName/Password! Please try again.\n";
      HandlingLoginScreen();
    }
  }
  else
  {
    cout << "Invalid UserName/Password! Please try again.\n";
    HandlingLoginScreen();
  }
}

void DisplayMangaeUsersScreen()
{
  string UserName, Password;
  cout << "\n\n| You are logged as: - " << UsedUser.UserName << endl;
  cout << endl;
  PrintEqualSigns(30);
  cout << "\n\t Manage Users Screen\n";
  PrintEqualSigns(30);
  cout << endl;
  cout << "\t 1. Show Users List.\n";
  cout << "\t 2. Add New User.\n";
  cout << "\t 3. Delete User.\n";
  cout << "\t 4. Update User.\n";
  cout << "\t 5. Find User.\n";
  cout << "\t 6. Main Menu.\n";
  PrintEqualSigns(30);
  cout << endl;
  cout << "Enter your choice: " << endl;
}

void HandlingManageUsers();
void GoBackToMangageUsersScreen()
{
  cout << "\n\nPress any key to go back to Manage Users Menu...";
  cin.get();
  DisplayMangaeUsersScreen();
  HandlingManageUsers();
}

void HandlingManageUsers()
{
  vector<stUser> vUsers = LoadUsersDataFromFile(UsersFileName);
  short Choice;
  cout << "Choose your option: ";
  cin >> Choice;
  cin.ignore();
  switch (Choice)
  {
  case 1:
    PrintAllUsersData();
    GoBackToMangageUsersScreen();
    break;
  case 2:
    AddNewUser();
    GoBackToMangageUsersScreen();
    break;
  case 3:
  {
    stUser User;
    string UserNameToDelete = ReadUserName();
    DeleteUserByUserName(UserNameToDelete, User);
    GoBackToMangageUsersScreen();
    break;
  }
  case 4:
  {
    string UserNameToUpdate = ReadUserName();
    UpdateUserByUserName(UserNameToUpdate, vUsers);
    GoBackToMangageUsersScreen();
    break;
  }
  case 5:
  {
    stUser User;
    string UserNameToFind = ReadUserName();
    if (FetchUserByUserName(UserNameToFind, User))
      PrintUserCard(User);
    else
      cout << "User with User Name (" << UserNameToFind << ") is Not Found!";
    GoBackToMangageUsersScreen();
    break;
  }
  case 6:
  {
    HandlingMainMenu(DisplayMainMenu());
    break;
  }
  }
}

void DisplayAccessDenied()
{
  cout << "Access Denied! You don't have the permission to excute this option.\nPlease contact the admin for more acess.";
  GoBackToMainMenu();
}

void HandlingMainMenu(short Choice)
{
  vector<stClient> vClients = LoadClientsDataFromFile(ClientsFileName);
  switch (Choice)
  {
  case 1:
  {
    if (UsedUser.Permissions & enPermissions::ShowClientsList)
    {
      PrintAllClientsData(vClients);
      GoBackToMainMenu();
    }
    else
    {
      DisplayAccessDenied();
      GoBackToMainMenu();
    }
    break;
  }
  case 2:
  {
    if (UsedUser.Permissions & enPermissions::AddClient)
    {
      AddClients();
      GoBackToMainMenu();
    }
    else
    {
      DisplayAccessDenied();
      GoBackToMainMenu();
    }
    break;
  }
  case 3:
  {
    if (UsedUser.Permissions & enPermissions::DeleteClient)
    {
      stClient Client;
      string AccountNumberToDelete = ReadClientAccountNumber();
      DeleteClientByAccountNumber(AccountNumberToDelete, Client);
      GoBackToMainMenu();
    }
    else
    {
      DisplayAccessDenied();
      GoBackToMainMenu();
    }
    break;
  }
  case 4:
  {
    if (UsedUser.Permissions & enPermissions::UpdateClient)
    {
      string AccountNumberToUpdate = ReadClientAccountNumber();
      UpdateClientByAccountNumber(AccountNumberToUpdate, vClients);
      GoBackToMainMenu();
    }
    else
    {
      DisplayAccessDenied();
      GoBackToMainMenu();
    }
    break;
  }
  case 5:
  {
    if (UsedUser.Permissions & enPermissions::FindClient)
    {
      stClient Client;
      string AccountNumberToFind = ReadClientAccountNumber();
      if (FetchClientByAccNum(AccountNumberToFind, Client))
        PrintClientCard(Client);
      else
        cout << "Client with Account Number (" << AccountNumberToFind << ") is Not Found!";
      GoBackToMainMenu();
    }
    else
    {
      DisplayAccessDenied();
      GoBackToMainMenu();
    }
    break;
  }
  case 6:
  {
    if (UsedUser.Permissions & enPermissions::Transactions)
    {
      HandlingTransactionsMenu(DisplayTransactionsScreen());
      GoBackToMainMenu();
    }
    else
    {
      DisplayAccessDenied();
      GoBackToMainMenu();
    }
    break;
  }
  case 7:
  {
    if (UsedUser.Permissions & enPermissions::ManageUsers)
    {
      DisplayMangaeUsersScreen();
      HandlingManageUsers();
      GoBackToMainMenu();
    }
    else
    {
      DisplayAccessDenied();
      GoBackToMainMenu();
    }
    break;
  }
  case 8:
  {
    HandlingLoginScreen();
    break;
  }
  case 9:
  {
    cout << "Exiting the application...\nGood-Bye!" << endl;
    break;
  }
  }
}

void RunTheApp()
{
  DisplayLoginScreen();
  HandlingLoginScreen();
}

int main()
{
  RunTheApp();
  return 0;
}

// Course Code

/*



*/