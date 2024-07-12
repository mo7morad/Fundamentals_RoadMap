#pragma once

#include <iostream>
using namespace std;

namespace MyLibrary
{

  void SayHello()
  {
    cout << "this is hello from My Library \n";
  };

  int Sum2Nums(int a , int b){
    return a + b;
  }
  float Sum2Nums(float a , float b){
    return a + b;
  }

}