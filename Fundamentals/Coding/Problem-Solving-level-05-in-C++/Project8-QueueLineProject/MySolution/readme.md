# 🎫 Queue Line Management System

**A console-based simulation of a real-world Waiting Queue (e.g., Bank, Hospital, or Customer Service).**

This project demonstrates the practical application of the **Queue** Data Structure. It visualizes the flow of clients, calculates estimated wait times, and manages a dynamic list of tickets.

## ✨ Features

* **Ticket Issuing:** Generates sequential tickets (e.g., A01, A02) with a timestamp.
* **Wait Time Calculation:** dynamically estimates how many minutes a client must wait based on:
    * Their position in the line.
    * The average serving time per client.
* **Visual Queue:** Renders the queue in the console, showing the flow from **Right-to-Left** or **Left-to-Right**.
* **Service Simulation:** Allows "Serving" the next client, which removes them from the front of the queue and updates the waiting list for everyone else.

## 🛠️ Technical Highlights

* **Data Structure:** Built on top of a generic `queue` (or my custom `Queue` class) to strictly enforce FIFO (First-In, First-Out) logic.
* **Business Logic:**
    * **Prefix Handling:** Separates the ticket prefix ("A") from the number ("01") to manage counters.
    * **Time Calculation:**
        $$Time = (\text{TicketNumber} - 1) \times \text{ServingTime}$$
* **Struct Design:** Uses a `_Ticket` struct to encapsulate all metadata for a single request:
    * `IssuingTime` (String)
    * `WaitingList` (Int)
    * `EstimatedServeTime` (Int)

## 📂 Code Structure

* **`QueueLine.h`:** The core class containing all logic. It handles the `queue<_Ticket>` and provides methods like `IssueTicket()` and `ServeNextClient()`.
* **`main.cpp`:** The entry point. It creates multiple queues (e.g., "Pay Bills Queue", "Subscriptions Queue") to demonstrate the system handling independent lines simultaneously.

## 🚀 How to Run

1.  **Compile:**
    ```bash
    g++ main.cpp -o QueueSim
    ```
2.  **Run:**
    ```bash
    ./QueueSim
    ```

## 📸 Sample Output
```text
Pay Bills Queue Info:
  Prefix          : A0
  Total Tickets   : 5
  Served Clients  : 0
  Waiting Clients : 5
  Next Ticket     : A01

Tickets Line:
A01 <-- A02 <-- A03 <-- A04 <-- A05 <-- END
