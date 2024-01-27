using System;

namespace programs.Practical2;



public class LeapYear
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Year");
        int year = Convert.ToInt32(Console.ReadLine());
        if (year % 4 == 0)
        {
            Console.WriteLine("Leap year");
        }
        else
        {
            Console.WriteLine("Not a leap year");
        }
    }

}