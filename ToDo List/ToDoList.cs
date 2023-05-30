using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the To-Do List!");

        while (true)
        {
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. View tasks");
            Console.WriteLine("3. Delete task");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    DeleteTask();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the To-Do List. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.WriteLine("Enter the task:");
        string task = Console.ReadLine();
        tasks.Add(task);
        Console.WriteLine("Task added successfully!");
    }

    static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks in the to-do list.");
        }
        else
        {
            Console.WriteLine("Tasks in the to-do list:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    static void DeleteTask()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks in the to-do list.");
        }
        else
        {
            Console.WriteLine("Select the task number to delete:");
            ViewTasks();
            int taskNumber = Convert.ToInt32(Console.ReadLine());

            if (taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task deleted successfully!");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
    }
}

