#include <iostream>
#include "headers/clsPerson.h"
#include "headers/clsBankClient.h"
#include "headers/clsInputValidation.h"
using namespace std;

void ReadClientInfo(clsBankClient &Client)
{
  cout << "\nEnter First Name: ";
  Client.SetFirstName(clsInputValidation::ReadString());

  cout << "\nEnter Last Name: ";
  Client.SetLastName(clsInputValidation::ReadString());

  cout << "\nEnter Email: ";
  Client.SetEmail(clsInputValidation::ReadString());

  cout << "\nEnter Phone: ";
  Client.SetPhone(clsInputValidation::ReadString());

  cout << "\nEnter Pin Code: ";
  Client.SetPinCode(clsInputValidation::ReadString());

  cout << "\nEnter Account Balance: ";
  Client.SetAccountBalance(clsInputValidation::ReadDoubleNumber()); // Use ReadDoubleNumber for balance
}

void UpdateClient()
{
  string AccountNumber;
  cout << "Enter the account number to update it: ";
  AccountNumber = clsInputValidation::ReadString();

  while(!clsBankClient::IsClientExist(AccountNumber))
  {
    cout << "Please enter an existing account number: ";
    AccountNumber = clsInputValidation::ReadString();
  }

  clsBankClient Client = clsBankClient::Find(AccountNumber);
  Client.Print();

  ReadClientInfo(Client);
  Client.Save();
}

void AddNewClient()
{
  // Get Account Number
  string AccountNumber = "";
  cout << "\nPlease Enter Account Number: ";
  AccountNumber = clsInputValidation::ReadString();

  // Check if account number is already exists
  while (clsBankClient::IsClientExist(AccountNumber))
  {
    // if account number is already exists
    cout << "\nAccount Number Is Already Used, Choose another one: ";
    AccountNumber = clsInputValidation::ReadString();
  }

  // Create new client object if acc num does not exists
  clsBankClient NewClient = clsBankClient::GetAddNewClientObject(AccountNumber);
  ReadClientInfo(NewClient);

  clsBankClient::enSaveResults SaveResult;
  SaveResult = NewClient.Save();

  // UI handling based on save result
  switch (SaveResult)
  {
  case clsBankClient::enSaveResults::svSucceeded:
  {
    cout << "\nAccount Addeded Successfully :-)\n";
    NewClient.Print();
    break;
  }
  case clsBankClient::enSaveResults::svFaildEmptyObject:
  {
    cout << "\nError account was not saved because it's Empty";
    break;
  }
  case clsBankClient::enSaveResults::svFaildAccountNumberExists:
  {
    cout << "\nError account was not saved because account number is used!\n";
    break;
  }
  }
}

