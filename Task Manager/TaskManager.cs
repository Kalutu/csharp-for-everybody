using System;
using System.Collections.Generic;

namespace TaskManager
{
    class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
    }

    class Program
    {
        static List<Task> tasks = new List<Task>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== Task Manager ====");
                Console.WriteLine("1. View Tasks");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. Update Task");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Mark Task as Completed");
                Console.WriteLine("6. Exit");
                Console.WriteLine("======================");
                Console.Write("Enter your choice (1-6): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewTasks();
                        break;
                    case "2":
                        AddTask();
                        break;
                    case "3":
                        UpdateTask();
                        break;
                    case "4":
                        DeleteTask();
                        break;
                    case "5":
                        MarkTaskAsCompleted();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        static void ViewTasks()
        {
            Console.Clear();
            Console.WriteLine("==== View Tasks ====");
            
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                var task = tasks[i];
                Console.WriteLine($"{i + 1}. {task.Name}");
                Console.WriteLine($"   Description: {task.Description}");
                Console.WriteLine($"   Due Date: {task.DueDate.ToString("MM/dd/yyyy")}");
                Console.WriteLine($"   Status: {(task.IsCompleted ? "Completed" : "Not Completed")}");
                Console.WriteLine();
            }
        }

        static void AddTask()
        {
            Console.Clear();
            Console.WriteLine("==== Add Task ====");
            Console.Write("Enter the task name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the task description: ");
            string description = Console.ReadLine();
            Console.Write("Enter the due date (MM/dd/yyyy): ");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());

            tasks.Add(new Task
            {
                Name = name,
                Description = description,
                DueDate = dueDate,
                IsCompleted = false
            });

            Console.WriteLine("Task added successfully.");
        }

        static void UpdateTask()
        {
            Console.Clear();
            Console.WriteLine("==== Update Task ====");
            Console.Write("Enter the task number to update: ");
            int taskNumber = int.Parse(Console.ReadLine());

            if (taskNumber < 1 || taskNumber > tasks.Count)
            {
                Console.WriteLine("Invalid task number.");
                return;
            }

            var task = tasks[taskNumber - 1];

            Console.Write("Enter the updated task name: ");
            task.Name = Console.ReadLine();
            Console.Write("Enter the updated task description: ");
            task.Description = Console.ReadLine();
            Console.Write("Enter the updated due date (MM/dd/yyyy): ");
            task.DueDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Task updated successfully.");
        }

        static void DeleteTask()
        {
            Console.Clear();
            Console.WriteLine("==== Delete Task ====");
            Console.Write("Enter the task number to delete: ");
            int taskNumber = int.Parse(Console.ReadLine());

            if (taskNumber < 1 || taskNumber > tasks.Count)
            {
                Console.WriteLine("Invalid task number.");
                return;
            }

            tasks.RemoveAt(taskNumber - 1);

            Console.WriteLine("Task deleted successfully.");
        }

        static void MarkTaskAsCompleted()
        {
            Console.Clear();
            Console.WriteLine("==== Mark Task as Completed ====");
            Console.Write("Enter the task number to mark as completed: ");
            int taskNumber = int.Parse(Console.ReadLine());

            if (taskNumber < 1 || taskNumber > tasks.Count)
            {
                Console.WriteLine("Invalid task number.");
                return;
            }

            var task = tasks[taskNumber - 1];
            task.IsCompleted = true;

            Console.WriteLine("Task marked as completed.");
        }
    }
}

