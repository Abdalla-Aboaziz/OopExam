#  OOP Exam System (C# Console Application)

##  Overview
The **OOP Exam System** is a console-based application developed in **C#** that demonstrates solid understanding and practical application of **Object-Oriented Programming (OOP)** principles.

The system simulates a real-world examination environment where subjects, exams, and questions are dynamically created and evaluated.

This project was built as part of an OOP assessment and designed with **clean architecture, extensibility, and clarity** in mind.

---

##  Project Goals
- Apply Object-Oriented Programming concepts in a real scenario
- Design a flexible and extensible exam system
- Separate responsibilities across well-defined classes
- Practice abstraction, inheritance, and polymorphism
- Build a maintainable and readable codebase

---

##  System Architecture

Subject
- Exam (Abstract)
  - PracticalExam
  - FinalExam
    - McqQuestion
    - TrueOrFalseQuestion

Question (Abstract)
- McqQuestion
- TrueOrFalseQuestion

---

##  Core Components

###  Subject
- Represents a course or subject
- Responsible for:
  - Creating an exam
  - Displaying the exam to the user

---

###  Exam (Abstract Class)
- Base class for all exams
- Properties:
  - Time
  - NumberOfQuestions
  - List of Questions
- Enforces implementation of `ShowExam()`

#### ✔ PracticalExam
- Displays all questions
- Shows correct answers immediately (Practice Mode)

#### ✔ FinalExam
- Accepts user answers
- Automatically evaluates and calculates the final grade

---

###  Question (Abstract Class)
- Base class for all question types
- Properties:
  - Header
  - Body
  - Mark
  - Answers
  - RightAnswer

#### ✔ McqQuestion
- Multiple Choice Question
- Supports multiple answers with one correct option

#### ✔ TrueOrFalseQuestion
- Binary choice question (True / False)

---

###  Answer
- Represents a single answer option
- Implements:
  - `ToString()` for formatted output
  - `ICloneable` for safe object copying

---

###  ExamBuilder
- Responsible for building the exam dynamically from user input
- Keeps the `Main` method clean and readable
- Demonstrates separation of concerns

---

##  Features
✔ Dynamic subject creation  
✔ Practical and Final exam modes  
✔ Multiple question types (MCQ / True-False)  
✔ Automatic grading system  
✔ Console-based user interaction  
✔ Clean and structured OOP design  

---

##  Application Flow
1. Enter subject information
2. Choose exam type (Practical / Final)
3. Define exam duration and number of questions
4. Create questions and set correct answers
5. Start the exam
6. Display results or correct answers based on exam type

---

##  Technologies Used
- **Language:** C#
- **Framework:** .NET
- **Application Type:** Console Application
- **Programming Paradigm:** Object-Oriented Programming (OOP)

---

##  OOP Concepts Demonstrated
- Abstraction
- Inheritance
- Polymorphism
- Encapsulation
- Interfaces (`ICloneable`)
- Method Overriding
- Clean Class Design

---

##  Possible Enhancements
- Input validation improvements
- Persist exams to files or databases
- Add real-time exam timer
- Convert the system to Web API or MVC application
- Add unit testing

---

## 👨‍💻 Author
**Abdalla Adel Aboaziz**  
Backend Developer (.NET)

---

## ⭐ Final Notes
This project is more than a simple console application.  
It represents a **mini examination system** that showcases strong OOP fundamentals and clean design practices, making it suitable as a **portfolio project** for junior backend developers.


