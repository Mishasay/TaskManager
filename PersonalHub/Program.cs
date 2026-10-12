using PersonalHub;
using System.Collections.Generic;

List<TaskItem> tasks = TaskStorage.Load();
bool running = true;

while (running)
{
    Console.WriteLine("\n1.Add a task");
    Console.WriteLine("\n2.Show all");
    Console.WriteLine("\n3.Mark as completed");
    Console.WriteLine("\n4.Delete");
    Console.WriteLine("\n5. Exit");
    Console.Write("Select an action: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Task: ");
            string task = Console.ReadLine();
            Console.Write("Priority: ");
            string priorityInput = Console.ReadLine();
            Priority priority;

            switch (priorityInput)
            {
                case "1":
                    priority = Priority.High;
                    break;
                case "2":
                    priority = Priority.Medium;
                    break;
                case "3":
                    priority = Priority.Low;
                    break;
                default:
                    priority = Priority.Medium;
                    break;
            }

            DateTime deadline;
            try
            {
                Console.Write("Day: ");
                int day = int.Parse(Console.ReadLine());
                Console.Write("Month: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("Year: ");
                int year = int.Parse(Console.ReadLine());
                deadline = new DateTime(year, month, day);
            }
            catch
            {
                Console.WriteLine("Invalid date format, default date set.");
                deadline = DateTime.Now;
            }

            TaskItem stask = new TaskItem(task, priority, deadline);
            tasks.Add(stask);
            TaskStorage.Save(tasks);
            break;

        case "2":
            foreach (var t in tasks)
            {
                Console.WriteLine(t);
            }
            break;

        case "3":
            Console.WriteLine ("What are we looking for: ") ;
            string searchTitle = Console.ReadLine();
            TaskItem searchToComplite = tasks.Find(t => t.Title == searchTitle);
            if (searchToComplite != null)
            {
                searchToComplite.MarkComplited();
                Console.WriteLine("Marked as completed!");
                TaskStorage.Save(tasks);
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
            TaskStorage.Save(tasks);
            break;

        case "4":
            Console.WriteLine("Task to delite: ");
            string TaskDelite = Console.ReadLine();
            TaskItem TaskToDelite = tasks.Find(t => t.Title == TaskDelite);
            if (TaskToDelite != null)
            {
                tasks.Remove(TaskToDelite);
                Console.WriteLine("Removed");
                TaskStorage.Save(tasks);
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
            break;

        case "5":
            running = false;
            break;
    }
}