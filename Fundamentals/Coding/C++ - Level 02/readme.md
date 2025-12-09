# Course 06: Introduction to Programming Level 2 (C++ Topics)

This directory contains my solutions and practice code for **Course 06** of the Backend Engineering Roadmap.

This course marked a shift from writing simple algorithms to understanding **how the machine actually works**. The focus was on "Under the Hood" concepts: Memory Management (Pointers & References), Data Persistence (Files), and advanced C++ features like Vectors and Dynamic Allocation.

## 📂 Topics Covered

The code files in this directory are categorized by the technical concepts they demonstrate:

### 1. 🧠 Memory Management & Pointers
Moving beyond variables to direct memory manipulation.
* **Pointers vs. References:** Understanding memory addresses (`&`) and dereferencing (`*`).
* **Dynamic Memory:** Using `new` and `delete` to allocate memory on the Heap manually.
* **Pointer Arithmetic:** Iterating through arrays using pointer incrementation logic.
* **Void Pointers:** Working with generic pointers and static casting.
* **Call Stack:** Visualizing how functions define the stack memory (Func1 calls Func2 calls Func3...).

### 2. 💾 Data Persistence (File I/O)
Built a complete **CRUD (Create, Read, Update, Delete)** system using text files.
* **Write & Append:** Creating logs or data files without overwriting existing data.
* **Read & Load:** parsing file content line-by-line into Vectors.
* **Update Record:** Logic to find a specific record, modify it in memory, and rewrite the file.
* **Delete Record:** Logic to filter out specific lines and save the clean state back to disk.

### 3. 📦 Advanced Data Structures
* **Vectors (`std::vector`):**
    * Dynamic arrays that resize automatically.
    * Vector Iterators (`num.begin()`, `num.end()`).
    * **Vector of Structs:** Creating complex lists (e.g., a list of `Employees` with Name/Salary) and managing them dynamically.
* **2D Arrays:** handling multi-dimensional data (Matrices) with nested loops.

### 4. 🛠️ Utilities & Libraries
* **Date & Time:** Using `ctime` to manage Local vs. UTC time and formatting date strings.
* **String Manipulation:** Mastering the `std::string` class (`append`, `substr`, `find`, `insert`).
* **Input Validation:** robust error handling for `cin` (ignoring bad input streams).
* **Bitwise Operations:** Understanding binary logic (`AND &`, `OR |`) at the bit level.

### 5. 🧱 Modularity & Code Organization
* **Headers & Namespaces:** Created `MyLibrary.h` to organize reusable functions and avoid naming conflicts using custom `namespace`.
* **Recursion:** Solving problems by having functions call themselves (e.g., Power calculation).
* **Static Variables:** Using `static` to preserve variable state between function calls.

## 🛠️ Tech Stack
* **Language:** C++
* **Libraries:** `fstream` (Files), `vector` (Dynamic Arrays), `ctime` (Time), `iomanip` (Formatting).
* **Key Concepts:** Stack vs. Heap, Pointers, References, File Streams, CRUD Logic.

## 🚀 How to Run
To run the File Handling demo (ensure you have write permissions in the folder):

1.  **Compile:**
    ```bash
    g++ FilesHandling.cpp -o FileApp
    ```
2.  **Run:**
    ```bash
    ./FileApp
    ```

## 📝 Key Takeaways
* **Memory Control:** I now understand *where* my variables live (Stack or Heap) and how to access them efficiently using Pointers.
* **Persistence:** I can build applications that save user progress or data, rather than resetting every time the program closes.
* **Safety:** Learned to manage resources (closing files, deleting pointers) to prevent memory leaks and data corruption.

---
*This repository documents my journey in mastering Backend Engineering.*
