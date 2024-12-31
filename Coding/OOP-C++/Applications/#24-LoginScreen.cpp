#include <iostream>
#include "headers/clsLoginScreen.h"

int main()

{
  // prompt the login screen after every logout.
  while(true)
  {
    clsLoginScreen::ShowLoginScreen();
  }
  return 0;
}