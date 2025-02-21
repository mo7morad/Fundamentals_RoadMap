# 📌 Fundamentals Roadmap

![Progress](https://img.shields.io/badge/Completed_Courses-14%2F26-blue?style=for-the-badge) ![Status](https://img.shields.io/badge/Status-Work_In_Progress-orange?style=for-the-badge)

![Problem Solving](https://img.shields.io/badge/Problem%20Solving-185%2B%20Solved%20Problems-success?style=for-the-badge) ![Projects](https://img.shields.io/badge/Projects-17%20Completed-ff5733?style=for-the-badge&logo=visual-studio-code&logoColor=white)

---

## 📌 Featured Projects

Here’s a quick overview of 8 key projects included in this repository:

1. **MathQuiz**  
   🎯 *A simple, interactive math quiz game that sharpens arithmetic skills through engaging challenges.*

2. **ScissorsPaperRock**  
   ✂️ *A classic implementation of the "Scissors Paper Rock" game in C++, delivering nostalgic fun with a modern twist.*

3. **Banking System**  
   🏦 *A fully object-oriented banking system featuring comprehensive account management, seamless transactions, and robust data persistence.*

4. **ATM-System-Project**  
   💳 *A console-based ATM simulation that supports quick & normal withdrawals, deposits, balance inquiries, secure user authentication, and efficient transaction processing.*

5. **ContactsSystem**  
   📇 *A versatile contacts management application that allows users to add, remove, search, and display contacts, with all data persistently stored in a text file.*

6. **Driving-Simulation**  
   🚗 *A dynamic driving simulation that handles user inputs for movement, acceleration, braking, and collision detection, offering real-time feedback and control.*

7. **Undo/Redo System**  
   ↩️ *An innovative string management system implementing Undo/Redo functionality using stack data structures, perfect for enhancing text editing capabilities.*

8. **Queue Line Tickets**  
   ⏱️ *A dynamic solution for managing line ordering using a queue data structure, featuring advanced validation and real-time updates.*

---


## 📘 Introduction

Welcome to the **Fundamentals Roadmap** repository! This repository documents my learning journey 🔬 through **26 foundational programming courses** curated by **Eng. Mohamed Abo-Hadhoud**.

### 🔍 What You'll Find:

- 📂 **Structured Code Solutions**: Well-documented solutions for problem-solving tasks and projects.
- 📝 **Annotated Course Code**: Trainer-provided code with additional notes for reference.
- 🚀 **Progress Tracking**: Continuous updates as I complete more courses.

---

## 🚀 How to Use

1. **🔧 Explore Solutions**: Check the `Coding/` folder for problem-solving solutions and fully implemented projects with clear explanations and comments.
2. **📓 Review Course Content**: Dive into the `Courses/` folder for annotated trainer-provided material.
3. **🔢 Track Progress**: Stay updated on completed courses and upcoming solutions.

---

## 📂 Repository Structure

```yaml
Fundamentals_Roadmap/
├── 📁 Certificates/       # Certificates earned during the journey (updated regularly).
├── 📁 Coding/             # Problem-solving solutions and full projects.
│   ├── Problem-Solving-Level-01-in-C++/  # 20+ solved problems.
│   ├── Problem-Solving-Level-02-in-C++/  # 50+ solved problems + 2 projects.
│   ├── Problem-Solving-Level-03-in-C++/  # 50+ solved problems + 2 projects.
│   ├── Problem-Solving-Level-04-in-C++/  # 65+ solved problems + 2 projects.
│   ├── Problem-Solving-Level-05-in-C++/  # 8 projects.
│   ├── OOP-C++/                          # 3   OOP console projects.
│   ├── 14 - C#/                          #
├── 📁 Courses/            # Trainer-provided material and slides.
```

---

## 🏗️ Projects Breakdown

### 🔢 **Problem-Solving Level 02 (C++)**
- **🎯 MathQuiz.cpp** – A simple math quiz game designed to improve arithmetic skills interactively.
- **🔷 ScissorsPaperRock.cpp** – An implementation of the classic "Scissors Paper Rock" game in C++.

### 🔢 **Problem-Solving Level 03 (C++)**
- **🏛️ Banking System** – A fully object-oriented implementation with advanced features.
  - **#52_Project1_Bank-1.cpp** – A basic banking system.
  - **#53_Project2_Bank-2.cpp** – An extended version with additional functionalities.

### 🔢 **Problem-Solving Level 04 (C++)** 
- **🏛️ Bank Extension** – Enhancements including user login and a management system.
- **💳 ATM-System-Project.cpp** – A console-based ATM simulation featuring:
  - 🔹 **Quick Withdraw**
  - 🔹 **Normal Withdraw**
  - 🔹 **Deposit**
  - 🔹 **Balance Inquiry**
  - 🔹 **User Authentication**
  - 🔹 **Transaction Processing & File Handling**

### 🧩 **OOP-C++ (Object-Oriented Programming)**

  - 🏦 **Banking System Features**

  - 🏦 **Client Management**
    - 🔍 **Find Client** – Search by account number.
    - ✏️ **Update Client** – Modify details.
    - ➕ **Add New Client** – Register new users.
    - ❌ **Delete Client** – Remove accounts.
    - 📋 **List Clients** – Display all clients.
    - 💰 **View Total Balances** – Check combined balances.

 - 💳 **Banking Transactions**
    - 💸 **Quick Withdraw**
    - 💵 **Normal Withdraw**
    - 🏦 **Deposit**
    - 🔄 **Balance Inquiry**
    - 🔁 **Money Transfer**
    - 📜 **Transaction Logs**

- 🔐 **User Authentication**
  - 🛂 **Login System with encrypted password storage 🔐**
  - 📝 **Login Logs**

- 💵 **Worldwide Currency Management**
  - 💱 **Currency Exchange**
  - 🔍 **Find Currency Rate**
  - 📊 **Update Exchange Rates**
  - 🌎 **Currency List**

- 🛠️ Project Structure

```yaml
BankingSystem/
├── headers/                         # Header files
│   ├── core/                         # Core class definitions
│   │   ├── clsPerson.h
│   │   ├── clsBankClient.h
│   │   ├── clsUser.h
│   │   ├── clsCurrency.h
│   ├── screens/                      # UI interaction screens
│   │   ├── client/                     # Client management screens
│   │   ├── currencies/                 # Currency-related screens
│   │   ├── user/                       # User management screens
│   │   ├── clsMainScreen.h             # Main screen handling file
│   │   ├── clsScreen.h                 # Base class for all screens
│   ├── lib/                          # Utility library
│   │   ├── clsPeriod.h
│   │   ├── clsDate.h
│   │   ├── clsUtil.h
│   │   ├── clsInputValidation.h
│   │   ├── clsString.h
│   │   ├── clsInputValidate.h
│   ├── Global.h                      # Fetching the current user
├── LoginLogs.txt                     # Logs for successful logins
├── TransferLogs.txt                  # Records of performed transfers
├── Clients.txt                       # Client database
├── Users.txt                         # User database
├── Currencies.txt                    # Currency database
```
- **ContactsSystem 📇📞**
  - 🔹 Add new contacts with name and phone number.
  - 🔹 Remove existing contacts by name.
  - 🔹 Search for contacts by name.
  - 🔹 Display all saved contacts.
  - 🔹 Stores contact data in a text file (`contacts.txt`) for persistence.

- **Driving-Simulation 🚗💨**
  - 🔹 Simulates a basic driving experience.
  - 🔹 Handles user input for controlling movement.
  - 🔹 Implements basic physics such as acceleration and braking.
  - 🔹 Includes obstacles and collision detection.
  - 🔹 Provides real-time feedback on driving status.
---

### 🔢 **Problem-Solving Level 05 (C++)**
This level focuses on advanced **data structures and algorithms**, leveraging key **OOP principles such as composition and inheritance** to build modular and reusable solutions.

| Project | Description |
|---------|------------|
| **Project1 - Doubly Linked List** | Implementation of a **Doubly Linked List** with insert, delete, and traversal functions. 
| **Project2 - Queue** | Queue data structure implementation using linked lists. 
| **Project3 - Stack** | Stack implementation using linked lists.
| **Project4 - Dynamic Array** | A dynamic array class with resizing capabilities. 
| **Project5 - Queue Using Array** | Implementation of a queue using arrays.
| **Project6 - Stack Using Array** | Implementation of a stack using arrays.
| **Project7 - Undo/Redo System** | A string management system with **Undo-Redo** functionality using a stack.
| **Project8 - Queue Line Tickets Project** | A queue-based project for managing line ordering with advanced validation. 

---

## 🌟 Key Highlights

- 🗺 **Problem-Solving Focus** – Master core fundamentals through practical challenges.
- 🔍 **Readable Code** – Well-documented, structured, and clean code.
- 💡 **Continuous Learning** – Regular updates with new solutions and projects.

---

## 🔧 Tools & Technologies

- **Languages:**
  - ![C++](https://img.icons8.com/color/48/000000/c-plus-plus-logo.png) **C++ 17**
  - ![C#](https://img.icons8.com/color/48/000000/c-sharp-logo.png) **C#**
- **Version Control:**
  - ![Git](https://img.icons8.com/color/48/000000/git.png) **Git**
  - ![GitHub](https://img.icons8.com/material-outlined/48/000000/github.png) **GitHub**
- **Code Quality:**
  - 🦼 **Clean & Readable**
  - 📖 **Well-Structured & Documented**
  - 🔄 **Reusable & Scalable**

---

🔗 **Let’s Connect!**

Feel free to explore, suggest improvements, or collaborate on this learning journey! 🚀

