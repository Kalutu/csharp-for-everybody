using System;
namespace Maximum_and_Minimum_Digit
{
    public class Program
    {
        private static int MaxDigit(int number)
        {
            int max = int.MinValue;

            while (number > 0)
            {
                int digit = number % 10;
                if (digit > max)
                {
                    max = digit;
                }
                number /= 10;
            }
            return max;
        }
        private static int MinDigit(int number)
        {
            int min = int.MaxValue;

            while (number > 0)
            {
                int digit = number % 10;
                if (digit < max)
                {
                    min = digit;
                }
                number /= 10;
            }
            return min;
        }

        public static void main(String[] args)
        {
            Console.WriteLine("Welcome to the Maximum and Minimum Digits App");
            Console.WriteLine("Please enter a number to find a max and min digits.");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Maximum digit is {0}", MaxDigit(number));
            Console.WriteLine("Minimum digit is {0}", MinDigit(number));

        }
    }
}