#pragma once
#include <iostream>
#include "clsScreen.h"
#include "clsBankClient.h"
#include "clsInputValidation.h"
#include <iomanip>
using namespace std;

class clsTransferScreen : protected clsScreen
{
private:
  static void _PrintTransferClientCard(clsBankClient Client)
  {
    cout << "\nClient Card:";
    cout << "\n___________________";
    cout << "\nFull Name   : " << Client.GetFullName();
    cout << "\nAcc. Number : " << Client.GetAccountNumber();
    cout << "\nBalance     : " << Client.GetAccountBalance();
    cout << "\n___________________\n";
  }

  static void _ShowTransferScreen()
  {
    string _TranferFromAccount, _TransferToAccount;
    double _TransferAmount;
    clsScreen::_DrawScreenHeader("\tTrnasfer Screen");

    cout << "Please enter account number to transfer from: ";
    _TranferFromAccount = clsInputValidation::ReadString();

    while (!clsBankClient::IsClientExist(_TranferFromAccount))
    {
      cout << "Account Number Doens't Exists! Enter an existign account number: ";
      _TranferFromAccount = clsInputValidation::ReadString();
    }
    clsBankClient SenderClient = clsBankClient::Find(_TranferFromAccount);
    _PrintTransferClientCard(SenderClient);

    cout << "Please enter account number to transfer to: ";
    _TransferToAccount = clsInputValidation::ReadString();

    while (!clsBankClient::IsClientExist(_TransferToAccount))
    {
      cout << "\nAccount Number Doens't Exists! Enter an existing account number: ";
      _TranferFromAccount = clsInputValidation::ReadString();
    }
    clsBankClient ReceiverClient = clsBankClient::Find(_TransferToAccount);
    _PrintTransferClientCard(ReceiverClient);
    cout << "Enter Transfer Amount: ";
    _TransferAmount = clsInputValidation::ReadDoubleNumber();

    while (SenderClient.GetAccountBalance() < _TransferAmount)
    {
      cout << "\nAmount Exceeds the available balance.";
      cout << "\nAmout to withdraw is: " << _TransferAmount;
      cout << "\nYour Balance is: " << SenderClient.GetAccountBalance();
      cout << "\nplease enter another amount: ";
      _TransferAmount = clsInputValidation::ReadDoubleNumber();
    }

    cout << "\nAre you sure you want to perform this transfer? y/n? ";
    char Answer = 'n';
    cin >> Answer;

    if (Answer == 'Y' || Answer == 'y')
    {
      SenderClient.Withdraw(_TransferAmount);
      ReceiverClient.Deposit(_TransferAmount);
      cout << "\nTransfer Done Successfully!" << endl;

      _PrintTransferClientCard(SenderClient);
      _PrintTransferClientCard(ReceiverClient);
    }
  }

public:
  static void ShowTransferScreen()
  {
    _ShowTransferScreen();
  }
};