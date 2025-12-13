# Course 13: Applying on Data Structures (13 - Algorithms & Problem Solving Level 5)

This directory contains my solutions and custom implementations for **Course 13** of the Backend Engineering Roadmap.

In this phase, I moved beyond Linked Lists to build more complex linear data structures. I implemented **Queues** and **Stacks** in two different ways (Linked-List-based vs. Array-based) to understand the trade-offs. I also built a robust **Dynamic Array** class and applied these concepts in a **Ticket Management System**.

## 📂 Directory Structure & Projects

The course is organized into specific projects, each mastering a different structure:

### 1. 🏗️ Core Data Structures
* **[Project 1: Doubly Linked List](./Project1-DoublyLinkedList)** - The foundation for many other structures.
* **[Project 4: Dynamic Array](./Project4-DynamicArray)** - A resizeable array class (`vector` equivalent) with manual memory management.

### 2. 📚 Stack & Queue Implementations
I implemented these structures twice to compare performance and logic:

| Structure | Linked-List Based | Dynamic-Array Based |
| :--- | :--- | :--- |
| **Queue** | **[Project 2](./Project2-Queue)** <br> Uses `DoublyLinkedList` for $O(1)$ Enqueue/Dequeue. | **[Project 5](./Project5-QueueArray)** <br> Uses `DynamicArray` composition. |
| **Stack** | **[Project 3](./Project3-Stack)** <br> Inherits from `Queue` but restricts to LIFO operations. | **[Project 6](./Project6-StackArray)** <br> Inherits from `QueueArray`. |

### 3. 🛠️ Applied Systems
* **[Project 7: Undo/Redo System](./Project7-Undo_Redo)**
    * **Logic:** Uses two stacks (`_UndoStack` and `_RedoStack`) to track state changes.
    * **Feature:** Allows infinite navigation backward and forward through string history.

* **[Project 8: Queue Line Capstone](./Project8-QueueLineProject)**
    * **Description:** A bank ticket management system.
    * **Logic:** Calculates "Estimated Serve Time" based on the number of waiting clients and average serving time.
    * **Visualization:** Prints the queue flow visually (RTL and LTR).

---

## 💻 Technical Implementation Details

### 1. Dynamic Array (Vector Clone)
A template-based array that resizes itself automatically.
* **Memory Management:**
    * `_Enlarge()`: Allocates a larger block and copies data when the array is full.
    * `_Shrink()`: Reduces memory usage when the array is mostly empty.
* **Access:** Provides safe access via `GetItem(index)` with bounds checking.

### 2. Stack & Queue Architecture
* **Composition Pattern:** The `Queue` class contains a `DoublyLinkedList` object (`list`) to handle the actual storage. This adheres to the "Don't Repeat Yourself" (DRY) principle.
* **Inheritance Pattern:** The `Stack` class inherits from `Queue` but effectively "hides" the FIFO methods, exposing only LIFO methods like `push()` (InsertFirst) and `Top()`.

### 3. Queue Line System
A simulation of a real-world waiting line.
* **Ticket Struct:** Stores `IssuingTime`, `WaitingList` count, and `TicketNumber`.
* **Service Logic:**
    ```cpp
    TimeToServe = (TicketNumber - 1) * ServingTime;
    ```
    This formula dynamically calculates how long a new client must wait.

## 🛠️ Tech Stack
* **Language:** C++
* **Concepts:**
    * **Templates:** Used for all data structures to ensure they can hold any data type (`<int>`, `<string>`, `<clsClient>`).
    * **Big O Analysis:** Understanding why Linked-List Queues are $O(1)$ for insertion while Array Queues might trigger an $O(N)$ resize.
    * **Inheritance vs. Composition:** deciding when to *use* a class (Queue uses List) vs *be* a class (Stack is a Queue).

## 🚀 How to Run
To run the **Queue Line** simulation:

1.  Navigate to the project folder:
    ```bash
    cd Project8-QueueLineProject
    ```
2.  Compile the project:
    ```bash
    g++ main.cpp -o QueueApp
    ```
3.  Run the executable:
    ```bash
    ./QueueApp
    ```

---
*This repository documents my journey in mastering Backend Engineering.*
