namespace programs.Practical3.Overloading
{

    class Program
    {
        static void Main()
        {
            Calc calculator = new Calc();

            // Integer Operations
            int sum = calculator.Add(12, 23);
            int difference = calculator.Subtract(22, 4);
            int product = calculator.Multiply(9, 9);
            int quotient = calculator.Divide(9, 3);

            Console.WriteLine($"Integer Sum: {sum}");
            Console.WriteLine($"Integer Difference: {difference}");
            Console.WriteLine($"Integer Product: {product}");
            Console.WriteLine($"Integer Quotient: {quotient}");

            // Double Operations
            double doubleSum = calculator.Add(51.3, 22.2);
            double doubleDifference = calculator.Subtract(18.7, 49.1);
            double doubleProduct = calculator.Multiply(25.3, 2.3);
            double doubleQuotient = calculator.Divide(12.3, 3.0);

            Console.WriteLine($"Double Sum: {doubleSum}");
            Console.WriteLine($"Double Difference: {doubleDifference}");
            Console.WriteLine($"Double Product: {doubleProduct}");
            Console.WriteLine($"Double Quotient: {doubleQuotient}");
        }
    }
}