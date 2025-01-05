#pragma once
#include <iostream>
#include <string>
#include "clsString.h"
#include "clsScreen.h"
#include <vector>
#include <fstream>
using namespace std;

class clsCurrencyExchangeScreen : protected clsScreen
{
private:
    enum enCurrencyExchangeOptions
    {
        ListCurrencies = 1, FindCurrency = 2, UpdateRate = 3, CurrencyCalculator = 4, ReturnToMainMenu = 5
    };

    static short _ReadCurrencyExchangeOption()
    {
        cout << setw(37) << left << "" << "Choose what do you want to do? [1 to 5]? ";
        short Choice = clsInputValidation::ReadShortNumberBetween(1, 5, "Enter Number between 1 to 5? ");
        return Choice;
    }

    static void _GoBackToCurrencyExchangeMenu()
    {
        cout << setw(37) << left << "" << "\n\tPress any key to go back to Currency Exchange Menu...\n";
        cin.ignore();
        cin.get();
        ShowCurrencyExchangeScreen();
    }

    static void _ShowAllCurrenciesScreen()
    {
      cout << "\nShow All Currencies Screen\n";
    }

    static void _ShowFindCurrencyScreen()
    {
      cout << "\nFind Currency Screen\n";
    }

    static void _ShowUpdateRateScreen()
    {
      cout << "\nUpdate Rate Screen\n";
    }

    static void _ShowCurrencyCalculatorScreen()
    {
      cout << "\nCurrency Calculator Screen\n";
    }

    static void _PerformCurrencyExchangeOption(short Option)
    {
      switch (Option)
      {
      case ListCurrencies:
          system("clear");
          _ShowAllCurrenciesScreen();
          _GoBackToCurrencyExchangeMenu();
          break;
      case FindCurrency:
          system("clear");
          _ShowFindCurrencyScreen();
          _GoBackToCurrencyExchangeMenu();
          break;
      case UpdateRate:
          system("clear");
          _ShowUpdateRateScreen();
          _GoBackToCurrencyExchangeMenu();
          break;
      case CurrencyCalculator:
          system("clear");
          _ShowCurrencyCalculatorScreen();
          _GoBackToCurrencyExchangeMenu();
          break;
      case ReturnToMainMenu:
          // do nothing here the main screen will handle it :-) ;
          break;
      }
    }

public:
    static void ShowCurrencyExchangeScreen()
    {
        system("clear");
        _DrawScreenHeader("\t\tCurrency Exchange Screen");
        cout << setw(37) << left << "" << "===========================================\n";
        cout << setw(37) << left << "" << "\t\t\tCurrency Exchange Menu\n";
        cout << setw(37) << left << "" << "===========================================\n";
        cout << setw(37) << left << "" << "1. List Currencies\n";
        cout << setw(37) << left << "" << "2. Find Currency\n";
        cout << setw(37) << left << "" << "3. Update Rate\n";
        cout << setw(37) << left << "" << "4. Currency Calculator\n";
        cout << setw(37) << left << "" << "5. Return to Main Menu\n";
        cout << setw(37) << left << "" << "===========================================\n";

        short Option = _ReadCurrencyExchangeOption();
        _PerformCurrencyExchangeOption(Option);
    }
};