#include <iostream>
#include <cstdlib>
#include <iomanip>
#include <limits>
#include <cmath>
using namespace std;

enum enNumbers
{
  Zero = 0,
  One = 1,
  Two = 2,
  Three = 3,
  Four = 4,
  Five = 5,
  Six = 6,
  Seven = 7,
  Eight = 8,
  Nine = 9,
  Ten = 10
};

int ReadValidNumber()
{
  int Number;
  while (true)
  {
    cout << "Enter a number: ";
    cin >> Number;
    
    if (cin.fail() || Number < 0)
    {
      // Clear error flags
      cin.clear();
      // Ignore invalid input
      cin.ignore(numeric_limits<streamsize>::max(), '\n');
      cout << "Invalid input. Please enter a valid Number." << endl;
    }
    else
    {
      // Valid positive input
      return Number;
    }
  }
}

void PrintOnceNumbers(short Number)
{
  switch (Number)
  {
  case Zero:
    break;
  case One:
    cout << "One";
    break;
  case Two:
    cout << "Two";
    break;
  case Three:
    cout << "Three";
    break;
  case Four:
    cout << "Four";
    break;
  case Five:
    cout << "Five";
    break;
  case Six:
    cout << "Six";
    break;
  case Seven:
    cout << "Seven";
    break;
  case Eight:
    cout << "Eight";
    break;
  case Nine:
    cout << "Nine";
    break;
  case Ten:
    cout << "Ten";
    break;
  default:
    cout << "Invalid Number";
    break;
  }
}

void PrintTeensNumbers(short Number)
{
  switch (Number)
  {
  case 1:
    cout << "Eleven";
    break;
  case 2:
    cout << "Twelve";
    break;
  case 3:
    cout << "Thirteen";
    break;
  case 4:
    cout << "Fourteen";
    break;
  case 5:
    cout << "Fifteen";
    break;
  case 6:
    cout << "Sixteen";
    break;
  case 7:
    cout << "Seventeen";
    break;
  case 8:
    cout << "Eighteen";
    break;
  case 9:
    cout << "Nineteen";
    break;
  default:
    cout << "Invalid Number";
    break;
  }
}

void PrintTensNumbers(short Number)
{
  switch (Number)
  {
  case 1:
    cout << "Ten";
    break;
  case 2:
    cout << "Twenty";
    break;
  case 3:
    cout << "Thirty";
    break;
  case 4:
    cout << "Forty";
    break;
  case 5:
    cout << "Fifty";
    break;
  case 6:
    cout << "Sixty";
    break;
  case 7:
    cout << "Seventy";
    break;
  case 8:
    cout << "Eighty";
    break;
  case 9:
    cout << "Ninety";
    break;
  default:
    cout << "Invalid Number";
    break;
  }
}

void PrintNumberToText(int Number)
{
  if (Number <= 10)
  {
    if (Number == 10)
    {
      PrintOnceNumbers(Ten);
    }
    else
    {
      PrintOnceNumbers(Number);
    }
  }
  else if (Number < 20)
  {
    PrintTeensNumbers(Number % 10);
    cout << " ";
  }

  else if (Number < 100)
  {
    PrintTensNumbers(Number / 10);
    cout << " ";
    PrintOnceNumbers(Number % 10);
  }
  else if (Number < 1000)
  {
    PrintOnceNumbers(Number / 100);
    cout << " Hundred ";
    PrintNumberToText(Number % 100);
  }
  else if (Number < 10'000)
  {
    PrintOnceNumbers(Number / 1000);
    cout << " Thousand ";
    PrintNumberToText(Number % 1000);
  }
  else if (Number < 100'000)
  {
    PrintTensNumbers(Number / 10'000);
    if (Number % 10'000 == 0)
      cout << " Thousand ";

    cout << " ";
    PrintNumberToText(Number % 10'000);
    cout << " ";
  }
  else
  {
    cout << "Invalid Number";
  }
  cout << endl;
}

int main()
{
  PrintNumberToText(ReadValidNumber());
  return 0;
}


// Course Code

/*

#include <iostream>
#include <string>
using namespace std;

string NumberToText(int Number) {
    if (Number == 0) {
        return "";
    }
    if (Number >= 1 && Number <= 19) {
        string arr[] = {
            "", "One", "Two", "Three", "Four", "Five", "Six", "Seven",
            "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen",
            "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };
        return arr[Number] + " ";
    }
    if (Number >= 20 && Number <= 99) {
        string arr[] = {
            "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty",
            "Seventy", "Eighty", "Ninety"
        };
        return arr[Number / 10] + " " + NumberToText(Number % 10);
    }
    if (Number >= 100 && Number <= 199) {
        return "One Hundred " + NumberToText(Number % 100);
    }
    if (Number >= 200 && Number <= 999) {
        return NumberToText(Number / 100) + "Hundred " + NumberToText(Number % 100);
    }
    if (Number >= 1000 && Number <= 1999) {
        return "One Thousand " + NumberToText(Number % 1000);
    }
    if (Number >= 2000 && Number <= 999999) {
        return NumberToText(Number / 1000) + "Thousand " + NumberToText(Number % 1000);
    }
    if (Number >= 1000000 && Number <= 1999999) {
        return "One Million " + NumberToText(Number % 1000000);
    }
    if (Number >= 2000000 && Number <= 999999999) {
        return NumberToText(Number / 1000000) + "Million " + NumberToText(Number % 1000000);
    }
    if (Number >= 1000000000 && Number <= 1999999999) {
        return "One Billion " + NumberToText(Number % 1000000000);
    } else {
        return NumberToText(Number / 1000000000) + "Billion " + NumberToText(Number % 1000000000);
    }
}

int ReadNumber() {
    int Number;
    cout << "\nEnter a Number: ";
    cin >> Number;
    return Number;
}

int main() {
    int Number = ReadNumber();
    cout << NumberToText(Number);
    system("pause>0");
    return 0;
}

*/
