using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpenseTracker
{
    class Expense
    {
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
    }

    class Program
    {
        static List<Expense> expenses = new List<Expense>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== Expense Tracker ====");
                Console.WriteLine("1. Enter Expense");
                Console.WriteLine("2. Categorize Expenses");
                Console.WriteLine("3. Monthly Budgeting");
                Console.WriteLine("4. View Reports");
                Console.WriteLine("5. Exit");
                Console.WriteLine("==========================");
                Console.Write("Enter your choice (1-5): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        EnterExpense();
                        break;
                    case "2":
                        CategorizeExpenses();
                        break;
                    case "3":
                        MonthlyBudgeting();
                        break;
                    case "4":
                        ViewReports();
                        break;
                    case "5":
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

        static void EnterExpense()
        {
            Console.Clear();
            Console.WriteLine("==== Enter Expense ====");
            Console.Write("Enter the amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the description: ");
            string description = Console.ReadLine();
            Console.Write("Enter the category: ");
            string category = Console.ReadLine();
            DateTime date = DateTime.Now;

            expenses.Add(new Expense
            {
                Amount = amount,
                Description = description,
                Category = category,
                Date = date
            });

            Console.WriteLine("Expense entered successfully.");
        }

        static void CategorizeExpenses()
        {
            Console.Clear();
            Console.WriteLine("==== Categorize Expenses ====");

            if (expenses.Count == 0)
            {
                Console.WriteLine("No expenses found.");
                return;
            }

            Console.WriteLine("Expense List:");
            for (int i = 0; i < expenses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Amount: {expenses[i].Amount}, Description: {expenses[i].Description}");
            }

            Console.Write("Enter the expense number to categorize: ");
            int expenseNumber = int.Parse(Console.ReadLine());

            if (expenseNumber < 1 || expenseNumber > expenses.Count)
            {
                Console.WriteLine("Invalid expense number.");
                return;
            }

            Expense expense = expenses[expenseNumber - 1];

            Console.Write("Enter the category: ");
            string category = Console.ReadLine();

            expense.Category = category;

            Console.WriteLine("Expense categorized successfully.");
        }

        static void MonthlyBudgeting()
        {
            Console.Clear();
            Console.WriteLine("==== Monthly Budgeting ====");

            if (expenses.Count == 0)
            {
                Console.WriteLine("No expenses found.");
                return;
            }

            Console.WriteLine("Expense List:");
            for (int i = 0; i < expenses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Amount: {expenses[i].Amount}, Category: {expenses[i].Category}");
            }

            Console.Write("Enter the month (1-12): ");
            int month = int.Parse(Console.ReadLine());

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Invalid month number.");
                return;
            }

            Console.Write("Enter the year: ");
            int year = int.Parse(Console.ReadLine());

            decimal totalExpense = expenses
                .Where(e => e.Date.Month == month && e.Date.Year == year)
                .Sum(e => e.Amount);

            Console.WriteLine($"Total expenses for {month}/{year}: {totalExpense}");
        }

        static void ViewReports()
        {
            Console.Clear();
            Console.WriteLine("==== View Reports ====");

            if (expenses.Count == 0)
            {
                Console.WriteLine("No expenses found.");
                return;
            }

            Console.WriteLine("Expense List:");
            for (int i = 0; i < expenses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Amount: {expenses[i].Amount}, Category: {expenses[i].Category}");
            }

            Console.Write("Enter the category to view expenses: ");
            string category = Console.ReadLine();

            List<Expense> categoryExpenses = expenses
                .Where(e => e.Category == category)
                .ToList();

            if (categoryExpenses.Count == 0)
            {
                Console.WriteLine("No expenses found for the category.");
                return;
            }

            Console.WriteLine($"Expenses for Category: {category}");
            foreach (var expense in categoryExpenses)
            {
                Console.WriteLine($"Amount: {expense.Amount}, Description: {expense.Description}");
            }
        }
    }
}

