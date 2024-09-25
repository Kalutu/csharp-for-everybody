using System;

namespace Average_Digit
{
    public class Program
    {
        private static double AverageDigit(int number)
        {
            var sum = 0;
            int count = 0;

            while (number > 0)
            {
                sum += number % 10;
                count++;
                number /= 10;
            }
            return Convert.ToDouble(sum / count);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Average of all digits of a number app.");
            Console.WriteLine("Please enter the number at which you want to proceed.");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The average value of all digits of the number is {0}",AverageDigit(number));


        }
    }
}