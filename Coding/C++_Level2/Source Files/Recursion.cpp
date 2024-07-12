#include <iostream>
using namespace std;

void DownRecursion(int Start, int End){
  if (Start >= End)
  {
    cout << Start << endl;
    DownRecursion(--Start, End);
  }
}

int PowerRecursion(int Number, int Power){
  int Result = 0;
  // 2, 5
  Result = (Power == 0) ? 1 : (Number * PowerRecursion(Number, --Power));

  // 2 * PowerRecursion(2, 4) >>
  // 2 * PowerRecursion(2, 3) >>
  // 2 * PowerRecursion(2, 2) >>
  // 2 * PowerRecursion(2, 1) >>
  // 2 * PowerRecursion(2, 0) >> 2 * 1
  // PowerRecursion(2, 0) >> 1

  return Result;
}

int main(){

// DownRecursion(20,5);

cout << PowerRecursion(2, 5);


  return 0;
}