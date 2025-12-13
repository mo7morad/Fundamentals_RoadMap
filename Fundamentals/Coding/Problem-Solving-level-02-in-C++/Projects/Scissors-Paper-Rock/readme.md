# ✂️ Stone-Paper-Scissors Game

**A classic console-based implementation of the popular hand game, playing against the Computer.**

This project focuses on **Game Loop Logic**, **Conditional Checks**, and **Statistical Tracking** to create a complete game session experience.

## 📸 Project Demo

Here is a walkthrough of the game flow:

### 1. Round Logic & Gameplay
The user chooses the number of rounds (1-10). For each round, the computer generates a random move, compares it with the user's choice, and declares a round winner.
![Game Flow](../../../../../Repo%20Images/ScissorsPaperRock1.png)

### 2. Game Over & Statistics
Once all rounds are completed, the system calculates the total wins for both sides and declares the final "Grand Winner" of the match.
![Game Over](../../../../../Repo%20Images/ScissorsPaperRock2.png)

## ✨ Features

* **Robust Game Loop:** Handles multiple rounds in a single session without restarting the application.
* **Smart Validation:** Prevents invalid inputs (e.g., choosing a number outside 1-3 or invalid round counts).
* **Statistical Engine:** Tracks:
    * User Win Count
    * Computer Win Count
    * Draw Count
* **Replay System:** Allows the user to start a new match immediately after finishing one.

## 🛠️ Technical Highlights

* **Enums (`enGameChoices`, `enWinner`):** Used to represent game states (Rock, Paper, Scissors) and outcomes (Player1, Computer, Draw) for readable, maintainable code.
* **Modular Design:** separated logic for `CheckRoundWinner`, `PrintResults`, and `GameOver` statistics.
* **Randomization:** Utilization of `rand()` and `srand(time(NULL))` to ensure the Computer's moves are unpredictable every time.

## 🚀 How to Run

1.  **Compile the code:**
    ```bash
    g++ ScissorsPaperRock.cpp -o GameApp
    ```
2.  **Run the executable:**
    ```bash
    ./GameApp
    ```
