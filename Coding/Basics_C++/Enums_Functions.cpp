// // #include <iostream>
// // using namespace std;

// // enum enColors {Blue = 1, Red = 2, Green = 3, Yellow = 4};

// // void PrintColorMenu()
// // {
// //   cout << "\n*****************\n";
// //   cout << "Select a color: \n";
// //   cout << "(1) Blue\n";
// //   cout << "(2) Red\n";
// //   cout << "(3) Green\n";
// //   cout << "(4) Yellow\n";
// //   cout << "\n*****************\n";
// //   cout << "Enter your choice (1-4): ";
// // };

// // enColors ReadColorNumber()
// // {
// //   int ColorNumber;
// //   cin >> ColorNumber;
// //   return (enColors)ColorNumber;
// // };

// // string  GetColorName(enColors Color)
// // {
// //   switch (Color)
// //   {
// //   case enColors::Blue:
// //     return "Blue";
// //     break;
// //   case enColors::Red:
// //     return "Red";
// //     break;
// //   case enColors::Green:
// //     return "Green";
// //     break;
// //   case enColors::Yellow:
// //     return "Yellow";
// //     break;
  
// //   default:
// //     return "Sorry the color you picked doesn't exist!";
// //     break;
// //   }
// // }



// // int main ()
// // {

// // PrintColorMenu();
// // cout << "The color you picked is: " << GetColorName(ReadColorNumber());

// //   return 0;
// // }

// #include <iostream>
// using namespace std;

// enum enWeekDay
// {
//   Sun = 1,
//   Mon = 2,
//   Tue = 3,
//   Wed = 4,
//   Thu = 5,
//   Fri = 6,
//   Sat = 7
// };

// void ShowWeekDayMenue()
// {
//   cout << "************************" << endl;
//   cout << "       Week Days        " << endl;
//   cout << "************************" << endl;
//   cout << "1: Sunday" << endl;
//   cout << "2: Monday" << endl;
//   cout << "3: Tuesday" << endl;
//   cout << "4: Wednesday" << endl;
//   cout << "5: Thursday" << endl;
//   cout << "6: Friday" << endl;
//   cout << "7: Saturday" << endl;
//   cout << "************************" << endl;
//   cout << "Please enter the number of day?" << endl;
// }

// enWeekDay ReadWeekDay()
// {

//   int wd;
//   cin >> wd;
//   return (enWeekDay)wd;
// }

// string GetWeekDayName(enWeekDay WeekDay)
// {

//   switch (WeekDay)
//   {

//   case enWeekDay::Sun:
//     return "Sunday";
//     break;
//   case enWeekDay::Mon:
//     return "Monday";
//     break;
//   case enWeekDay::Tue:
//     return "Tuesday";
//     break;
//   case enWeekDay::Wed:
//     return "Wednesday";
//     break;
//   case enWeekDay::Thu:
//     return "Thursday";
//     break;
//   case enWeekDay::Fri:
//     return "Friday";
//     break;
//   case enWeekDay::Sat:
//     return "Saturday";
//     break;
//   default:
//     return "Not a week day!\n";
//   }
// }

// int main()
// {

//   ShowWeekDayMenue();
//   string Day = GetWeekDayName(ReadWeekDay());
//   cout << "Today is: " << Day;

//   return 0;
// }
