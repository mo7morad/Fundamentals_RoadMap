#pragma once
#include <iostream>
#include "Car.h"

class FamilyCar : public Car
{
private:
  string CarType = "Family";
  string WheelsType = "Normal Wheels";

public:
  virtual const char* GetCarType()
  {
    return CarType.c_str();
  }

  virtual const char* GetWheelsType()
  {
    return WheelsType.c_str();
  }
};