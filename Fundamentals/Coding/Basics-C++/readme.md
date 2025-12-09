# Course 03: C++ Basics Structured Programming & Data Organization


While the 2nd course focused on syntax and basic logic, this course shifted focus to **organizing code and data**. I learned how to build custom data types using **Structures** and **Enums**, how to break large programs into reusable **Functions**, and how to handle complex logic with **Nested Loops**.

## 📂 Project Structure & Topics Covered

The code files in this directory are categorized by the concepts they demonstrate:

### 1. 🏗️ Data Structures (Structs & Enums)
Moving beyond basic types (`int`, `string`) to model real-world entities.
* **`structures&Enums.cpp`:**
    * Created complex custom types (e.g., `stPerson`, `stContactInfo`).
    * Implemented **Nested Structures** (e.g., an Address struct inside a ContactInfo struct).
    * Used **Enums** to define specific states (Gender, Marital Status, Colors) for code readability.
* **`Arrays_of_structures.cpp`:**
    * Combined Arrays with Structures to create a simple "Database" system.
    * Managed a list of users (e.g., reading and printing data for up to 100 persons).

### 2. 🧩 Functions & Modularity
Learning to write clean, reusable code.
* **`functions.cpp`:**
    * Difference between `void` procedures and functions with `return` values.
    * Designing reusable logic blocks (e.g., a function to calculate sums or print banners).
* **`Enums_Functions.cpp`:**
    * Combining Enums with Switch-Case statements to create interactive menus (e.g., Weekday selector, Color picker).

### 3. 🔄 Advanced Control Flow
* **`Nested_Loops.cpp`:**
    * Mastered the logic of loops inside loops.
    * Solved pattern printing problems (Star triangles, Number pyramids, Letter combinations `AA` to `ZZ`).
* **`relational_oprators.cpp`:** Deep dive into comparison logic (`==`, `!=`, `>=`, etc.).

### 4. 🧠 Problem Solving Collection
* **`problem_solving.cpp`:** A compilation of various algorithms solved using the new concepts:
    * **Validation:** Ensuring user input (like Age) falls within a valid range.
    * **Geometry:** Calculating Rectangle areas using advanced math (`sqrt`).
    * **Logic:** Checking for Odd/Even numbers, Pass/Fail status.
    * **Time Calculation:** Converting total seconds into Days:Hours:Minutes format.

## 🛠️ Tech Stack
* **Language:** C++
* **Key Concepts:**
    * `struct` (Data Grouping)
    * `enum` (State Management)
    * Functions & Procedures
    * Nested `for` Loops
    * Arrays of Structures

## 🚀 How to Run
To run any of these files, use a standard C++ compiler:

1.  **Compile:**
    ```bash
    g++ structures&Enums.cpp -o myProgram
    ```
2.  **Run:**
    ```bash
    ./myProgram
    ```

## 📝 Key Takeaways
* **Data Modeling:** I can now represent complex real-world data (like a User Profile) using `structs` instead of loose variables.
* **Code Reusability:** I learned to never repeat code. If logic is used twice, it belongs in a function.
* **Readability:** Using `Enums` (e.g., `Color::Red` instead of `1`) makes the code self-documenting.
* **Complex Logic:** Nested loops gave me a deeper understanding of iteration and algorithm complexity.

---
*This repository documents my journey in mastering Backend Engineering.*
