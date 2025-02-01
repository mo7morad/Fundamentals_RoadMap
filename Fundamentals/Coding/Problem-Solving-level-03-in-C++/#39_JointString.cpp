#include <string>
#include <iostream>
#include <vector>
using namespace std;

string JoinString(vector<string> &str, string delimiter)
{
  string result = "";
  for (int i = 0; i < str.size(); i++)
  {
    result += str[i];
    if (i != str.size() - 1)
    {
      result += delimiter;
    }
  }
  return result;
}

// OR

// string JoinString(vector <string> &str, string delimiter)
// {
//   string result = "";
//   for (string &word : str)
//   {
//     result += word;
//     if (word != str[str.size()-1])
//     {
//       result += delimiter;
//     }
//   }
//   return result;
// }



int main()
{
  vector <string> vWords = {"Ahmed", "Mohamed", "Ali", "Mona"};
  string delimiter = "*_*";
  cout << JoinString(vWords, delimiter);
  return 0;
}

// Course Code

/*
#include <string>
#include <iostream>
#include <vector>

using namespace std;

string JoinString(vector<string> vString, string Delim) {
    string S1 = "";
    for (string& s : vString) {
        S1 = S1 + s + Delim;
    }
    return S1.substr(0, S1.length() - Delim.length());
}

int main() {
    vector<string> vString = { "Mohammed", "Faid", "Ali", "Maher" };
    cout << "\nVector after join: \n";
    cout << JoinString(vString, " ");
    system("pause>0");
    return 0;
}
*/