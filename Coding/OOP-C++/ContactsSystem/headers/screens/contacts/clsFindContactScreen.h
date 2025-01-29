#pragma once
#include <iostream>
#include <iomanip>
#include "../clsScreen.h"
#include "../../core/clsContact.h"
#include "../../lib/clsInputValidate.h"
using namespace std;

class clsFindContactScreen : protected clsScreen
{
private:
  static void _DrawSearchOptions()
  {
    cout << "\nChoose Searching Option: " << endl;
    cout << "1. Search by Contact ID" << endl;
    cout << "2. Search by Full Name" << endl;
    cout << "3. Search by Email" << endl;
    cout << "4. Search by Phone Number" << endl;
    cout << "5. Go Back To Main Menu" << endl;
  }
};