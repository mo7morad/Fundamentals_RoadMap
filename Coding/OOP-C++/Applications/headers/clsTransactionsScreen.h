#pragma once
#include <iostream>
#include "clsScreen.h"
#include "clsInputValidation.h"
#include "clsShowDepositScreen.h"
#include <iomanip>
using namespace std;

class clsTransactionsScreen : protected clsScreen
{

private:
  enum enTransactionsMenuOptions
  {
    Deposit = 1,
    Withdraw = 2,
    ShowTotalBalance = 3,
    ShowMainMenu = 4
  };

  static short ReadTransactionsMenuOption()
  {
    cout << setw(37) << left << "" << "Choose what do you want to do? [1 to 4]? ";
    short Choice = clsInputValidation::ReadShortNumberBetween(1, 4, "Enter Number between 1 to 4? ");
    return Choice;
  }

  static void _ShowDepositScreen()
  {
    clsDepositScreen::ShowDepositScreen();
  }

  static void _ShowWithdrawScreen()
  {
    cout << "\n Withdraw Screen will be here.\n";
  }

  static void _ShowTotalBalancesScreen()
  {
    cout << "\n Balances Screen will be here.\n";
  }

  static void _GoBackToTransactionsMenu()
  {
    cout << "\n\nPress any key to go back to Transactions Menu...";
    cin.ignore();
    cin.get();
    ShowTransactionsMenu();
  }

  static void _PerformTransactionsMenuOption(enTransactionsMenuOptions TransactionsMenueOption)
  {
    switch (TransactionsMenueOption)
    {
    case enTransactionsMenuOptions::Deposit:
    {
      system("clear");
      _ShowDepositScreen();
      _GoBackToTransactionsMenu();
      break;
    }

    case enTransactionsMenuOptions::Withdraw:
    {
      system("clear");
      _ShowWithdrawScreen();
      _GoBackToTransactionsMenu();
      break;
    }

    case enTransactionsMenuOptions::ShowTotalBalance:
    {
      system("clear");
      _ShowTotalBalancesScreen();
      _GoBackToTransactionsMenu();
      break;
    }

    case enTransactionsMenuOptions::ShowMainMenu:
    {
      // do nothing here the main screen will handle it :-) ;
    }
    }
  }

public:
  static void ShowTransactionsMenu()
  {
    system("clear");
    _DrawScreenHeader("\t  Transactions Screen");

    cout << setw(37) << left << "" << "===========================================\n";
    cout << setw(37) << left << "" << "\t\t  Transactions Menu\n";
    cout << setw(37) << left << "" << "===========================================\n";
    cout << setw(37) << left << "" << "\t[1] Deposit.\n";
    cout << setw(37) << left << "" << "\t[2] Withdraw.\n";
    cout << setw(37) << left << "" << "\t[3] Total Balances.\n";
    cout << setw(37) << left << "" << "\t[4] Main Menu.\n";
    cout << setw(37) << left << "" << "===========================================\n";

    _PerformTransactionsMenuOption((enTransactionsMenuOptions)ReadTransactionsMenuOption());
  }
};
