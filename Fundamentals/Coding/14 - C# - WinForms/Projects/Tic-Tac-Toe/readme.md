# ❌⭕ Tic-Tac-Toe Game (Windows Forms)

**A graphical implementation of the classic Tic-Tac-Toe game featuring custom GDI+ drawing and dynamic game state management.**

This project moves beyond standard controls to implement **Custom Painting**. When a player wins, the game physically draws a line across the winning row, column, or diagonal using the `System.Drawing` library.

## 📸 Project Demo

Here is the game in action:

### 1. Gameplay & Turn Management
The game tracks player turns (Player 1 vs Player 2). Clicking a button updates its icon to "X" or "O" and disables it to prevent overwriting.

![Gameplay](../../../../../Repo%20Images/TicTacToe1.png)

### 2. Win Detection & Drawing
When a win condition is met (3 in a row), the system:
1.  Detects the winning pattern (Horizontal, Vertical, or Diagonal).
2.  **Draws a line** directly on the form using `Pen` and `Graphics` objects.
3.  Displays a "Game Over" message.
4.  
![Game Over](../../../../../Repo%20Images/TicTacToe2.png)

## ✨ Features

* **Visual Win Indicator:** Unlike basic implementations that just show a message box, this app draws a graphical line connecting the winning cells.
* **Turn Logic:** Automatically switches between "Player 1" and "Player 2" after every valid move.
* **Game Status:** Updates a label in real-time to show whose turn it is or who won (e.g., "Winner: Player 1").
* **Restart Engine:** A "Restart Game" function resets the board, clears images, and repaints the background without restarting the application.

## 🛠️ Technical Highlights

* **GDI+ (`System.Drawing`):** Used the `Paint` event to draw lines dynamically.
    ```csharp
    e.Graphics.DrawLine(Pen, StartPoint, EndPoint);
    ```
* **Game Logic Engine:** A central `CheckWinner()` function evaluates all 8 possible win conditions (3 rows, 3 columns, 2 diagonals) after every click.
* **Resource Management:** Uses `Properties.Resources` to load graphical assets (X and O images) efficiently.

## 🚀 How to Run

1.  **Open in Visual Studio:** Load the `TicTacToeGame.sln` solution.
2.  **Compile & Run:** Press `F5`.
3.  **Play:** Click any cell to start the match!
