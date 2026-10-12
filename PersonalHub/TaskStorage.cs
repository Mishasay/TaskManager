using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace PersonalHub
{
    internal class TaskStorage
    {
        public static void Save(List<TaskItem> tasks)
        {
            string json = JsonSerializer.Serialize(tasks);
            File.WriteAllText("tasks.json", json);
        }

        public static List<TaskItem> Load()
        {
            if (File.Exists("tasks.json"))
            {
                string json = File.ReadAllText("tasks.json");
                List<TaskItem> loadedTasks = JsonSerializer.Deserialize<List<TaskItem>>(json);
                return loadedTasks;
            }
            else
            {
                return new List<TaskItem>();
            }
        }
    }
}
