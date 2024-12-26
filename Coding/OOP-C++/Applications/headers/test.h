#pragma once

#include <iostream>
#include <string>
#include <vector>
#include <fstream>
#include "clsPerson.h"
#include "clsString.h"
using namespace std;

class clsBankClient : public clsPerson
{

private:
  enum enMode
  {
    EmptyMode = 0,
    UpdateMode = 1,
    AddNewClient = 2
  };
  enMode _Mode;
  string _AccountNumber;
  string _PinCode;
  float _AccountBalance;

  bool IsEmpty()
  {
    return (_Mode == enMode::EmptyMode);
  }

  string GetAccountNumber()
  {
    return _AccountNumber;
  }

  void SetPinCode(string PinCode)
  {
    _PinCode = PinCode;
  }

  string GetPinCode()
  {
    return _PinCode;
  }

  void SetAccountBalance(float AccountBalance)
  {
    _AccountBalance = AccountBalance;
  }

  float GetAccountBalance()
  {
    return _AccountBalance;
  }

  // Static Members
  static clsBankClient ConvertLineToClientObject(string Line, string Seperator = "#//#")
  {
    vector<string> _vClient = clsString::Split(Line, Seperator);
    return clsBankClient(enMode::UpdateMode, _vClient[0], _vClient[1], _vClient[2],
                          _vClient[3], _vClient[4], _vClient[5], stod(_vClient[6]));
  }

  static clsBankClient _GetEmptyClientObject()
  {
    return clsBankClient(enMode::EmptyMode, "", "", "", "", "", "", 0);
  }

  static string _ConverClientObjectToLine(clsBankClient Client, string Seperator = "#//#")
  {
    string ClientRecordLine;
    ClientRecordLine += Client.GetFirstName() + Seperator;
    ClientRecordLine += Client.GetLastName() + Seperator;
    ClientRecordLine += Client.GetEmail() + Seperator;
    ClientRecordLine += Client.GetPhone() + Seperator;
    ClientRecordLine += Client._AccountNumber + Seperator;
    ClientRecordLine += Client._PinCode + Seperator;
    ClientRecordLine += to_string(Client._AccountBalance);
  }

  static vector<clsBankClient> _LoadClientsDataFromFile()
  {
    vector<clsBankClient> vClients;
    fstream file;
    file.open("Clients.txt", ios::in);
    if(file.is_open())
    {
      string Line;
      while (getline(file, Line))
      {
        vClients.push_back(ConvertLineToClientObject(Line));
      }
      file.close();
    }
    return vClients;
  }

  static void _SaveCleintsDataToFile(vector<clsBankClient> vClients)
  {
    fstream file;
    file.open("Clients.txt", ios::out);
    string Line;
    if(file.is_open())
    {
      for(clsBankClient C : vClients)
      {
        Line = _ConverClientObjectToLine(C);
        file << Line << endl;
      }
      file.close();
    }
  }

  void _Update()
  {
    vector<clsBankClient> _vClients = _LoadClientsDataFromFile();

    for(clsBankClient &C : _vClients)
    {
      if(C._AccountNumber == _AccountNumber)
      {
        C = *this;
        break;
      }
    }
    _SaveCleintsDataToFile(_vClients);
  }

  void _AddDataLineToFile(string stDataLine)
  {
    fstream MyFile;
    MyFile.open("Clients.txt", ios::out | ios::app);

    if (MyFile.is_open())
    {
      MyFile << stDataLine << endl;
      MyFile.close();
    }
  }

  static clsBankClient Find(string AccountNumber)
  {
    vector<clsBankClient> _vClients = _LoadClientsDataFromFile();

    for(clsBankClient &C : _vClients)
    {
      if(C._AccountNumber == AccountNumber)
        return C;
    }
    return _GetEmptyClientObject();
  }

  static clsBankClient Find(string AccountNumber, string PinCode);

  static bool IsClientExist(string AccountNumber)
  {
    clsBankClient Client = Find(AccountNumber);
    if(Client._Mode == UpdateMode)
      return 1;
    else
      return 0;
  }

public:
  clsBankClient(enMode Mode, string FirstName, string LastName,
                string Email, string Phone, string AccountNumber, string PinCode,
                float AccountBalance) : clsPerson(FirstName, LastName, Email, Phone)
  {
    _Mode = Mode;
    _AccountNumber = AccountNumber;
    _PinCode = PinCode;
    _AccountBalance = AccountBalance;
  }

  bool IsEmpty()
  {
    return (_Mode == enMode::EmptyMode);
  }


};

