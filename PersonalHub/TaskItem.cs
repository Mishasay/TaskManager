using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalHub
{
    internal class TaskItem
    {
        public string Title { get; set; }
        public Priority Priority { get; set; }
        public DateTime DeadLine { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(string title, Priority priority, DateTime deadline)
        {
            Title = title;
            Priority = priority;
            DeadLine = deadline;
            IsCompleted = false;
        }

        public void MarkComplited()
        {
            IsCompleted = true;
        }

        public override string ToString()
        {
            string status = IsCompleted ? "[✓]" : "[ ]";
            return $"{status} Title {Title} Priority {Priority} DeadLine {DeadLine}";
        }
    }
}
