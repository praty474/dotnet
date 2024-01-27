using System;

namespace programs.Practical2;

public class Grading
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter obtained marks");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks > 90)
        {
            Console.WriteLine("A");
        }
        else if (marks > 80)
        {
            Console.WriteLine("B");
        }
        else if (marks > 60)
        {
            Console.WriteLine("C");
        }
        else if (marks > 40)
        {
            Console.WriteLine("D");
        }
        else if (marks < 40)
        {
            Console.WriteLine("F");
        }

    }
}