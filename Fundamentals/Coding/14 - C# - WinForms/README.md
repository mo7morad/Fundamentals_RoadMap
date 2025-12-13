# Course 14: Introduction to C# & .NET Framework

This directory contains my notes, exercises, and capstone projects for **Course 14** of the Backend Engineering Roadmap.

This course marked my official transition from C++ to **C# and the .NET Ecosystem**. I learned the architecture of the **CLR (Common Language Runtime)**, mastered C# syntax (LINQ, Delegates, Properties), and built my first GUI-based desktop applications using **Windows Forms**.

## 📂 Topics Covered

The course moved from console-based logic to visual event-driven programming:

### 1. 🏗️ The .NET Architecture
* **CLR Internals:** Understanding how the Common Language Runtime manages memory (Garbage Collection) and executes code (JIT Compilation).
* **Managed vs. Unmanaged Code:** The difference between code running under the CLR and raw machine code (like C++).
* **CTS & CLS:** How .NET ensures interoperability between languages (C#, F#, VB).

### 2. 💻 C# Fundamentals
* **Syntax & Types:** `var` (implicit typing), Nullable types (`int?`), and Dynamic types.
* **Collections & LINQ:** Using System.Linq for powerful array operations (`Sum`, `Count`, `Average`) instead of manual loops.
* **String Manipulation:** String Interpolation (`$"{Name}"`) and standard library methods.

### 3. 🖥️ Windows Forms (GUI)
* **Controls:** Mastered the standard toolbox: `TextBox`, `ComboBox`, `CheckBox`, `RadioButton`, `DateTimePicker`, `TreeView`, and `ListView`.
* **Events:** Handling user interactions like `Click`, `TextChanged`, and `MouseHover`.
* **Containers:** Using `GroupBox`, `Panel`, and `TabControl` to organize complex layouts.
* **Dialogs:** Implementing file handling with `OpenFileDialog` and `SaveFileDialog`.

---

## 🏆 Capstone Projects

To apply these concepts, I built two interactive Desktop Applications.

### 1. 🍕 [Pizza Order System](./Projects/PizzaProject)
A complete Point-of-Sale (POS) dashboard for a pizza shop.
* **Dynamic Pricing:** Real-time price updates as the user selects sizes, crust types, and toppings.
* **Event Handling:** Heavy use of `CheckedChanged` events to toggle options logic.
* **UI Design:** Organized using GroupBoxes to separate "Size", "Toppings", and "Order Summary".

### 2. ❌⭕ [Tic-Tac-Toe Game](./Projects/TicTacToeGame)
A graphical implementation of the classic game.
* **Game Logic:** Checks for win conditions (Rows, Columns, Diagonals) after every move.
* **Visual Feedback:** Paints the winning line and freezes the board upon victory.
* **Turn Management:** Switches between Player X and Player O automatically.

---

## 🛠️ Tech Stack
* **Language:** C#
* **Framework:** .NET Framework (Windows Forms)
* **IDE:** Visual Studio
* **Key Concepts:** Event-Driven Programming, Object-Oriented UI Design.

---
*This repository documents my journey in mastering Backend Engineering.*
