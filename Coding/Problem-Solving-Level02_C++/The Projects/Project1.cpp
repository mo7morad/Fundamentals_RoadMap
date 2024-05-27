#include <iostream>
#include <cmath>
using namespace std;

enum enGameChoices
{
  Scissors = 1,
  Paper = 2,
  Rock = 3
};

enum enWinner
{
  Pc = 1,
  User = 2,
  NoWinner = 3
};

string GameChoiceToString(enGameChoices choice)
{
  switch (choice)
  {
  case Scissors:
    return "Scissors";
  case Paper:
    return "Paper";
  case Rock:
    return "Rock";
  default:
    return "UNKNOWN";
  }
}

string WinnerToString(enWinner winner)
{
  switch (winner)
  {
  case Pc:
    return "Pc";
  case User:
    return "User";
  case NoWinner:
    return "NoWinner";
  default:
    return "UNKNOWN";
  }
}

int RandomNumber(int From, int To)
{
  int randNum = rand() % (To - From + 1) + From;
  return randNum;
};

int GetRounds()
{
  int Rounds = 0;
  do
  {
    cout << "How many rounds you want to play? Please choose from 1 to 10 rounds:  " << endl;
    cin >> Rounds;
  } while (Rounds <= 0 && Rounds > 10);
  return Rounds;
};

enGameChoices GetPcChoice(){
  return (enGameChoices)RandomNumber(1, 3);
};

enGameChoices GetUserChoice(){
  int UserChoice = 0;

  do{
    cout << "What's your choice: Scissors[1] / Paper[2] / Rock[3]? " << endl;
    cin >> UserChoice;
  }while(UserChoice > 3 && UserChoice <= 0);
  return (enGameChoices)UserChoice;
};

enWinner CheckRoundWinner(enGameChoices PcChoice, enGameChoices UserChoice)
{
  if (PcChoice == UserChoice)
    return NoWinner;
  else{
    if (PcChoice == Scissors)
    {
      if (UserChoice == Paper)
        return Pc;
      if (UserChoice == Rock)
        return User;
    }
    if (PcChoice == Paper)
    {
      if (UserChoice == Scissors)
        return User;
      if (UserChoice == Rock)
        return Pc;
    }
    if (PcChoice == Rock)
    {
      if (UserChoice == Paper)
        return User;
      if (UserChoice == Scissors)
        return Pc;
    }
  }
  return NoWinner;
};

void PrintResults(enGameChoices PcChoice, enGameChoices UserChoice, enWinner RoundWinner){
  cout << "User Choice is: " << GameChoiceToString(UserChoice) << endl;
  cout << "Computer Choice is: " << GameChoiceToString(PcChoice) << endl;
  cout << "Round Winner is: " << WinnerToString(RoundWinner) << endl;
};

bool ValidatePlayAgain(){
  char PlayAgain = ' ';
  do{
    cout << "Play Again? [Y/N] " << endl;
    cin >> PlayAgain;
    PlayAgain = toupper(PlayAgain);
    }while(PlayAgain != 'Y' && PlayAgain != 'N');
  if (PlayAgain == 'Y')
    return true;
  else
    return false;
}


void GameOver(int GameRounds, int UserWonRounds, int ComputerWonRounds, int DrawRounds){
  cout << "____________________________________________________________________\n" << endl;
  cout << "========================== G a m e O v e r =========================\n" << endl;
  cout << "____________________________________________________________________\n" << endl;
  cout << "_____________________ [Game Scores And Final Results] ______________\n" << endl;

  cout << "Game Rounds: " << GameRounds << endl;
  cout << "User Won Rounds: " << UserWonRounds << endl;
  cout << "Computer Won Rounds: " << ComputerWonRounds << endl;
  cout << "Draw Rounds: " << DrawRounds << endl;
  cout << "Final Winner: ";
  if (UserWonRounds > ComputerWonRounds)
    cout << "User Wins!\n";
  else if (UserWonRounds < ComputerWonRounds)
    cout << "Computer Wins!\n";
  else
    cout << "No Winner; Draw!\n";
};

void StartTheGame(){

  do{
    int Rounds = GetRounds(); int UserWonRounds = 0; int PcWonRounds = 0; int DrawRounds = 0;
    for (int i = 1; i <= Rounds; i++)
    {
      cout << "\nRound [" << i << "] begins: " << endl;
      enGameChoices PcChoice = GetPcChoice();
      enGameChoices UserChoice = GetUserChoice();
      cout << "_____________________ Round [" << i << "] _____________________" << endl;
      PrintResults(PcChoice, UserChoice, CheckRoundWinner(PcChoice, UserChoice));
      if (CheckRoundWinner(PcChoice, UserChoice) == NoWinner)
        DrawRounds++;
      if (CheckRoundWinner(PcChoice, UserChoice) == Pc)
        PcWonRounds++;
      if (CheckRoundWinner(PcChoice, UserChoice) == User)
        UserWonRounds++;
      cout << "_______________________________________________________\n";
      if (i == Rounds)
        GameOver(Rounds, UserWonRounds, PcWonRounds, DrawRounds);
    }
  } while(ValidatePlayAgain());
}








int main()
{
  srand((unsigned)time(NULL));
  StartTheGame();
  return 0;
}