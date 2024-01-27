using System.Globalization;

namespace programs.Practical2;

public class SumHundred
{

    public static void Main(string[] args)
    {
        int sum = 0;

        for (int i = 1; i <= 100; i++)
        {
            sum = sum + i;
        }

        Console.WriteLine(sum);
    }
}