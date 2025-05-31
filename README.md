
# 🎓 University System

A simple university management system built using **.NET Core** and **Entity Framework Core** with a **Code First** approach. This project models the full academic structure of a university, including students, instructors, courses, attendance, evaluations, and more.

> **This is an open-source project initiated by the **AOLabs** community of Arab software engineers.**

---

## ⚠️ Project Scope

> ✅ **This project currently implements the database design only** (Data Layer).  
> ✅ **Entity Framework Core (EF Core)** is used exclusively with the **Code First** approach.  
> ✅ **Test cases** are included to validate the integrity and relationships of the database structure.  
> 🚫 No API endpoints or user interface have been implemented yet.

---

## 📁 Project Structure

```plaintext

UniversitySystem/
│
├── Common/             ← Shared or helper utilities
├── Configurations/     ← Fluent API configurations for EF Core entities
├── Connections/        ← Database connection configurations
├── Context/            ← The main DbContext class
├── DatabaseDesign/     ← Documentation and database design resources
├── Enums/              ← Enumerations (e.g., GPA type, Gender, Days of week)
├── Migrations/         ← EF Core migrations
├── Models/             ← Entity models representing the database tables
├── Program.cs          ← Application entry point
└── SQLQuery2.sql       ← Optional SQL file for raw queries or backups

```

---

## 🧠 Database Overview

The system is designed to represent core academic entities:

- **University**, **Faculty**, **Department**, **Specialization**
- **Student**, **Instructor**
- **Course**, **CourseInstructor**, **Enrollment**
- **Schedule**, **Lecture**, **Attendance**
- **Evaluation**, **Grade**

### Key Relationships:

- A student belongs to a specialization.
- An instructor is assigned to a department and teaches lectures.
- A course can be taught by multiple instructors.
- Student attendance is tracked per lecture.
- Students receive grades and evaluations per course enrollment.

---

## 🧰 Technologies Used

- ✅ ASP.NET Core
- ✅ Entity Framework Core (Code First only)
- ✅ SQL Server
- ✅ LINQ

---

## 🚀 Getting Started

1. **Clone the repository:**

   ```bash
   git clone https://github.com/morsy777/UniversitySystem.git
   cd UniversitySystem
   ```

2. **Update your database connection string:**

   Modify the connection string in `Connections/DatabaseConnection.cs` or in your `appsettings.json`, depending on your setup.

3. **Apply migrations to create the database:**

   ```bash
   dotnet ef database update
   ```

4. **Run the application:**

   ```bash
   dotnet run
   ```

---

## ✅ Test Cases

Unit tests have been added to verify:

- Entity relationships
- Database constraints
- Sample CRUD logic on selected entities

The test cases are written directly inside `Program.cs`, organized using `#region` blocks for clarity.

---

## ✍️ Contributing

This project was originally developed and contributed by [Mohamed Morsi](https://github.com/morsy777) as part of the AOLabs open-source initiative.

Feel free to fork the repository, explore the structure, and contribute enhancements or extensions!

---

## 🙌 Acknowledgements

Special thanks to the **AOLabs** community and to all current and future contributors. 🙏
