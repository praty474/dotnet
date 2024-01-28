namespace programs.Practical2
{


    using System;

    class PrimeNumber
    {
        static void Main()
        {
            int startRange = 10;
            int endRange = 50;

            Console.WriteLine($"Finding the first prime number between {startRange} and {endRange}...");

            for (int number = startRange; number <= endRange; number++)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine($"The first prime number between {startRange} and {endRange} is: {number}");
                    break;
                }
            }
        }


        static bool IsPrime(int num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}

