using System;

class Calculator {
    static void Main(string[] args) {
        double num1, num2, result;
        char op;

        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter an operator (+, -, *, /): ");
        op = Convert.ToChar(Console.ReadLine());

        switch(op) {
            case '+':
                result = num1 + num2;
                Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
                break;

            case '-':
                result = num1 - num2;
                Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
                break;

            case '*':
                result = num1 * num2;
                Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
                break;

            case '/':
                if (num2 == 0) {
                    Console.WriteLine("Error: division by zero");
                } else {
                    result = num1 / num2;
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
                }
                break;

            default:
                Console.WriteLine("Invalid operator");
                break;
        }
    }
}
