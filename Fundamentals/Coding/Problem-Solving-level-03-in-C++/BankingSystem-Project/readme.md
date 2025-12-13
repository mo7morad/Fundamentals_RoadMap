# 🏦 Console Banking System (Procedural C++)

**A robust console-based banking application capable of managing clients, processing transactions, and persisting data to the hard drive.**

This project represents the culmination of my **Algorithm & Problem Solving Level 3** course. It moves beyond simple algorithms to build a complete software system with a flat-file database backend.

## 📸 Project Demo

Here is a walkthrough of the system's core features:

### 1. Main Dashboard
The application separates administrative tasks (Client Management) from financial operations (Transactions) via a clean menu system.

![Main Menu](../../../../Repo%20Images/BankingSystemPrbLevel3_1.png)

### 2. Client Management (CRUD)
The system allows adding new clients with automatic duplicate detection (preventing two clients from having the same Account Number). It also supports updating, deleting, and finding client records.

![Add Client](../../../../Repo%20Images/BankingSystemPrbLevel3_3.png)

### 3. Reporting & Visualization
Administrators can generate formatted reports of all active clients, showing personal details and current balances in a structured table.

![Client List](../../../../Repo%20Images/BankingSystemPrbLevel3_2.png)

### 4. Financial Transactions
A dedicated transaction menu handles Deposits and Withdrawals. The system updates the "Database" file in real-time, ensuring balances are accurate immediately after a transaction.

![Deposit Transaction](../../../../Repo%20Images/BankingSystemPrbLevel3_4.png)

## ✨ Features

* **Persistent Storage:** All data (Clients, Balances) is saved to `ClientsData.txt`. The system loads this data on startup and saves changes instantly.
* **CRUD Operations:** Full capability to Create, Read, Update, and Delete client records.
* **Transaction Logic:**
    * **Deposit:** Adds funds to a specific account.
    * **Withdraw:** Checks for sufficient funds before deducting.
    * **Total Balances:** Calculates the sum of all money held in the bank.
* **Search Engine:** Efficiently finds clients by Account Number using linear search.

## 🛠️ Technical Highlights

* **File I/O (`fstream`):** Implements a custom parser to convert between C++ Structures and text-based records (e.g., `A101#//#Pin#//#Name...`).
* **Modular Architecture:** The code is split into logical functions (`ShowMainMenu`, `ShowTransactionsMenu`, `LoadDataFromFile`) to maintain readability.
* **Data Structures:** Uses `vector<sClient>` to manage the list of clients dynamically in memory.
* **Input Validation:** Ensures the user enters valid menu choices and numeric values for transactions.

## 🚀 How to Run

1.  **Compile the code:**
    ```bash
    g++ BankSystem.cpp -o BankApp
    ```
2.  **Run the executable:**
    ```bash
    ./BankApp
    ```
    *(Note: Ensure you have write permissions in the folder so the program can create/update `ClientsData.txt`)*
