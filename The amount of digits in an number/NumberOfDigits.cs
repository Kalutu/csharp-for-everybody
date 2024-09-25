using System;

namespace Number_of_Digits
{
    public class Program {
        private static int GetNumberOfDigits(int number)
        {

            int count = 0;

            while (number > 0)
            {
                count++;
                number /= 10;
            }
            return count;

        }

        public static void main(String[] args)
        {
            Console.WriteLine("Welcome to the Number of Digits App");
            Console.WriteLine("Please enter a number you want to proceed");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("You entered the number {0}", number);

            int amount_of_digits = GetNumberOfDigits(number);

            Console.WriteLine("The number of digits for the number {0} is {1}",number, amount_of_digits);
        }
    }
}