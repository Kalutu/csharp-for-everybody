using System;

namespace Sum_Of_Digits
{
    public class Program
    {
        private static int SumOfDigits(int number)
        {
            int result = 0;

            while (number > 0)
            {
                result += number % 10;
                number /= 10;
            }
            return result;
        }

        public static void main(string[] args)
        {
            Console.WriteLine("Welcome to the Sum of Digits App");
            Console.WriteLine("Please enter the number for which you want to get a sum of digits");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of digits for {0} is {1}",number,SumOfDigits(number));

        }
    }
}