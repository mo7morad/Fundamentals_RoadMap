# Course 13: Data Structures Level 2 (Queue, Stack, Dynamic Array)

This directory contains my implementations of advanced **Data Structures** in C++, created for **Course 13** of the Backend Engineering Roadmap.

In this phase, I expanded my data structure toolkit beyond Linked Lists. I built custom implementations for **Queues**, **Stacks**, and **Dynamic Arrays** using Templates for generic type support. I also applied these concepts to a real-world **Queue Management System**.

## 📂 Topics & Implementations

The code files demonstrate the manual construction of the following structures:

### 1. 📦 [Queue (`Queue.h`)](./MySolution/Queue.h)
A First-In-First-Out (FIFO) structure.
* **Implementation:** Built on top of my `DoublyLinkedList` for $O(1)$ operations at both ends.
* **Core Operations:** `push` (enqueue), `pop` (dequeue), `front`, and `back` access.
* **Extensions:** Added helper methods like `UpdateItem`, `InsertAfter`, and `Reverse` to extend functionality beyond a standard queue.

### 2. 📚 [Stack (`Stack.h`)](./MySolution/Stack.h)
A Last-In-First-Out (LIFO) structure.
* **Inheritance:** Implemented by inheriting from `Queue` but restricting access to LIFO behavior.
* **Core Operations:** `push` (insert at top), `Top` (peek top), and `Bottom` (peek bottom).
* **Efficiency:** Leverages the existing Doubly Linked List logic for memory management.

### 3. 🎢 [Dynamic Array (`DynamicArray.h`)](./MySolution/DynamicArray.h)
A resizeable array implementation similar to `std::vector`.
* **Memory Management:** Implemented `_Enlarge` and `_Shrink` to automatically manage heap memory as elements are added or removed.
* **CRUD:** Full support for `InsertAt`, `DeleteAt`, `Update`, and `Search`.
* **Merging:** Logic to merge two dynamic arrays into a new one.

### 4. 🔄 [MyString (Undo/Redo) (`MyString.h`)](./MySolution/MyString.h)
A practical application of Stacks.
* **Functionality:** A string class that remembers its history.
* **Undo/Redo:** Uses two internal stacks (`_UndoStack`, `_RedoStack`) to track state changes, allowing infinite undo/redo steps.

### 5. 🎫 [Queue Line Project (`QueueLine.h`)](./MySolution/QueueLine.h)
A simulation of a ticket waiting system (like in a bank or customer service center).
* **Ticket Structure:** Tracks `IssuingTime`, `WaitingList` count, and `EstimatedServeTime`.
* **Visualization:** Renders the queue visually (e.g., `A01 <-- A02 <-- A03`) to show flow direction (RTL or LTR).
* **Logic:** Calculates wait times dynamically based on a fixed `_ServingTime` per client.

## 🛠️ Tech Stack
* **Language:** C++
* **Concepts:**
    * **Templates (`template <class T>`):** Used extensively to make all structures generic.
    * **Inheritance:** Reusing code by deriving `Stack` from `Queue`.
    * **Composition:** Using `DoublyLinkedList` inside `Queue` to handle storage.

## 🚀 How to Run

To test the Dynamic Array implementation:

1.  **Compile:**
    ```bash
    g++ main.cpp -o App
    ```
2.  **Run:**
    ```bash
    ./App
    ```

## 📝 Key Takeaways
* **Code Reuse:** I learned that a **Stack** is just a restricted **Queue**, and a **Queue** can be built easily on a **Linked List**. I didn't write new storage logic for every class.
* **Memory Management:** Building `DynamicArray` taught me the cost of resizing (copying old data to new memory) and why reserving space is important.
* **Generic Programming:** Using templates allows these structures to store `int`, `string`, or even custom `clsClient` objects without changing a single line of code.

---
*This repository documents my journey in mastering Backend Engineering.*
