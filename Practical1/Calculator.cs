using System;

class Calculator
{
    static void Main(string[] args)
    {
        int result;

        Console.Write("Enter first Num ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second Num ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter symbol(+,-,*,/)");
        string? symbol = Console.ReadLine();

        switch (symbol)
        {

            case "+":
                result = num1 + num2;
                Console.Write("Addition of {0} and {1} is {2} ", num1, num2, result);
                break;
            case "-":
                result = num1 - num2;
                Console.Write("Subtraction of {0} and {1} is {2} ", num1, num2, result);
                break;
            case "*":
                result = num1 * num2;
                Console.Write("Multiplication of {0} and {1} is {2} ", num1, num2, result);
                break;
            case "/":
                result = num1 / num2;
                Console.Write("Division of {0} and {1} is {2} ", num1, num2, result);
                break;
        }
    }
}