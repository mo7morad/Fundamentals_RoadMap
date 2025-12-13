# 🛡️ Bank System V3: Security & User Management

**A multi-user banking environment with role-based access control (RBAC), user management, and secure authentication.**

This project expands the previous Banking System by introducing a **Security Layer**. It shifts from a single-admin view to a multi-user system where Admins can manage Tellers, and permissions control who can do what.

## 📸 Project Demo

Here is a walkthrough of the security features:

### 1. Secure Authentication
The system now requires a valid Username and Password to enter. It authenticates against the `Users.txt` database.
![Login Screen](../../../../../../Repo%20Images/ATM-System-Upgrade1.png)

### 2. User-Specific Dashboard
Once logged in, the Main Menu personalizes the header (e.g., "Logged as: Morad").
![Main Menu](../../../../../../Repo%20Images/ATM-System-Upgrade2.png)

### 3. Role-Based Access Control (RBAC)
If a user tries to access a feature they don't have permission for (like "Manage Users"), the system blocks them with an "Access Denied" message.
![Access Denied](../../../../../../Repo%20Images/ATM-System-Upgrade3.png)

### 4. User Management Module
Admins with full privileges can access the "Manage Users" screen to List, Add, Update, or Delete system users.
![Manage Users](../../../../../../Repo%20Images/ATM-System-Upgrade4.png)

### 5. Permissions System
Users are assigned permissions using a **Bitwise** system (e.g., `-1` for Full Access, `3` for List+Add).
![User List](../../../../../../Repo%20Images/ATM-System-Upgrade5.png)

## ✨ Key Features

* **Bitwise Permissions:** Efficiently stores complex access rights (Show, Add, Delete, Update, Transactions, Manage Users) in a single integer.
* **Audit Trail:** (Optional extension) The architecture supports logging user activity to track who performed specific actions.
* **Admin Tools:** Full CRUD capabilities for managing the internal staff (Users) separate from the Bank Clients.
* **Persistent Security:** User credentials and permission bits are stored securely in `Users.txt`.

## 🛠️ Technical Highlights

* **Bitwise Operations:** Used `&` (AND) and `|` (OR) operators to check and set permissions.
    * Example: `if (User.Permissions & pTransactions)` checks if the user has the Transaction bit set.
* **Separation of Concerns:** The `User` logic is strictly separated from `Client` logic, ensuring the security layer doesn't interfere with banking operations.

## 🚀 How to Run

1.  **Compile:**
    ```bash
    g++ ProjectContinuation-BankExtension2.cpp -o BankSecurity
    ```
2.  **Run:**
    ```bash
    ./BankSecurity
    ```
    *Default Admin Credentials:* `User: Admin`, `Pass: 1234`
