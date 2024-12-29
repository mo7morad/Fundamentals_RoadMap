#pragma once
#include <iostream>
#include "clsScreen.h"
#include "clsClientsListScreen.h"
#include "clsAddNewClientScreen.h"
#include "clsDeleteClientScreen.h"
#include "clsInputValidation.h"
#include <iomanip>
using namespace std;

class clsMainScreen : protected clsScreen
{
private:

  enum enMainMenuOptions 
  {
      ListClients = 1, AddNewClient = 2, DeleteClient = 3,
      UpdateClient = 4, FindClient = 5, ShowTransactionsMenu = 6,
      ManageUsers = 7, Exit = 8 
  };

  static short _ReadMainMenuOption()
  {
    cout << setw(37) << left << "" << "Choose what do you want to do? [1 to 8]? ";
    short Choice = clsInputValidation::ReadShortNumberBetween(1, 8, "Enter Number between 1 to 8? ");
    return Choice;
  }

  static void _GoBackToMainMenu()
  {
    cout << setw(37) << left << "" << "\n\tPress any key to go back to Main Menu...\n";
    cin.ignore();
    cin.get();
    ShowMainMenu();
  }

  static void _ShowAllClientsScreen()
  {
    clsClientsListScreen::ShowClientsList();
  }

  static void _ShowAddNewClientsScreen()
  {
    clsAddNewClient::ShowAddNewClientScreen();
  }

  static void _ShowDeleteClientScreen()
  {
    clsDeleteClientScreen::ShowDeleteClientScreen();
  }

  static void _ShowUpdateClientScreen()
  {
    cout << "\nUpdate Client Screen Will be here...\n";
  }

  static void _ShowFindClientScreen()
  {
    cout << "\nFind Client Screen Will be here...\n";
  }

  static void _ShowTransactionsMenu()
  {
    cout << "\nTransactions Menu Will be here...\n";
  }

  static void _ShowManageUsersMenu()
  {
    cout << "\nUsers Menu Will be here...\n";
  }

  static void _ShowEndScreen()
  {
    cout << "\nEnd Screen Will be here...\n";
  }

  static void _PerfromMainMenu(enMainMenuOptions MainMenuOption)
  {
    switch (MainMenuOption)
    {
    case ListClients:
    {
      system("clear");
      _ShowAllClientsScreen();
      _GoBackToMainMenu();
      break;
    }
    case AddNewClient:
      system("clear");
      _ShowAddNewClientsScreen();
      _GoBackToMainMenu();
      break;

    case DeleteClient:
      system("clear");
      _ShowDeleteClientScreen();
      _GoBackToMainMenu();
      break;

    case UpdateClient:
      system("clear");
      _ShowUpdateClientScreen();
      _GoBackToMainMenu();
      break;

    case FindClient:
      system("clear");
      _ShowFindClientScreen();
      _GoBackToMainMenu();
      break;

    case ShowTransactionsMenu:
      system("clear");
      _ShowTransactionsMenu();
      break;

    case ManageUsers:
      system("clear");
      _ShowManageUsersMenu();
      break;

    case Exit:
      system("clear");
      _ShowEndScreen();
      // Login();
      break;
    }
  }

public:

  static void ShowMainMenu()
  {
    system("clear");
    _DrawScreenHeader("\t\tMain Screen");

    cout << setw(37) << left << "" << "===========================================\n";
    cout << setw(37) << left << "" << "\t\t\tMain Menu\n";
    cout << setw(37) << left << "" << "===========================================\n";
    cout << setw(37) << left << "" << "\t[1] Show Client List.\n";
    cout << setw(37) << left << "" << "\t[2] Add New Client.\n";
    cout << setw(37) << left << "" << "\t[3] Delete Client.\n";
    cout << setw(37) << left << "" << "\t[4] Update Client Info.\n";
    cout << setw(37) << left << "" << "\t[5] Find Client.\n";
    cout << setw(37) << left << "" << "\t[6] Transactions.\n";
    cout << setw(37) << left << "" << "\t[7] Manage Users.\n";
    cout << setw(37) << left << "" << "\t[8] Logout.\n";
    cout << setw(37) << left << "" << "===========================================\n";
    _PerfromMainMenu((enMainMenuOptions)_ReadMainMenuOption());
  }
};
