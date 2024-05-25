#include <iostream>
using namespace std;

struct strInfo
{
  string Name, City, Country;
  float MonthlySalary, YearlySalary;
  char Gender;
  bool Married;
};

void ReadInfo(strInfo &Info)
{
  cout << "Please enter your first name: ";
  cin >> Info.Name;

  cout << "Please enter your city: ";
  cin >> Info.City;

  cout << "Please enter your country: ";
  cin >> Info.Country;

  cout << "Please enter your Monthly Salary: ";
  cin >> Info.MonthlySalary;
  Info.YearlySalary = Info.MonthlySalary * 12;

  cout << "Please enter your gender M/F: ";
  cin >> Info.Gender;

  cout << "Please enter if you're married or not 0 or 1: ";
  cin >> Info.Married;
};

void DisplayInfo(strInfo Info)
{
  cout << "\n**************\n";

  cout << "User Information:\n";
  cout << "User's Gender: " << Info.Gender << endl;
  cout << "Fullname : " << Info.Name << endl;
  cout << "City     : " << Info.City << endl;
  cout << "Country  : " << Info.Country << endl;
  cout << "Yearly Salary : $" << Info.YearlySalary << endl;
  cout << "Martial Status: " << Info.Married << endl;

  cout << "\n**************\n";
};

enum enColor
{
  Red,
  Green,
  Yellow,
  Blue
};
enum enGendor
{
  Male,
  Female
};
enum enMaritalStatus
{
  Single,
  Married
};

struct stAddress
{
  string StreetName;
  string BuildingNo;
  string POBox;
  string ZipCode;
};

struct stContactInfo
{
  string Phone;
  string Email;
  stAddress Address;
};

struct stPerson
{

  string FirstName;
  string LastName;

  stContactInfo ContactInfo;

  enMaritalStatus MaritalStatues;
  enGendor Gendor;
  enColor FavourateColor;
};

int main()
{

  stPerson Person1;

  Person1.FirstName = "Mohammed";
  Person1.LastName = "Abu-Hadhoud";

  Person1.ContactInfo.Email = "xyz@xyz.com";
  Person1.ContactInfo.Phone = "+961000000999";
  Person1.ContactInfo.Address.POBox = "7777";
  Person1.ContactInfo.Address.ZipCode = "11194";
  Person1.ContactInfo.Address.StreetName = "Queen1 Street";
  Person1.ContactInfo.Address.BuildingNo = "313";

  Person1.Gendor = enGendor::Male;
  Person1.MaritalStatues = enMaritalStatus::Married;
  Person1.FavourateColor = enColor::Green;

  cout << Person1.ContactInfo.Address.StreetName << endl;

  return 0;
}
