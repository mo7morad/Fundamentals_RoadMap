#include <iostream>
#include <math.h>
using namespace std;

//                               ######################-1&2-#############################
/*string ReadName()
{
  string name;
  cout << "Enter your name: ";
  getline(cin,name);
  return name;
};

void PrintName(string name)
{
  cout << "Your name is: " << name << '\n';
};*/

//                              ##########################-3-############################

/*enum enNumberType {Odd = 1, Even = 2};

int ReadNumber()
{
  int number;
  cout << "Please enter a number: ";
  cin >> number;
  return number;
};

enNumberType CheckNumberType(int number)
{
  if (number  % 2 == 0)
    return Even;
  else
    return Odd;
};

void PrintNumberType(enNumberType NumberType)
{
  if(NumberType == enNumberType::Even)
    cout << "Your number is even.\n";
  else
    cout << "Your number is odd\n";
};*/


//                                #########################-4&5-##########################

/*struct strInfo {int Age;
                bool HasDriverLicense;
                bool HasReccomondation;};

bool IsAccepted(strInfo Info)
{
  return(Info.Age > 21 && Info.HasDriverLicense || Info.HasReccomondation);
};

strInfo ReadInfo()
{
  strInfo Info;
  cout << "Please enter your age: ";
  cin >> Info.Age;
  cout << "Do you Have Driver Licenes? 0 / 1: ";
  cin >> Info.HasDriverLicense;
  cout << "Do you have any recomondation? 0 / 1: ";
  cin >> Info.HasReccomondation;
  return Info;
};

void PrintResult(strInfo Info)
{
  if(IsAccepted(Info))
  {
    cout << "Hired!\n";
  }
  else
  {
    cout << "Rejected!\n";
  }
};
*/

//                                #########################-6-############################

/*string GetFullName()
{
  string FullName;
  cout << "Please enter your full name: ";
  getline(cin, FullName);
  return FullName;
};

void PrintFullName(string FullName)
{
  cout << "Your full name is: " << FullName;
};
*/

//                                ###########################OR###########################

/*struct stFullName
{
  string FirstName;
  string LastName;
};

stFullName ReadFullName()
{
  stFullName Name;
  cout << "Please enter your first name: ";
  cin >> Name.FirstName;
  cout << "Please enter your last name: ";
  cin >> Name.LastName;
  return Name;
};

string GatheringFullName(stFullName SeperatedName, bool Reversed)
{
  if (Reversed ==  true)
    return (SeperatedName.LastName + ", " + SeperatedName.FirstName);
  else
    return (SeperatedName.FirstName + " " + SeperatedName.LastName);
};

void  DisplayingFullName(string FullName)
{
  cout << "Your full name is: "<< FullName << endl;
};*/

//                                #########################-7-############################


/*int ReadNumber()
{
  int Number;
  cout << "Please enter your number: ";
  cin >> Number;
  return Number;
};

float GetHalfNumber(int Number)
{
  return (float) Number / 2;
};

void ShowResult(int Number)
{
  cout << "The half number is: " << GetHalfNumber(Number) << endl;
};*/

//                               #########################-8-#############################

/*float ReadMark()
{
  float Mark;
  cout << "Please enter your mark: ";
  cin >> Mark;
};

string CheckPassOrFail(float Mark)
{
  if  (Mark >= 50)
    return "Passed!";
  else
    return "Failed!";
};

void ShowResult(string Result)
{
  cout << Result << endl;
};*/

//                                ###########################OR###########################

/*enum enPassnFail {Pass = 1, Fail =2};

float ReadMark()
{
  float Mark;
  cout << "Please enter your mark: ";
  cin >> Mark;
  return Mark;
};

enPassnFail CheckMark(float Mark)
{
  if (Mark >= 50)
    return enPassnFail::Pass;
  else
    return enPassnFail::Fail;
};

void PrintResult(float Mark)
{
  if (CheckMark(Mark) == enPassnFail::Pass)
    cout << "You passed!" << endl;
  else
    cout << "You failed!" << endl;
};*/


/*void ReadNumbers(int& Num1, int& Num2, int& Num3)
{
  cout << "Please enter 3 numbers on a row:\n";
  cin >> Num1 >> Num2 >> Num3;
};

float SumOf3Numbers(int Number1, int Number2, int Number3)
{
  return  (float) Number1 + Number2 + Number3;
};

void PrintResults(float Result)
{
  cout << "The sum of the three numbers is: " << Result << endl;
};*/


//                                #########################-16-############################


/*void ReadNumbers(float& A, float& D)
{
  cout << "Enter A: " << endl;
  cin >> A;
  cout << "Enter D: " << endl;
  cin >> D;
};

float CalculateRectangleArea(float A, float D)
{
  return A*sqrt(D*D-A*A);
};

void PrintResult(float Result)
{
  cout << "The regtangle area is: " << Result << endl;
};*/


//                                #########################-24&25-############################

/*int ReadAge()
{
  int Age;
  cout << "Please enter your age: ";
  cin >> Age;
  return Age;
};

bool ValidateNumberInRange(int Number, int From, int To)
{
  return (Number >= From && Number <= To);
};

int ReadUntilAgeBetween(int From, int To)
{
  int Age = 0;
  do
  {
    Age = ReadAge();
  } while (!ValidateNumberInRange(Age, From, To));
  return Age;
};

void PrintResult(int Age)
{
  if (ValidateNumberInRange(Age, 18,45))
    cout << Age << " Is a valid age!";
  else
    cout << Age << " Is not a valid age!";
};*/



//                                #########################-42-############################

/*struct strTimeDurations {int NumberOfDays, NumberOfHours, NumberOfMinutes, NumberOfSeconds;};

int ReadPositiveNumber(string Message)
{
  int Number;
  do
  {
    cout << Message;
    cin >> Number;
  }while(Number < 0);
  return Number;
};

strTimeDurations ReadTime()
{
  strTimeDurations TimeDuration;

  TimeDuration.NumberOfDays = ReadPositiveNumber("Please enter the number of Days: ");
  TimeDuration.NumberOfHours = ReadPositiveNumber("Please enter the number of Hours: ");
  TimeDuration.NumberOfMinutes = ReadPositiveNumber("Please enter the number of Minutes: ");
  TimeDuration.NumberOfSeconds = ReadPositiveNumber("Please enter the number of Seconds: ");

  return TimeDuration;
};

float TimeDurationsInSeconds(strTimeDurations Time)
{
  float TimeInSecs
  ;
  TimeInSecs = Time.NumberOfDays * 24 * 60 * 60;
  TimeInSecs += Time.NumberOfHours * 60 * 60;
  TimeInSecs += Time.NumberOfMinutes * 60;
  TimeInSecs += Time.NumberOfDays;
  
  return TimeInSecs;
}*/

//                                #########################-46-############################





int main()
{


  return 0;
}