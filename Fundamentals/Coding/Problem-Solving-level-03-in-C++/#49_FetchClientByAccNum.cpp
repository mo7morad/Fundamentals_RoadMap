#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <iomanip>
using namespace std;

const string ClientsFileName = "ClientsDataCourseCode.txt";


string ReadClientAccountNumber()
{
  string AccountNumber = "";
  cout << "\nPlease enter AccountNumber? ";
  cin >> AccountNumber;
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

void PrintClientCard(stClient &Client)
{
  cout << "\nThe following are the client details:\n";
  cout << "\nAccout Number: " << Client.AccountNumber;
  cout << "\nPin Code : " << Client.PinCode;
  cout << "\nName : " << Client.Name;
  cout << "\nPhone : " << Client.Phone;
  cout << "\nAccount Balance: " << Client.AccountBalance;
}

bool FetchClientByAccNum(string AccNum, stClient &Client)
{
  vector<stClient> vClients = LoadClientsDataFromFile(ClientsFileName);
  
  for (stClient C : vClients)
  {
    if (C.AccountNumber == AccNum)
    {
      Client = C;
      return 1;
    }
  }
  return 0;
}


int main()
{
  stClient Client;
  string AccountNumber = ReadClientAccountNumber();
  if(FetchClientByAccNum(AccountNumber, Client))
  {
    PrintClientCard(Client);
  }
  else
  {
    cout << "\nClient with Account Number (" << AccountNumber << ") is Not Found!";
  }
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

void PrintClientCard(sClient Client)
{
    cout << "\nThe following are the client details:\n";
    cout << "\nAccout Number: " << Client.AccountNumber;
    cout << "\nPin Code : " << Client.PinCode;
    cout << "\nName : " << Client.Name;
    cout << "\nPhone : " << Client.Phone;
    cout << "\nAccount Balance: " << Client.AccountBalance;
}

bool FindClientByAccountNumber(string AccountNumber, sClient &Client)
{
    vector<sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
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

string ReadClientAccountNumber()
{
  string AccountNumber = "";
  cout << "\nPlease enter AccountNumber? ";
  cin >> AccountNumber;
  return AccountNumber;
}

int main()
{
    sClient Client;
    string AccountNumber = ReadClientAccountNumber();
    if (FindClientByAccountNumber(AccountNumber, Client))
    {
      PrintClientCard(Client);
    }
    else
    {
      cout << "\nClient with Account Number (" << AccountNumber << ") is Not Found!";
    }
    system("pause>0");
    return 0;
}
*/