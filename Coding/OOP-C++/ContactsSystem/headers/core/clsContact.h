#pragma once
#include <iostream>
#include <string>
#include <vector>
#include "clsString.h"
#include "clsPerson.h"
using namespace std;

static int LatestContactId;

class clsContact : public clsPerson
{
private:
  enum enMode
  {
    EmptyMode = 0,
    UpdateMode = 1,
    AddNewMode = 2,
  }; 

  enMode _Mode;
  int _ContactId;

  static string _ConvertContactObjectToLine(clsContact Contact, string Separator = ",")
  {
    return to_string(Contact.GetContactId()) + Separator + Contact.GetFirstName() + Separator + Contact.GetLastName() + Separator + Contact.GetEmail() + Separator + Contact.GetPhone();
  }

  static clsContact _ConvertLineToContactObject(string Line, string Separator = ",")
  {
    vector<string> Tokens = clsString::Split(Line, Separator);
    return clsContact(UpdateMode, stoi(Tokens[0]), Tokens[1], Tokens[2], Tokens[3], Tokens[4]);
  }

public:
  clsContact(enMode Mode, int ContactId, string FirstName, string LastName, string Email, string Phone) : clsPerson(FirstName, LastName, Email, Phone)
  {
    _ContactId = ContactId;
    _Mode = Mode;
  }

  // Property Set
  void SetContactId(int ContactId)
  {
    _ContactId = ContactId;
  }

  // Property Get
  int GetContactId()
  {
    return _ContactId;
  }

  // Property Set
  void SetMode(enMode Mode)
  {
    _Mode = Mode;
  }

  // Property Get
  enMode GetMode()
  {
    return _Mode;
  }

  bool IsEmpty()
  {
    return _Mode == EmptyMode;
  }

  void PrintContact()
  {
    cout << "Contact ID: " << _ContactId << endl;
    cout << "First Name: " << GetFirstName() << endl;
    cout << "Last Name: " << GetLastName() << endl;
    cout << "Email: " << GetEmail() << endl;
    cout << "Phone: " << GetPhone() << endl;
  }

  static clsContact GetAddNewContact()
  {
    return clsContact(AddNewMode, 0, "", "", "", "");
  }

  


};