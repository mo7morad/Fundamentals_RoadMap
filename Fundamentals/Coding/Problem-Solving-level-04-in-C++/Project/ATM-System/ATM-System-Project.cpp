#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <iomanip>
#include <limits>

using namespace std;

struct sClient
{
    string AccountNumber;
    string PinCode;
    string Name;
    string Phone;
    double AccountBalance;
    bool MarkForDelete = false;
};

enum enMainMenuOptions {
    eQuickWithdraw = 1, eNormalWithdraw = 2, eDeposit = 3,
    eCheckBalance = 4, eExit = 5
};

const string ClientsFileName = "clients.txt";
sClient CurrentClient;

void ShowMainMenu();
void Login();
void ShowQuickWithdrawScreen();
void ShowNormalWithdrawScreen();
void ShowDepositScreen();

vector<string> SplitString(string S1, string Delim)
{
    vector<string> vString;
    size_t pos = 0;
    string sWord;

    while ((pos = S1.find(Delim)) != string::npos)
    {
        sWord = S1.substr(0, pos);
        if (!sWord.empty())
        {
            vString.push_back(sWord);
        }
        S1.erase(0, pos + Delim.length());
    }

    if (!S1.empty())
    {
        vString.push_back(S1);
    }

    return vString;
}

sClient ConvertLineToRecord(string Line, string Separator = "#//#")
{
    sClient Client;
    vector<string> vClientData = SplitString(Line, Separator);

    Client.AccountNumber = vClientData[0];
    Client.PinCode = vClientData[1];
    Client.Name = vClientData[2];
    Client.Phone = vClientData[3];
    Client.AccountBalance = stod(vClientData[4]);

    return Client;
}

string ConvertRecordToLine(sClient Client, string Separator = "#//#")
{
    string stClientRecord = "";

    stClientRecord += Client.AccountNumber + Separator;
    stClientRecord += Client.PinCode + Separator;
    stClientRecord += Client.Name + Separator;
    stClientRecord += Client.Phone + Separator;
    stClientRecord += to_string(Client.AccountBalance);

    return stClientRecord;
}

vector<sClient> LoadClientsDataFromFile(string FileName)
{
    vector<sClient> vClients;
    fstream MyFile;
    MyFile.open(FileName, ios::in);

    if (MyFile.is_open())
    {
        string Line;
        while (getline(MyFile, Line))
        {
            sClient Client = ConvertLineToRecord(Line);
            vClients.push_back(Client);
        }
        MyFile.close();
    }

    return vClients;
}

bool FindClientByAccountNumberAndPinCode(string AccountNumber, string PinCode, sClient& Client)
{
    vector<sClient> vClients = LoadClientsDataFromFile(ClientsFileName);

    for (sClient C : vClients)
    {
        if (C.AccountNumber == AccountNumber && C.PinCode == PinCode)
        {
            Client = C;
            return true;
        }
    }
    return false;
}

vector<sClient> SaveClientsDataToFile(string FileName, vector<sClient> vClients)
{
    fstream MyFile;
    MyFile.open(FileName, ios::out);

    if (MyFile.is_open())
    {
        for (sClient C : vClients)
        {
            if (!C.MarkForDelete)
            {
                string DataLine = ConvertRecordToLine(C);
                MyFile << DataLine << endl;
            }
        }
        MyFile.close();
    }

    return vClients;
}

bool DepositBalanceToClientByAccountNumber(string AccountNumber, double Amount, vector<sClient>& vClients)
{
    char Answer = 'n';

    cout << "\n\nAre you sure you want to perform this transaction? y/n ? ";
    cin >> Answer;
    cin.ignore(numeric_limits<streamsize>::max(), '\n'); // Clear the input buffer

    if (Answer == 'y' || Answer == 'Y')
    {
        for (sClient& C : vClients)
        {
            if (C.AccountNumber == AccountNumber)
            {
                C.AccountBalance += Amount;
                SaveClientsDataToFile(ClientsFileName, vClients);
                cout << "\n\nDone Successfully. New balance is: " << C.AccountBalance;
                return true;
            }
        }
    }
    return false;
}

short ReadQuickWithdrawOption()
{
    short Choice = 0;
    while (Choice < 1 || Choice > 9)
    {
        cout << "\nChoose what to do from [1] to [9] ? ";
        cin >> Choice;
        cin.ignore(numeric_limits<streamsize>::max(), '\n'); // Clear the input buffer
    }

    return Choice;
}

short getQuickWithdrawAmount(short QuickWithdrawOption)
{
    switch (QuickWithdrawOption)
    {
    case 1:
        return 20;
    case 2:
        return 50;
    case 3:
        return 100;
    case 4:
        return 200;
    case 5:
        return 400;
    case 6:
        return 600;
    case 7:
        return 800;
    case 8:
        return 1000;
    default:
        return 0;
    }
}

void PerformQuickWithdrawOption(short QuickWithdrawOption)
{
    if (QuickWithdrawOption == 9)
        return;

    short WithdrawBalance = getQuickWithdrawAmount(QuickWithdrawOption);

    if (WithdrawBalance > CurrentClient.AccountBalance)
    {
        cout << "\nThe amount exceeds your balance, make another choice.\n";
        cout << "Press any key to continue...";
        ShowQuickWithdrawScreen();
        return;
    }

    vector<sClient> vClients = LoadClientsDataFromFile(ClientsFileName);
    DepositBalanceToClientByAccountNumber(CurrentClient.AccountNumber, WithdrawBalance * -1, vClients);
    CurrentClient.AccountBalance -= WithdrawBalance;
}

double ReadDepositAmount()
{
    double Amount;
    cout << "\nEnter a positive Deposit Amount: ";
    cin >> Amount;
    cin.ignore(numeric_limits<streamsize>::max(), '\n'); // Clear the input buffer

    while (Amount <= 0)
    {
        cout << "\nEnter a positive Deposit Amount: ";
        cin >> Amount;
        cin.ignore(numeric_limits<streamsize>::max(), '\n'); // Clear the input buffer
    }
    return Amount;
}

void PerformDepositOption()
{
    double DepositAmount = ReadDepositAmount();
    vector<sClient> vClients = LoadClientsDataFromFile(ClientsFileName);
    DepositBalanceToClientByAccountNumber(CurrentClient.AccountNumber, DepositAmount, vClients);
    CurrentClient.AccountBalance += DepositAmount;
}

void ShowDepositScreen()
{
    cout << "\n===========================================\n";
    cout << "\t\tDeposit Screen\n";
    cout << "===========================================\n";
    PerformDepositOption();
}

void ShowCheckBalanceScreen()
{
    cout << "\n===========================================\n";
    cout << "\t\tCheck Balance Screen\n";
    cout << "===========================================\n";
    cout << "Your Balance is " << CurrentClient.AccountBalance << "\n";
}

int ReadWithdrawAmount()
{
    int Amount;
    cout << "\nEnter an amount multiple of 5's: ";
    cin >> Amount;
    cin.ignore(numeric_limits<streamsize>::max(), '\n'); // Clear the input buffer

    while (Amount % 5 != 0)
    {
        cout << "\nEnter an amount multiple of 5's: ";
        cin >> Amount;
        cin.ignore(numeric_limits<streamsize>::max(), '\n'); // Clear the input buffer
    }
    return Amount;
}

void PerformNormalWithdrawOption()
{
    int WithdrawBalance = ReadWithdrawAmount();

    if (WithdrawBalance > CurrentClient.AccountBalance)
    {
        cout << "\nThe amount exceeds your balance, make another choice.\n";
        cout << "Press any key to continue...";
        system("pause>0");
        ShowNormalWithdrawScreen();
        return;
    }

    vector<sClient> vClients = LoadClientsDataFromFile(ClientsFileName);
    DepositBalanceToClientByAccountNumber(CurrentClient.AccountNumber, WithdrawBalance * -1, vClients);
    CurrentClient.AccountBalance -= WithdrawBalance;
}

void ShowNormalWithdrawScreen()
{
    cout << "\n===========================================\n";
    cout << "\t\tNormal Withdraw Screen\n";
    cout << "===========================================\n";
    PerformNormalWithdrawOption();
}

void ShowQuickWithdrawScreen()
{
    cout << "\n===========================================\n";
    cout << "\t\tQuick Withdraw\n";
    cout << "===========================================\n";
    cout << "\t[1] 20\t\t[2] 50\n";
    cout << "\t[3] 100\t\t[4] 200\n";
    cout << "\t[5] 400\t\t[6] 600\n";
    cout << "\t[7] 800\t\t[8] 1000\n";
    cout << "\t[9] Exit\n";
    cout << "===========================================\n";
    cout << "Your Balance is " << CurrentClient.AccountBalance;

    PerformQuickWithdrawOption(ReadQuickWithdrawOption());
}

void GoBackToMainMenu()
{
    cout << "\n\nPress any key to go back to Main Menu...";
    cin.ignore(numeric_limits<streamsize>::max(), '\n'); // Clear the input buffer
    ShowMainMenu();
}

short ReadMainMenuOption()
{
    cout << "Choose what do you want to do? [1 to 5]? ";
    short Choice = 0;
    cin >> Choice;
    cin.ignore(numeric_limits<streamsize>::max(), '\n'); // Clear the input buffer

    return Choice;
}

void PerformMainMenuOption(enMainMenuOptions MainMenuOption)
{
    switch (MainMenuOption)
    {
    case enMainMenuOptions::eQuickWithdraw:
        ShowQuickWithdrawScreen();
        GoBackToMainMenu();
        break;
    case enMainMenuOptions::eNormalWithdraw:
        ShowNormalWithdrawScreen();
        GoBackToMainMenu();
        break;
    case enMainMenuOptions::eDeposit:
        ShowDepositScreen();
        GoBackToMainMenu();
        break;
    case enMainMenuOptions::eCheckBalance:
        ShowCheckBalanceScreen();
        GoBackToMainMenu();
        break;
    case enMainMenuOptions::eExit:
        Login();
        break;
    }
}

void ShowMainMenu()
{
    cout << "\n===========================================\n";
    cout << "\t\tATM Main Menu Screen\n";
    cout << "===========================================\n";
    cout << "\t[1] Quick Withdraw.\n";
    cout << "\t[2] Normal Withdraw.\n";
    cout << "\t[3] Deposit\n";
    cout << "\t[4] Check Balance.\n";
    cout << "\t[5] Logout.\n";
    cout << "===========================================\n";

    PerformMainMenuOption((enMainMenuOptions)ReadMainMenuOption());
}

bool LoadClientInfo(string AccountNumber, string PinCode)
{
    return FindClientByAccountNumberAndPinCode(AccountNumber, PinCode, CurrentClient);
}

void Login()
{
    bool LoginFailed = false;
    string AccountNumber, PinCode;
    do
    {
        system("cls");
        cout << "\n---------------------------------\n";
        cout << "\tLogin Screen";
        cout << "\n---------------------------------\n";

        if (LoginFailed)
        {
            cout << "Invalid Account Number/PinCode!\n";
        }

        cout << "Enter Account Number: ";
        cin >> AccountNumber;
        cin.ignore(numeric_limits<streamsize>::max(), '\n'); // Clear the input buffer

        cout << "Enter Pin: ";
        cin >> PinCode;
        cin.ignore(numeric_limits<streamsize>::max(), '\n'); // Clear the input buffer

        LoginFailed = !LoadClientInfo(AccountNumber, PinCode);

    } while (LoginFailed);

    ShowMainMenu();
}

int main()
{
    Login();
    return 0;
}
