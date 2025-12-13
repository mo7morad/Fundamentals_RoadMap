# 🏧 ATM System Console App

**A client-facing simulation of an Automated Teller Machine (ATM) interface.**

Unlike the Bank Admin system, this application is designed for the **Bank Clients**. It allows them to log in with their Account Number and PIN to perform quick transactions and check their balances.

## ✨ Features

* **Quick Withdraw:** A fast-action menu with predefined cash denominations ($20, $50, $100, $200, $400, $600, $800, $1000).
* **Normal Withdraw:** Allows entering a custom amount (must be a multiple of 5).
* **Deposit:** Adds funds securely to the user's account.
* **Balance Check:** Real-time query of the `Clients.txt` database to show available funds.
* **Shared Database:** Seamlessly integrates with the Bank Admin system by reading/writing to the same `Clients.txt` file.

## 🛠️ Technical Highlights

* **Client Authentication:** Validates `AccountNumber` and `PinCode` against the database before granting access.
* **Input Validation:** Ensures withdrawal amounts do not exceed the current balance.
* **Reusable Logic:** Reuses the core file parsing logic (`LoadClientsDataFromFile`, `SaveClientsDataToFile`) from the main banking project.

## 🚀 How to Run

1.  **Compile:**
    ```bash
    g++ ATM-System-Project.cpp -o ATMApp
    ```
2.  **Run:**
    ```bash
    ./ATMApp
    ```
    *Test Credentials (from clients.txt):* `Account: A155`, `Pin: 83928`
