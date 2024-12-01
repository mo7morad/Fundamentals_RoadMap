#include <iostream>
using namespace std;

void PrintTableHeader()
{
cout << "\t\t\t\t Multiplication Table from 1 to 10\n\n" << endl;
for (short i = 1; i <= 10; i++ )
{
  cout << "\t" << i;
}
cout << "\n ---------------------------------------------------------------------------------------------------- \n";
};

string CoulmnSeparator(short Number)
{
  if(Number < 10) 
    return "   |";
  else
    return "  |";
};


void PrintMultiplicationTable()
{

PrintTableHeader();

for (short i = 1; i <= 10; i++)
{
  cout << " " << i << CoulmnSeparator(i) << "\t";
  for (short j = 1; j <= 10; j++)
  {
    cout << j * i << "\t";
  }
  cout << endl;
};
};


int main()
{

PrintMultiplicationTable();

return 0;
}