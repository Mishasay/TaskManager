# Task Manager (v1)

A console task manager written in C# (.NET). Tasks are saved to a JSON file,
so they are still there after you close the program.

> **Status:** this is version 1, my first C# project. I am actively improving it
> and plan to turn it into a full-featured application.

## Features
- Add tasks with a title, priority (High / Medium / Low) and deadline
- View all tasks
- Mark tasks as completed
- Delete tasks
- Automatic saving and loading (JSON)
- Input validation for dates

## Tech
- C#, .NET
- System.Text.Json

## How to run
1. Install the [.NET SDK](https://dotnet.microsoft.com/download)
2. Clone the repository
3. In the project folder, run: `dotnet run`

## Project structure
- `Program.cs` – menu and user interaction
- `TaskItem.cs` – task model
- `Priority.cs` – priority enum
- `TaskStorage.cs` – saving and loading tasks

## Roadmap
- [ ] Edit existing tasks (title, priority, deadline)
- [ ] Sort tasks by deadline and priority
- [ ] Case-insensitive task search
- [ ] Graphical interface (WPF) with a dark blue glass-style theme
- [ ] Unit tests

## What I learned
I learned how to design classes and enums in C#, work with collections and lambda expressions, and save data in JSON format. The trickiest part was grasping variable scope—for instance, understanding why a variable declared inside a `try` block isn't accessible outside of it. Moving forward, I plan to add task editing capabilities and a graphical user interface.
I’ve mastered the fundamentals of C# and plan to continue working with and learning the language. One of the biggest challenges was shifting my mindset away from Python and getting used to a new development environment.
