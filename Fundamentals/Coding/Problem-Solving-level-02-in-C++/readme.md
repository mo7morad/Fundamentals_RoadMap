# Course 05: Algorithms & Problem Solving Level 02

This directory contains my solutions to the exercises in **Course 05** of the Backend Engineering Roadmap.

In this phase, the focus shifted from learning syntax to **Algorithmic Thinking**. I solved 50+ problems that required breaking down complex logic into small, reusable functions. A major part of this course was dedicated to mastering **Arrays** and recreating standard C++ library functions from scratch to understand how they work "under the hood."

## 📂 Project Structure & Topics Covered

The solutions are categorized by the algorithmic concepts they demonstrate:

### 1. 🔢 Advanced Math & Number Theory
Algorithms to analyze and manipulate integers at the bit/digit level.
* **Prime & Perfect Numbers:**
    * Checking for **Prime** numbers (and copying them to new arrays).
    * Identifying **Perfect** numbers (sum of divisors equals the number).
    * Printing all Perfect/Prime numbers from 1 to N.
* **Digit Manipulation:**
    * **Reverse Number:** Reversing integers mathematically (modulus/division).
    * **Digit Sum/Frequency:** Calculating the sum of digits or counting how often a specific digit appears.
    * **Palindrome Checker:** Verifying if a number reads the same forwards and backwards.

### 2. 📊 Array Operations (The Core Focus)
Extensive practice with static arrays, covering almost every standard operation.
* **Basic Ops:** calculating Sum, Average, Max, and Min of random arrays.
* **Search & Filter:**
    * Linear Search (returning index or boolean).
    * Filtering arrays (e.g., extracting only Odd, Prime, or Distinct numbers into a new array).
* **Manipulation:**
    * **Array Copying:** Deep copying arrays element by element.
    * **Array Reversal:** Inverting an array in place or to a new buffer.
    * **Array Shuffling:** Implementing a custom shuffle algorithm using random swapping.
    * **Sum of Two Arrays:** Vector addition logic.
    * **Palindrome Array:** Checking if an array sequence is symmetrical.

### 3. 🛠️ Recreating Standard Library Functions
Instead of using `cmath` or `std`, I implemented my own versions of common math functions to understand their logic:
* `MyABS()`: Absolute value.
* `MyCeil()` & `MyFloor()`: Rounding up and down.
* `MyRound()`: Standard rounding logic.
* `MySqrt()`: Calculating square root.

### 4. 🔐 Security & Randomness
* **Key Generator:** Generating random license keys (e.g., `XXXX-XXXX-XXXX-XXXX`) using enums for character types (Capital, Digit, Special).
* **Encryption/Decryption:** A simple Caesar Cipher implementation (shifting characters by a key).
* **Brute Force:** An algorithm to generate all possible 3-letter passwords (`AAA` to `ZZZ`) to crack a target password.

### 5. 📐 Patterns & Nested Loops
* **Inverted Patterns:** Printing numbers or letters in descending triangle formations.
* **Letter Combinations:** Generating all possible letter permutations.

## 🛠️ Tech Stack
* **Language:** C++
* **Libraries Used:** `iostream`, `string`, `cstdlib` (for `rand()` and `srand()`), `ctime` (for seeding randoms).
* **Key Concepts:**
    * Modular Programming (breaking big problems into small functions).
    * Random Number Generation.
    * ASCII Table Manipulation.
    * Pass by Reference vs. Pass by Value.

## 🚀 How to Run
To run any of the problem files:

1.  **Compile:**
    ```bash
    g++ Problem#21.cpp -o KeyGen
    ```
2.  **Run:**
    ```bash
    ./KeyGen
    ```

## 📝 Key Takeaways
* **Array Mastery:** I am now comfortable performing complex operations (filtering, shuffling, distinct copying) on data collections.
* **Algorithmic Efficiency:** Learned to solve problems mathematically (e.g., using Modulo `%` to extract digits) rather than converting everything to strings.
* **Logic Construction:** Building functions like `MyRound` taught me how to handle edge cases that pre-built libraries usually hide.

---
*This repository documents my journey in mastering Backend Engineering.*
