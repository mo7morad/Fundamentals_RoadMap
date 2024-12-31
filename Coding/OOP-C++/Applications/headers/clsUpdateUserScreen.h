#pragma once
#include <iostream>
#include "clsScreen.h"
#include "clsPerson.h"
#include "clsUser.h"
#include "clsInputValidation.h"

class clsUpdateUserScreen :protected clsScreen

{
private:
    static void _ReadUserInfo(clsUser &User)
    {
        cout << "\nEnter FirstName: ";
        User.GetFirstName() = clsInputValidation::ReadString();

        cout << "\nEnter LastName: ";
        User.GetLastName() = clsInputValidation::ReadString();

        cout << "\nEnter Email: ";
        User.GetEmail() = clsInputValidation::ReadString();

        cout << "\nEnter Phone: ";
        User.GetPhone() = clsInputValidation::ReadString();

        cout << "\nEnter Password: ";
        User.GetPassword() = clsInputValidation::ReadString();

        cout << "\nEnter Permission: ";
        User.SetPermissions(_ReadPermissionsToSet());
    }

    static void _PrintUser(clsUser User)
    {
        cout << "\nUser Card:";
        cout << "\n___________________";
        cout << "\nFirstName   : " << User.GetFirstName();
        cout << "\nLastName    : " << User.GetLastName();
        cout << "\nFull Name   : " << User.GetFullName();
        cout << "\nEmail       : " << User.GetEmail();
        cout << "\nPhone       : " << User.GetPhone();
        cout << "\nUser Name   : " << User.GetUserName();
        cout << "\nPassword    : " << User.GetPassword();
        cout << "\nPermissions : " << User.GetPermissions();
        cout << "\n___________________\n";
    }

    static clsUser::enPermissions _ReadPermissionsToSet()
    {
        clsUser::enPermissions Permissions = clsUser::enPermissions::None;

        char Answer = 'n';
        cout << "\nDo you want to give the user full access? y/n? ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {
            return clsUser::enPermissions::AllPermissions;
        }

        cout << "\nDo you want to give access to : \n ";
        cout << "\nShow Client List? y/n? ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {
            Permissions | clsUser::enPermissions::ShowClientsList;
        }

        cout << "\nAdd New Client? y/n? ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {
            Permissions | clsUser::enPermissions::AddClient;
        }

        cout << "\nDelete Client? y/n? ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {
            Permissions | clsUser::enPermissions::DeleteClient;
        }

        cout << "\nUpdate Client? y/n? ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {
            Permissions | clsUser::enPermissions::UpdateClient;
        }

        cout << "\nFind Client? y/n? ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {
            Permissions | clsUser::enPermissions::FindClient;
        }

        cout << "\nTransactions? y/n? ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {
            Permissions | clsUser::enPermissions::Transactions;
        }

        cout << "\nManage Users? y/n? ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {
            Permissions | clsUser::enPermissions::ManageUsers;
        }
        return Permissions;
    }

public:

    static void ShowUpdateUserScreen()
    {
        _DrawScreenHeader("\tUpdate User Screen");
        string UserName = "";

        cout << "\nPlease Enter User UserName: ";
        UserName = clsInputValidation::ReadString();

        while (!clsUser::IsUserExist(UserName))
        {
            cout << "\nAccount number is not found, choose another one: ";
            UserName = clsInputValidation::ReadString();
        }
        clsUser User1 = clsUser::Find(UserName);
        _PrintUser(User1);

        cout << "\nAre you sure you want to update this User y/n? ";
        char Answer = 'n';
        cin >> Answer;

        if (Answer == 'y' || Answer == 'Y')
        {
            cout << "\n\nUpdate User Info:";
            cout << "\n____________________\n";

            _ReadUserInfo(User1);
            clsUser::enSaveResults SaveResult;
            SaveResult = User1.Save();

            switch (SaveResult)
            {
            case  clsUser::enSaveResults::svSucceeded:
            {
                cout << "\nUser Updated Successfully :-)\n";
                _PrintUser(User1);
                break;
            }
            case clsUser::enSaveResults::svFaildEmptyObject:
            {
                cout << "\nError User was not saved because it's Empty";
                break;
            }
            }
        }
    }
};

