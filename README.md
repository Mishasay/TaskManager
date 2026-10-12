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
(write 3–4 sentences here in your own words)
