#include <iostream>
#include "QueueLine.h"

using namespace std;

int main()
{

  QueueLine PayBillsQueue("A0", 10);
  QueueLine SubscriptionsQueue("B0", 5);

  PayBillsQueue.IssueTicket();
  PayBillsQueue.IssueTicket();
  PayBillsQueue.IssueTicket();
  PayBillsQueue.IssueTicket();
  PayBillsQueue.IssueTicket();

  cout << "\nPay Bills Queue Info:\n";
  PayBillsQueue.PrintInfo();

  PayBillsQueue.PrintTicketsLineRTL();
  PayBillsQueue.PrintTicketsLineLTR();

  PayBillsQueue.PrintAllTickets();

  PayBillsQueue.ServeNextClient();
  cout << "\nPay Bills Queue After Serving One client\n";
  PayBillsQueue.PrintInfo();
  PayBillsQueue.PrintTicketsLineRTL();
  PayBillsQueue.PrintAllTickets();

  cout << "\nSubscriptions Queue Info:\n";

  SubscriptionsQueue.IssueTicket();
  SubscriptionsQueue.IssueTicket();
  SubscriptionsQueue.IssueTicket();

  SubscriptionsQueue.PrintInfo();

  SubscriptionsQueue.PrintTicketsLineRTL();
  SubscriptionsQueue.PrintTicketsLineLTR();

  SubscriptionsQueue.PrintAllTickets();

  SubscriptionsQueue.ServeNextClient();
  cout << "\nSubscriptions Queue After Serving One client\n";
  SubscriptionsQueue.PrintInfo();

  return 0;
}
