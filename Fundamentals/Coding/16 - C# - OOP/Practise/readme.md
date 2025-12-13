# Course 16: OOP As It Should Be In C#

This directory contains my notes, code snippets, and small projects for **Course 16** of the Backend Engineering Roadmap.

While I mastered Object-Oriented Programming in C++ in previous courses, C# introduces unique syntactic sugars and architectural patterns. This course focused on translating those core OOP principles (Encapsulation, Inheritance, Polymorphism, Abstraction) into professional C# code, leveraging features like **Properties**, **Interfaces**, and the **.NET Class Library**.

## 📂 Topics Covered

### 1. 🏗️ Core OOP Implementation
* **Class & Object:** Revisiting memory allocation for Reference Types (Classes) vs Value Types (Structs).
* **Constructors:**
    * **Static Constructors:** Run once per application lifetime (great for singletons).
    * **Private Constructors:** Used to prevent instantiation (e.g., in Utility classes).
    * **Destructors:** How the Garbage Collector (GC) interacts with object cleanup.
* **Composition:** Building complex objects by combining smaller ones (Has-a relationship) rather than just Inheritance (Is-a relationship).

### 2. 🛡️ Encapsulation & Properties
* **Properties:** Moving away from Java/C++ style `GetX()`/`SetX()` methods to C# **Properties**.
    * **Auto-Implemented Properties:** `public int Id { get; set; }`
    * **Read-Only Properties:** Properties that can only be set in the constructor.
* **Access Modifiers:**
    * `public`, `private`, `protected`.
    * **`internal`:** Accessible only within the same assembly (.dll/.exe).

### 3. 🧬 Inheritance & Polymorphism
* **Base Keyword:** Accessing members of the parent class.
* **Method Overriding:** Using `virtual` and `override`.
* **Method Hiding:** Using the `new` keyword to shadow base members.
* **Sealed Classes:** Preventing inheritance (optimization and security).
* **Upcasting & Downcasting:** Safe type conversion between Base and Derived classes.

### 4. 🧩 Abstraction & Interfaces
* **Abstract Classes:** Blueprints that cannot be instantiated.
* **Interfaces:** Defining contracts.
    * **Multiple Implementation:** How C# allows implementing multiple interfaces despite not supporting multiple class inheritance.
    * **Interface vs. Abstract Class:** Understanding when to use which.

### 5. 🛠️ Advanced C# Features
* **Partial Classes:** Splitting a single class across multiple files (common in WinForms/WPF auto-generated code).
* **Static Classes:** Containers for utility methods (like `Math` or `Console`).
* **Class Libraries (.DLL):** Packaging code into reusable libraries.

## 🏆 Mini-Project: OOP Calculator
A practical implementation of a Calculator using OOP principles.
* **Design:** Separated the "UI" (Console/Form) from the "Logic" (Calculator Class).
* **Abstraction:** Hidden the calculation logic behind clean public methods.

## 📝 Key Takeaways vs. C++
* **Structs are different:** In C#, `struct` is a Value Type (stack-allocated), whereas `class` is a Reference Type (heap-allocated). In C++, they are almost identical.
* **Properties:** C# Properties provide a much cleaner syntax for Encapsulation than manual getter/setter methods.
* **Interfaces:** C# relies heavily on Interfaces for polymorphism, unlike C++ which uses pure virtual classes (Abstract classes) for everything.

## 🛠️ Tech Stack
* **Language:** C#
* **Framework:** .NET Framework / .NET Core
* **Concepts:** OOP, Memory Management (Stack vs Heap), Assemblies.

---
*This repository documents my journey in mastering Backend Engineering.*
