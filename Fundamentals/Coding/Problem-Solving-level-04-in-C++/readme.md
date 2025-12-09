# Course 08: Algorithms Level 4 & System Security

This directory contains my solutions, libraries, and capstone projects for **Course 08** of the Backend Engineering Roadmap.

In this phase, I focused on two major pillars of software engineering: **Business Logic Implementation** (building a massive Date/Time library from scratch) and **System Security** (implementing users, permissions, and access control).

## 🏆 Capstone Projects

I extended my previous Banking System into a suite of applications, separating the "Admin" view from the "Client" view.

### 1. 🏧 ATM System (`ATM-System-Project.cpp`)
A client-facing console application simulating a real ATM interface.
* **Client Authentication:** Users login with their unique `AccountNumber` and `PinCode`.
* **Quick Withdraw:** A fast-action menu with predefined cash amounts ($20, $50, $100, etc.) for rapid transactions.
* **Balance Validation:** Logic to ensure withdrawal amounts do not exceed the user's balance or be non-multiples of 5.
* **Deposit:** Adds funds to the user's account and updates the database file immediately.
* **Shared Database:** Connects to the same `ClientsData.txt` file used by the Bank Admin system, simulating a real centralized database.

### 2. 🛡️ Bank System V3: Security & Permissions (`ProjectContinuation-BankExtension2.cpp`)
I upgraded the Bank Admin System to support multi-user access with granular permissions.
* **User Management:** A full CRUD system for System Users (Admins/Tellers), separate from Bank Clients.
* **Bitwise Permissions:** Implemented a permission system using **Bitwise Operators** (`&`, `|`, `~`).
    * Example: `ShowClientsList = 1 << 0`, `AddClient = 1 << 1`.
    * This allows storing complex access rights (e.g., "Can Add and Delete but not Update") in a single integer.
* **Access Control:** Every menu action (e.g., "Delete Client") checks the logged-in user's permission bitmask before execution. If they lack the bit, access is denied.

---

## 📅 The Date & Time Library

A significant portion of this course was dedicated to building a reusable **Date Library** containing over 65 functions. Instead of relying on `<ctime>`, I implemented the mathematical logic for every operation manually.

### 1. Core Calendar Logic
* **Leap Year Calculus:** Algorithms to determine Leap Years (divisible by 4 but not 100, unless by 400).
* **Date Validation:** Logic to check if a date like `31/2/2023` is valid or impossible.
* **Calendar Generation:** Logic to print a formatted monthly or yearly calendar, calculating exactly which day of the week the month starts on.

### 2. Date Arithmetic (The "Time Machine")
* **Add/Subtract:** Functions to increase or decrease a date by Days, Weeks, Months, Years, Decades, or Centuries.
* **Difference Calculator:** Calculating the exact age in days or the difference between two dates (including or excluding the end day).
* **"End of" Logic:** Calculating days remaining until the end of the Week, Month, or Year.

### 3. Business Logic Implementation
* **Business Days:** Algorithms to check if a specific date is a Weekend or a Business Day.
* **Vacation Calculator:** A complex function that calculates the return date given a start date and `N` vacation days, **automatically skipping weekends**.
* **Period Overlap:** Logic to detect if two date ranges overlap and calculate the length of that overlap (useful for booking systems).

### 4. Parsing & Formatting
* **Number to Text:** A recursive algorithm to convert integers (e.g., `1234`) into English text ("One Thousand Two Hundred Thirty-Four").
* **Date Parsing:** Converting string dates (`"2023/10/01"`) into Date objects and vice versa.
* **Dynamic Formatting:** A function accepting a format string (e.g., `"mm-dd-yyyy"`) and returning the formatted date.

## 🛠️ Tech Stack
* **Language:** C++
* **Concepts:**
    * **Bitwise Operators:** For managing User Permissions efficiently.
    * **Structs:** For `stDate`, `stPeriod`, `stUser`, and `stClient`.
    * **Math Logic:** Modulo arithmetic for day-of-week calculations.
    * **File I/O:** Centralized data storage for Clients and Users.

## 🚀 How to Run
To run the ATM System:

1.  **Compile:**
    ```bash
    g++ ATM-System-Project.cpp -o ATM
    ```
2.  **Run:**
    ```bash
    ./ATM
    ```
    *(Use Account: `A155`, Pin: `1234` to test)*

## 📝 Key Takeaways
* **Security First:** I learned that features should be "locked by default." Permissions must be checked *before* showing the menu option.
* **Bitwise Power:** Using bits for permissions is incredibly memory efficient and standard in systems programming.
* **Edge Cases:** Building the Date Library taught me to handle tricky edge cases (e.g., subtracting a month from `March 31st` landing on `Feb 28th` or `29th`).

---
*This repository documents my journey in mastering Backend Engineering.*
