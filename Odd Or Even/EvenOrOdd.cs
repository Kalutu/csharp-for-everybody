using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Odd Or Even");

        Console.WriteLine("\nPlease enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is an even number.");
        }
        else
        {
            Console.WriteLine($"{number} is an odd number.");
        }
    }
}