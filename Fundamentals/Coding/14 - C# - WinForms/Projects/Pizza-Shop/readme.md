# 🍕 Pizza Order System (Windows Forms)

**A desktop Point-of-Sale (POS) application built with C# and Windows Forms to simulate a real-time pizza ordering process.**

This project demonstrates the power of **Event-Driven Programming**. Unlike console apps where the program flows linearly, this app reacts instantly to user clicks, updating the "Total Price" in real-time as toppings and sizes are selected.

## 📸 Project Demo

Here is a walkthrough of the ordering process:

### 1. Default State
When the application starts, it initializes with a default "Medium" size and "Thin" crust. The base price is automatically calculated.
![Main Interface](../../../../../../Repo%20Images/PizzaOrder1.png)

### 2. Live Price Calculation
As the user selects different sizes (Small/Large) or adds toppings (Cheese, Mushrooms, etc.), the **Total Price** updates instantly without needing a "Calculate" button.
* *Example:* Changing from Medium ($10) to Large ($15) adds $5 immediately.
![Price Update](../../../../../../Repo%20Images/PizzaOrder2.png)

### 3. Order Confirmation
Clicking "Order Pizza" locks the form to prevent changes and displays a confirmation summary. The "Reset" button clears all fields to start a new order.
![Order Confirmation](../../../../../../Repo%20Images/PizzaOrder3.png)

## ✨ Features

* **Real-Time Cost Engine:**
    * **Size Logic:** Small ($20), Medium ($30), Large ($40).
    * **Toppings Logic:** Each topping adds a fixed cost (e.g., +$5 for Green Peppers).
    * **Crust Logic:** Thin crust is free, but Thick crust adds a premium.
* **Control Groups:** Uses `GroupBox` containers to isolate Radio Button logic (ensuring selecting a Crust doesn't unselect a Size).
* **Reset Functionality:** A single click restores the form to its initial state, clearing checkboxes and resetting prices.

## 🛠️ Technical Highlights

* **Event Handling (`CheckedChanged`):** Every control is wired to a central `UpdateTotalPrice()` function. This ensures the price is always accurate, no matter the combination of inputs.
* **Tag Property Usage:** I utilized the `Tag` property of Windows Forms controls to store pricing data (e.g., `rbSmall.Tag = "20"`), reducing the need for hardcoded `if-else` chains.
* **Input Locking:** Disables controls (`Enabled = false`) upon order confirmation to simulate a finalized transaction.

## 🚀 How to Run

1.  **Open the Project:** Double-click the `.sln` file in Visual Studio.
2.  **Build:** Press `Ctrl + Shift + B` to compile.
3.  **Run:** Press `F5` to launch the application.
