# Course 07: Algorithms & Problem Solving Level 3

This directory contains my solutions, libraries, and capstone projects for **Course 07** of the Backend Engineering Roadmap.

In this phase, I transitioned from solving isolated problems to building a complete **Console Banking System**. I also mastered the manipulation of **2D Arrays (Matrices)** and built a robust **String Processing Library** from scratch, simulating real-world data processing tasks.

## 🏆 Capstone Project: Console Banking System


I architected a fully functional Banking Application that persists data to the hard drive. This project evolved through two major iterations:

### 📥 Version 1: The Core System (`#52_Project1_Bank-1.cpp`)
A foundational CRUD (Create, Read, Update, Delete) system.
* **Data Persistence:** Users/Clients are saved to a physical file (`ClientsData.txt`), ensuring data survives after the program closes.
* **Data Parsing:** Implemented a custom parser to convert text lines (e.g., `A101#//#1234#//#Name...`) into `sClient` structures and back.
* **Search Engine:** Algorithms to fetch, update, or delete clients by unique Account Numbers.

### 💸 Version 2: Transactions Extension (`#53_Project2_Bank-2.cpp`)
Extended the core system with a financial transaction layer.
* **Deposit & Withdraw:** Logic to modify balances safely, updating the vector in memory and syncing changes to the file.
* **Balance Sheets:** Generates a formatted report of all client balances and calculates the total bank holdings.
* **Modular Architecture:** Separated the "Main Menu" from the "Transactions Menu" for better code organization.

---

## 📂 Algorithms & Libraries

Beyond the project, I solved 50+ problems to master low-level data manipulation.

### 1. 🔢 Matrix (2D Array) Manipulation
I built a suite of functions to handle complex 3x3 matrix operations:
* [cite_start]**Core Ops:** Random generation `[cite: 7][cite_start]`, Row/Column Summation `[cite: 27, 67][cite_start]`, and Transposing matrices `[cite: 109]`.
* **Advanced Math:**
    * [cite_start]**Matrix Multiplication:** Implemented the mathematical logic to multiply two 3x3 matrices `[cite: 126]`.
    * [cite_start]**Comparison:** Algorithms to check if matrices are **Equal** `[cite: 192][cite_start]`, **Typical** `[cite: 215][cite_start]`, or **Scalar** `[cite: 263]`.
    * [cite_start]**Special Types:** Detection logic for **Identity Matrices** `[cite: 238][cite_start]`, **Sparse Matrices** `[cite: 320][cite_start]`, and **Palindrome Matrices** `[cite: 421]`.
* [cite_start]**Search & Intersection:** Finding Min/Max values `[cite: 399, 402][cite_start]` and identifying intersected numbers between two matrices `[cite: 376]`.

### 2. 📝 String Processing Library
Instead of using standard libraries, I built my own string utilities to understand parsing and text manipulation:
* **Parsing & Tokenization:**
    * [cite_start]`SplitString`: Breaks a long string into a `vector` of words based on any delimiter `[cite: 633]`.
    * [cite_start]`JoinString`: Reverses the process, joining a vector into a single string `[cite: 665]`.
* **Trimming & Cleaning:**
    * [cite_start]`TrimLeft` / `TrimRight`: Manually removing whitespace from string edges `[cite: 648, 650]`.
    * [cite_start]`RemovePunctuations`: Cleaning strings of special characters `[cite: 741]`.
* **Analysis:**
    * [cite_start]Counting Words `[cite: 608][cite_start]`, Vowels `[cite: 567][cite_start]`, and Letter frequency `[cite: 537]`.
    * [cite_start]**Case Inverter:** Logic to swap Case (Upper/Lower) for characters `[cite: 481]` or entire strings.

## 🛠️ Tech Stack
* **Language:** C++
* **Data Structures:** `std::vector`, `struct`, 2D Arrays.
* **File I/O:** `fstream` (Read/Write/Append modes).
* **String Manipulation:** Custom string parsing algorithms.

## 🚀 How to Run
To run the Banking System:

1.  **Compile:**
    ```bash
    g++ "#02_SumOfMatrixRow.cpp" -o SumOfMatrix
    ```
2.  **Run:**
    ```bash
    ./BankApp
    ```

## 📝 Key Takeaways
* **System Design:** I learned how to separate the **User Interface** (Menus) from the **Business Logic** (Transactions) and the **Data Access Layer** (File I/O).
* **Data Serialization:** Mastered the concept of converting memory objects (`structs`) into storage formats (Strings) and back.
* **Complex Logic:** Solving Matrix multiplication and recursion problems sharpened my ability to handle nested loops and multi-dimensional data.

---
*This repository documents my journey in mastering Backend Engineering.*
