using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Temperature Converter");

        while (true)
        {
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Convert Celsius to Fahrenheit");
            Console.WriteLine("2. Convert Fahrenheit to Celsius");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ConvertCelsiusToFahrenheit();
                    break;
                case "2":
                    ConvertFahrenheitToCelsius();
                    break;
                case "3":
                    Console.WriteLine("Thank you for using the Temperature Converter. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ConvertCelsiusToFahrenheit()
    {
        Console.WriteLine("Enter the temperature in Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"{celsius}°C is equivalent to {fahrenheit}°F.");
    }

    static void ConvertFahrenheitToCelsius()
    {
        Console.WriteLine("Enter the temperature in Fahrenheit:");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine($"{fahrenheit}°F is equivalent to {celsius}°C.");
    }
}

