using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Odd Or Even");
        Console.WriteLine("Please enter a number:");
        
        try{
            int number = Convert.ToInt32(Console.ReadLine());
            string result =  number % 2 == 0 ? "even" : "odd";
            Console.WriteLine($"{number} is {result} number.");
            
        }catch (FormatException){
            Console.WriteLine($"Not a number.");
        }
    }
}
