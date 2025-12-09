# Course 05: Algorithms, Problem Solving & Capstone Projects

This directory contains my solutions to the exercises and capstone projects for **Course 05** of the Backend Engineering Roadmap.

In this phase, the focus shifted from basic syntax to **Algorithmic Thinking** and **System Logic**. I solved over 50 algorithmic problems to master arrays and mathematical logic, and then applied those concepts to build two fully functional console applications.

## 🏆 Capstone Projects

To wrap up the course, I built two interactive console applications that utilize loops, state management, and randomization.

### 1. 🧮 Math Quiz Game (`MathQuiz.cpp`)
A dynamic educational game that tests users with randomly generated math problems.
* **Dynamic Difficulty:** Supports **Easy, Medium, Hard, and Mix** levels. The algorithm adjusts the number ranges based on the selected difficulty (e.g., Hard mode generates numbers between 50-100).
* **Operation Selection:** Users can test specific skills (+, -, *, /) or choose a "Mix" mode for random operations.
* **State Management:** Uses custom `structs` to track the quiz state, including right/wrong answers and final pass/fail status.
* **Visual Feedback:** Implements `system("color")` to flash the screen Green (correct) or Red (wrong) for immediate user feedback.

### 2. ✂️ Stone-Paper-Scissors (`ScissorsPaperRock.cpp`)
A complete implementation of the classic game against the computer.
* **Game Loop:** Built with a robust `do-while` loop allowing the user to play multiple "Matches" without restarting the program.
* **Round Logic:** Tracks individual round winners and calculates the overall "Game Winner" after $N$ rounds.
* **Random AI:** The computer generates unpredictable moves using a seeded random number generator.
* **Statistics:** Ends with a "Game Over" screen displaying a full summary of User Wins, Computer Wins, and Draws.

---

## 📂 Algorithmic Problems (The Core Logic)

Before building the projects, I solved 50+ problems to master **Arrays** and recreate standard C++ library functions from scratch to understand how they work "under the hood."

### 1. 📊 Array Operations (The Core Focus)
Extensive practice with static arrays, covering almost every standard operation:
* **Basic Operations:** Calculating Sum, Average, Max, and Min of random arrays.
* **Search & Filter:**
    * Linear Search algorithms (returning index or boolean).
    * Filtering logic (e.g., extracting only Odd, Prime, or Distinct numbers into a new array).
* **Advanced Manipulation:**
    * **Deep Copying:** Copying arrays element-by-element.
    * **Reversal:** Inverting an array in place or to a new buffer.
    * **Shuffling:** Implementing a custom shuffle algorithm using random swapping.
    * **Vector Math:** Logic for adding two arrays together.
    * **Palindrome Check:** Verifying if an array sequence is symmetrical.

### 2. 🔢 Advanced Math & Number Theory
Algorithms to analyze and manipulate integers at the bit/digit level:
* **Prime & Perfect Numbers:**
    * Algorithms to efficiently check for **Prime** and **Perfect** numbers.
    * Generating lists of primes within a specific range.
* **Digit Manipulation:**
    * **Reverse Number:** Reversing integers mathematically (using Modulo `%` and Division `/`) without string conversion.
    * **Digit Frequency:** Counting how often a specific digit appears in a number.
    * **Palindrome Checker:** Verifying if a number reads the same forwards and backwards.

### 3. 🛠️ Recreating Standard Library Functions
Instead of blindly using `cmath` or `std`, I implemented my own versions to understand the internal logic:
* **`MyABS()`**: Logic for absolute values.
* **`MyCeil()` & `MyFloor()`**: Manual rounding up and down logic.
* **`MyRound()`**: Standard rounding logic (handling the .5 threshold).
* **`MySqrt()`**: Mathematical calculation of square roots.

### 4. 🔐 Security & Randomness
* **Key Generator:** A system to generate random license keys (e.g., `XXXX-XXXX-XXXX-XXXX`) using Enums for character types (Capital, Digit, Special).
* **Encryption:** A simple Caesar Cipher implementation (shifting ASCII values by a key).
* **Brute Force:** An algorithm to generate all possible 3-letter passwords (`AAA` to `ZZZ`) to match a target password.

### 5. 📐 Patterns & Nested Loops
* **Inverted Patterns:** Logic to print numbers or letters in descending triangle formations.
* **Letter Combinations:** Generating all possible letter permutations using triple nested loops.

## 🛠️ Tech Stack
* **Language:** C++
* **Key Concepts:**
    * **Structs & Enums:** Used heavily to organize Game/Quiz data and difficulty levels.
    * **Modular Programming:** Breaking big games into small, reusable functions (`StartGame`, `PlayRound`, `GameOver`).
    * **Randomization:** Using `srand(time(NULL))` for unpredictable game outcomes.
    * **System Commands:** `system("cls")` and `system("color")` for UI experience.

## 🚀 How to Run
To run the Math Quiz or Stone-Paper-Scissors game:

1.  **Compile:**
    ```bash
    g++ MathQuiz.cpp -o QuizApp
    ```
2.  **Run:**
    ```bash
    ./QuizApp
    ```

## 📝 Key Takeaways
* **State Management:** The projects taught me how to pass "Game State" (scores, round numbers) effectively between functions.
* **Algorithmic Efficiency:** I learned to solve problems mathematically (e.g., using Modulo `%` to extract digits) rather than converting everything to strings.
* **Input Validation:** Implemented checks (e.g., `while` loops) to ensure users enter valid difficulty levels, preventing program crashes.

---
*This repository documents my journey in mastering Backend Engineering.*
