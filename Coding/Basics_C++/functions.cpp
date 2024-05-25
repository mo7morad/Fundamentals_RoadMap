#include <iostream>
#include <typeinfo>
#include <string>
using namespace std;

void infoCard(){

  string Name = "Mohammed Abu-Hadhoud";
  string City = "Amman";
  string Country = "Jordan";
  int Age = 44;
  int Monthly_Salary = 5000;
  int Yearly_Salary = 60000;
  char  Gender = 'M';
  int Married = 1;

  cout<<"*************\n";
  cout << "Name: " << Name << endl;
  cout << "Age: " << Age << endl;
  cout << "City: " << City << endl;
  cout << "Country: " << Country << endl;
  cout << "Monthly Salary is: " << Monthly_Salary << endl;
  cout << "Yearly Salary is: " << Yearly_Salary << endl;
  cout << "Gender: " << Gender << endl;
  cout << "Married: " << Married << endl;
  cout << "*************";
}


void SquareOfStars(){

  for (int i = 0; i < 4; i++){

    cout<<"*********************" << endl;
  }


}

void my_sum_procedure()
{
  int num1, num2;
  cout << "Please enter the first number: ";
  cin >> num1;

  cout << "Please enter the second number: ";
  cin >> num2;

  cout << num1 + num2 << endl;
}

int my_sum_func()
{
  int num1, num2;
  cout << "Please enter the first number: ";
  cin >> num1;

  cout << "Please enter the second number: ";
  cin >> num2;

  return num1 + num2;
}

int main()
{




  return 0;
}


