# 🧮 Math Quiz Game

**A dynamic console-based educational game built in C++ that generates random math problems based on user-defined difficulty levels.**

This project demonstrates the use of **Structures**, **Enums**, **Random Number Generation**, and **State Management** to create a fully interactive application.

## 📸 Project Demo

Here is a walkthrough of the game flow:

### 1. Game Configuration
The user selects the number of questions, difficulty level (Easy/Med/Hard/Mix), and operation type (+, -, *, /, Mix).
![Game Start](../../../../../Repo%20Images/MathQuiz1.png)

### 2. Gameplay & Validation
The system generates problems dynamically. It provides immediate feedback (Right/Wrong) and shows the correct answer if the user fails.
![Gameplay](../../../../../Repo%20Images/MathQuiz2.png)

### 3. Final Results
At the end of the quiz, a "Pass/Fail" report is generated with a detailed score summary.
![Game Over](../../../../../Repo%20Images/MathQuiz3.png)

## ✨ Features

* **Dynamic Difficulty Engine:**
    * **Easy:** Numbers 1-10.
    * **Medium:** Numbers 10-50.
    * **Hard:** Numbers 50-100.
    * **Mix:** Randomly switches difficulty per question.
* **Operation Modes:** Practice specific skills (e.g., just Multiplication) or test everything with "MixOp".
* **Smart Scoring:** Tracks right and wrong answers to calculate a final "Pass" or "Fail" status based on a 50% threshold.
* **Replayability:** The game loop allows users to restart the quiz instantly without reloading the program.

## 🛠️ Technical Highlights

* **Structs (`stQuestion`, `stQuizz`):** Used to encapsulate all data related to a single question and the overall quiz session.
* **Enums:** used for code readability (`enQuestionsLevel::Hard`, `enOperationType::Mult`).
* **Randomization:** Uses `rand()` seeded with `time(0)` to ensure every quiz session is unique.
* **Input Validation:** Prevents crashes by validating user menu choices.

## 🚀 How to Run

1.  **Compile the code:**
    ```bash
    g++ MathQuiz.cpp -o MathQuiz
    ```
2.  **Run the executable:**
    ```bash
    ./MathQuiz
    ```
