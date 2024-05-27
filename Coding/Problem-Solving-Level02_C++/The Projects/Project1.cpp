// #include <iostream>
// #include <cmath>
// using namespace std;

// enum enGameChoices
// {
//   Scissors = 1,
//   Paper = 2,
//   Rock = 3
// };

// enum enWinner
// {
//   Pc = 1,
//   User = 2,
//   NoWinner = 3
// };

// string GameChoiceToString(enGameChoices choice)
// {
//   switch (choice)
//   {
//   case Scissors:
//     return "Scissors";
//   case Paper:
//     return "Paper";
//   case Rock:
//     return "Rock";
//   default:
//     return "UNKNOWN";
//   }
// }

// string WinnerToString(enWinner winner)
// {
//   switch (winner)
//   {
//   case Pc:
//     return "Pc";
//   case User:
//     return "User";
//   case NoWinner:
//     return "NoWinner";
//   default:
//     return "UNKNOWN";
//   }
// }

// int RandomNumber(int From, int To)
// {
//   int randNum = rand() % (To - From + 1) + From;
//   return randNum;
// };

// int GetRounds()
// {
//   int Rounds = 0;
//   do
//   {
//     cout << "How many rounds you want to play? Please choose from 1 to 10 rounds:  " << endl;
//     cin >> Rounds;
//   } while (Rounds <= 0 && Rounds > 10);
//   return Rounds;
// };

// enGameChoices GetPcChoice(){
//   return (enGameChoices)RandomNumber(1, 3);
// };

// enGameChoices GetUserChoice(){
//   int UserChoice = 0;

//   do{
//     cout << "What's your choice: Scissors[1] / Paper[2] / Rock[3]? " << endl;
//     cin >> UserChoice;
//   }while(UserChoice > 3 && UserChoice <= 0);
//   return (enGameChoices)UserChoice;
// };

// enWinner CheckRoundWinner(enGameChoices PcChoice, enGameChoices UserChoice)
// {
//   if (PcChoice == UserChoice)
//     return NoWinner;
//   else{
//     if (PcChoice == Scissors)
//     {
//       if (UserChoice == Paper)
//         return Pc;
//       if (UserChoice == Rock)
//         return User;
//     }
//     if (PcChoice == Paper)
//     {
//       if (UserChoice == Scissors)
//         return User;
//       if (UserChoice == Rock)
//         return Pc;
//     }
//     if (PcChoice == Rock)
//     {
//       if (UserChoice == Paper)
//         return User;
//       if (UserChoice == Scissors)
//         return Pc;
//     }
//   }
//   return NoWinner;
// };

// void PrintResults(enGameChoices PcChoice, enGameChoices UserChoice, enWinner RoundWinner){
//   cout << "User Choice is: " << GameChoiceToString(UserChoice) << endl;
//   cout << "Computer Choice is: " << GameChoiceToString(PcChoice) << endl;
//   cout << "Round Winner is: " << WinnerToString(RoundWinner) << endl;
// };

// bool ValidatePlayAgain(){
//   char PlayAgain = ' ';
//   do{
//     cout << "Play Again? [Y/N] " << endl;
//     cin >> PlayAgain;
//     PlayAgain = toupper(PlayAgain);
//     }while(PlayAgain != 'Y' && PlayAgain != 'N');
//   if (PlayAgain == 'Y')
//     return true;
//   else
//     return false;
// }


// void GameOver(int GameRounds, int UserWonRounds, int ComputerWonRounds, int DrawRounds){
//   cout << "____________________________________________________________________\n" << endl;
//   cout << "========================== G a m e O v e r =========================\n" << endl;
//   cout << "____________________________________________________________________\n" << endl;
//   cout << "_____________________ [Game Scores And Final Results] ______________\n" << endl;

//   cout << "Game Rounds: " << GameRounds << endl;
//   cout << "User Won Rounds: " << UserWonRounds << endl;
//   cout << "Computer Won Rounds: " << ComputerWonRounds << endl;
//   cout << "Draw Rounds: " << DrawRounds << endl;
//   cout << "Final Winner: ";
//   if (UserWonRounds > ComputerWonRounds)
//     cout << "User Wins!\n";
//   else if (UserWonRounds < ComputerWonRounds)
//     cout << "Computer Wins!\n";
//   else
//     cout << "No Winner; Draw!\n";
// };

// void StartTheGame(){

//   do{
//     int Rounds = GetRounds(); int UserWonRounds = 0; int PcWonRounds = 0; int DrawRounds = 0;
//     for (int i = 1; i <= Rounds; i++)
//     {
//       cout << "\nRound [" << i << "] begins: " << endl;
//       enGameChoices PcChoice = GetPcChoice();
//       enGameChoices UserChoice = GetUserChoice();
//       cout << "_____________________ Round [" << i << "] _____________________" << endl;
//       PrintResults(PcChoice, UserChoice, CheckRoundWinner(PcChoice, UserChoice));
//       if (CheckRoundWinner(PcChoice, UserChoice) == NoWinner)
//         DrawRounds++;
//       if (CheckRoundWinner(PcChoice, UserChoice) == Pc)
//         PcWonRounds++;
//       if (CheckRoundWinner(PcChoice, UserChoice) == User)
//         UserWonRounds++;
//       cout << "_______________________________________________________\n";
//       if (i == Rounds)
//         GameOver(Rounds, UserWonRounds, PcWonRounds, DrawRounds);
//     }
//   } while(ValidatePlayAgain());
// }

// int main()
// {
//   srand((unsigned)time(NULL));
//   StartTheGame();
//   return 0;
// }

///////////////////////////////////////////////////// Course Code ///////////////////////////////////////////////////////////////////////////////

#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;

enum enGameChoice
{
  Stone = 1,
  Paper,
  Scissors
};
enum enWinner
{
  Player1 = 1,
  Computer,
  Draw
};

struct stRoundInfo
{
  short RoundNumber = 0;
  enGameChoice Player1Choice;
  enGameChoice ComputerChoice;
  enWinner Winner;
  string WinnerName;
};

struct stGameResults
{
  short GameRounds = 0;
  short Player1WinTimes = 0;
  short ComputerWinTimes = 0;
  short DrawTimes = 0;
  enWinner GameWinner;
  string WinnerName = "";
};

int RandomNumber(int From, int To)
{
  // Function to generate a random number
  int randNum = rand() % (To - From + 1) + From;
  return randNum;
}

string WinnerName(enWinner Winner)
{
  string arrWinnerName[3] = {"Player1", "Computer", "No Winner"};
  return arrWinnerName[Winner - 1];
}

enWinner WhoWonTheRound(stRoundInfo RoundInfo)
{
  if (RoundInfo.Player1Choice == RoundInfo.ComputerChoice)
  {
    return enWinner::Draw;
  }
  switch (RoundInfo.Player1Choice)
  {
  case enGameChoice::Stone:
    if (RoundInfo.ComputerChoice == enGameChoice::Paper)
    {
      return enWinner::Computer;
    }
    break;
  case enGameChoice::Paper:
    if (RoundInfo.ComputerChoice == enGameChoice::Scissors)
    {
      return enWinner::Computer;
    }
    break;
  case enGameChoice::Scissors:
    if (RoundInfo.ComputerChoice == enGameChoice::Stone)
    {
      return enWinner::Computer;
    }
    break;
  }
  // if you reach here then player1 is the winner
  return enWinner::Player1;
}

string ChoiceName(enGameChoice Choice)
{
  string arrGameChoices[3] = {"Stone", "Paper", "Scissors"};
  return arrGameChoices[Choice - 1];
}

void SetWinnerScreenColor(enWinner Winner)
{
  switch (Winner)
  {
  case enWinner::Player1:
    system("color 2F"); // turn screen to Green
    break;
  case enWinner::Computer:
    system("color 4F"); // turn screen to Red
    cout << "\a";
    break;
  default:
    system("color 6F"); // turn screen to Yellow
    break;
  }
}

void PrintRoundResults(stRoundInfo RoundInfo)
{
  cout << "\n____________Round [" << RoundInfo.RoundNumber << "]____________\n\n";
  cout << "Player1 Choice: " << ChoiceName(RoundInfo.Player1Choice) << endl;
  cout << "Computer Choice: " << ChoiceName(RoundInfo.ComputerChoice) << endl;
  cout << "Round Winner: [" << RoundInfo.WinnerName << "]\n";
  cout << "__________________________________\n"<< endl;
  SetWinnerScreenColor(RoundInfo.Winner);
}

enWinner WhoWonTheGame(short Player1WinTimes, short ComputerWinTimes)
{
  if (Player1WinTimes > ComputerWinTimes)
    return enWinner::Player1;
  else if (ComputerWinTimes > Player1WinTimes)
    return enWinner::Computer;
  else
    return enWinner::Draw;
}

stGameResults FillGameResults(int GameRounds, short Player1WinTimes, short ComputerWinTimes, short DrawTimes)
{
  stGameResults GameResults;
  GameResults.GameRounds = GameRounds;
  GameResults.Player1WinTimes = Player1WinTimes;
  GameResults.ComputerWinTimes = ComputerWinTimes;
  GameResults.DrawTimes = DrawTimes;
  GameResults.GameWinner = WhoWonTheGame(Player1WinTimes, ComputerWinTimes);
  GameResults.WinnerName = WinnerName(GameResults.GameWinner);
  return GameResults;
}

enGameChoice ReadPlayer1Choice()
{
  short Choice = 1;
  do
  {
    cout << "\nYour Choice: [1]:Stone, [2]:Paper, [3]:Scissors? ";
    cin >> Choice;
  } while (Choice < 1 || Choice > 3);
  return (enGameChoice)Choice;
}

enGameChoice GetComputerChoice()
{
  return (enGameChoice)RandomNumber(1, 3);
}

stGameResults PlayGame(short HowManyRounds)
{
  stRoundInfo RoundInfo;
  short Player1WinTimes = 0, ComputerWinTimes = 0, DrawTimes = 0;
  for (short GameRound = 1; GameRound <= HowManyRounds; GameRound++)
  {
    cout << "\nRound [" << GameRound << "] begins:\n";
    RoundInfo.RoundNumber = GameRound;
    RoundInfo.Player1Choice = ReadPlayer1Choice();
    RoundInfo.ComputerChoice = GetComputerChoice();
    RoundInfo.Winner = WhoWonTheRound(RoundInfo);
    RoundInfo.WinnerName = WinnerName(RoundInfo.Winner);
    // Increase win/Draw counters
    if (RoundInfo.Winner == enWinner::Player1)
      Player1WinTimes++;
    else if (RoundInfo.Winner == enWinner::Computer)
      ComputerWinTimes++;
    else
      DrawTimes++;
    PrintRoundResults(RoundInfo);
  }
  return FillGameResults(HowManyRounds, Player1WinTimes, ComputerWinTimes, DrawTimes);
}

string Tabs(short NumberOfTabs)
{
  string t = "";
  for (int i = 1; i <= NumberOfTabs; i++)
  {
    t += "\t";
  }
  return t;
}

void ShowGameOverScreen()
{
  cout << Tabs(2) << "__________________________________________________________\n\n";
  cout << Tabs(4) << "+++ G a m e O v e r +++\n";
  cout << Tabs(2) << "__________________________________________________________\n\n";
}

void ShowFinalGameResults(stGameResults GameResults)
{
  cout << Tabs(2) << "_____________________ [Game Results]_____________________\n\n";
  cout << Tabs(2) << "Game Rounds: " << GameResults.GameRounds << endl;
  cout << Tabs(2) << "Player1 won times: " << GameResults.Player1WinTimes << endl;
  cout << Tabs(2) << "Computer won times: " << GameResults.ComputerWinTimes << endl;
  cout << Tabs(2) << "Draw times: " << GameResults.DrawTimes << endl;
  cout << Tabs(2) << "Final Winner: " << GameResults.WinnerName << endl;
  cout << Tabs(2) << "___________________________________________________________\n";
  SetWinnerScreenColor(GameResults.GameWinner);
}

short ReadHowManyRounds()
{
  short GameRounds = 1;
  do
  {
    cout << "How Many Rounds 1 to 10 ? \n";
    cin >> GameRounds;
  } while (GameRounds < 1 || GameRounds > 10);
  return GameRounds;
}

void ResetScreen()
{
  system("cls");
  system("color 0F");
}

void StartGame()
{
  char PlayAgain = 'Y';
  do
  {
    ResetScreen();
    stGameResults GameResults = PlayGame(ReadHowManyRounds());
    ShowGameOverScreen();
    ShowFinalGameResults(GameResults);
    cout << endl << Tabs(3) << "Do you want to play again? Y/N? ";
    cin >> PlayAgain;
  } while (PlayAgain == 'Y' || PlayAgain == 'y');
}

int main()
{
  // Seeds the random number generator in C++, called only once
  srand((unsigned)time(NULL));
  StartGame();
  return 0;
}
