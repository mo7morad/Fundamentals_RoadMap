#pragma once
#include <iostream>
#include <iomanip>
#include <queue>
#include <sstream>
#include "../Dependencies/clsDate.h"

using namespace std;

class QueueLine
{
private:
  struct _Ticket
  {
    string IssuingTime;
    int TicketNumber;
    int WaitingList;
    int TimeToServe;
  };

  string _Prefix = "";
  string _FullPrefix = "";
  int _TicketCounter = 0;
  int _ServingTime = 0;
  queue<_Ticket> _TicketsQueue;

  static void _DrawScreenHeader(const string &Title, const string &SubTitle = "")
  {
    cout << "\n\t\t\t\t\t======================================" << endl;
    cout << "\t\t\t\t\t  " << Title << endl;
    if (!SubTitle.empty())
    {
      cout << "\t\t\t\t\t  " << SubTitle << endl;
    }
    cout << "\t\t\t\t\t======================================" << endl;
    cout << "\t\t\t\t\t Date: " << clsDate::GetSystemDateTimeString() << "\n\n";
  }

  void _SetPrefix(const string &FullPrefix)
  {
    for (short i = 0; i < FullPrefix.length(); i++)
    {
      if (!isdigit(FullPrefix[i]))
        _Prefix += FullPrefix[i];
    }
  }

  void _SetTicketCounter(const string &FullPrefix)
  {
    for (short i = 0; i < FullPrefix.length(); i++)
    {
      if (isdigit(FullPrefix[i]))
      {
        _TicketCounter = stoi(FullPrefix.substr(i));
        break;
      }
    }
  }

public:
  QueueLine(const string &Prefix, const int &ServingTime)
  {
    _SetPrefix(Prefix);
    _SetTicketCounter(Prefix);
    _FullPrefix = Prefix;
    _ServingTime = ServingTime;
  }

  void IssueTicket()
  {
    _TicketCounter++;

    _Ticket Ticket;
    Ticket.IssuingTime = clsDate::GetSystemDateTimeString();
    Ticket.TicketNumber = _TicketCounter;
    Ticket.WaitingList = _TicketCounter - 1;
    Ticket.TimeToServe = (_TicketCounter - 1) * _ServingTime;

    _TicketsQueue.push(Ticket);
  }

  void PrintInfo()
  {
    _DrawScreenHeader("\t\tQueue Info");

    cout << "\t\t\t\t\t  Prefix          : " << _FullPrefix << endl;
    cout << "\t\t\t\t\t  Total Tickets   : " << _TicketCounter << endl;
    cout << "\t\t\t\t\t  Served Clients  : " << (_TicketCounter - _TicketsQueue.size()) << endl;
    cout << "\t\t\t\t\t  Waiting Clients : " << _TicketsQueue.size() << endl;

    if (!_TicketsQueue.empty())
    {
      cout << "\t\t\t\t\t  Next Ticket     : " << _Prefix << setfill('0') << setw(2) << _TicketsQueue.front().TicketNumber << endl;
    }
    else
    {
      cout << "\t\t\t\t\t  Next Ticket     : No tickets available." << endl;
    }

    cout << "\t\t\t\t\t======================================\n" << endl;
  }

  void PrintTicketsLineRTL()
  {
    cout << "\n  Tickets Line : ";
    if (_TicketsQueue.empty())
    {
      cout << "No tickets in queue." << endl;
      return;
    }

    int size = _TicketsQueue.size();
    int startTicket = _TicketsQueue.front().TicketNumber;
    for (int i = 0; i < size; i++)
    {
      cout << _Prefix << setfill('0') << setw(2) << (startTicket + i) << " <-- ";
    }
    cout << "END" << endl;
  }

  void PrintTicketsLineLTR()
  {
    cout << "\n  Tickets Line : ";
    if (_TicketsQueue.empty())
    {
      cout << "No tickets in queue." << endl;
      return;
    }
    int size = _TicketsQueue.size();
    int startTicket = _TicketsQueue.front().TicketNumber;
    for (int i = size - 1; i >= 0; i--)
    {
      cout << _Prefix << setfill('0') << setw(2) << (startTicket + i) << " --> ";
    }
    cout << "START" << endl;
  }

  void PrintAllTickets()
  {
    queue<_Ticket> TempQueue = _TicketsQueue;
    cout << "\n\n\t\t\t\t\t\t --Tickets--" << endl;
    cout << "\t\t\t\t\t_______________________________\n";

    if (_TicketsQueue.empty())
    {
      cout << "\t\t\t\t\t  No tickets in queue." << endl;
      return;
    }

    while (!TempQueue.empty())
    {
      cout << "\n\t\t\t\t\t\t\t" << _Prefix << setfill('0') << setw(2) << (TempQueue.front().TicketNumber) << endl;
      cout << "\t\t\t\t\t  " << TempQueue.front().IssuingTime << endl;
      cout << "\t\t\t\t\t  Waiting List: " << TempQueue.front().WaitingList << endl;
      cout << "\t\t\t\t\t  Estimated Serving Time In: " << TempQueue.front().TimeToServe << "Minutes" << endl;
      TempQueue.pop();
      cout << "\t\t\t\t\t_______________________________\n";
    }
  }

  void ServeNextClient()
  {
    if (_TicketsQueue.empty())
    {
      cout << "\nNo tickets in queue to serve." << endl;
      return;
    }
    _Ticket servedTicket = _TicketsQueue.front();
    _TicketsQueue.pop();
    cout << "\nNow serving ticket: " << _Prefix << setfill('0') << setw(2) << servedTicket.TicketNumber << endl;
  }
};
