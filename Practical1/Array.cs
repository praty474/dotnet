using System;
namespace programs.Practical1;
public class Array
{
    static void Main(string[] args)
    {
        char[] abc = ['a', 'b', 'c', 'd', 'e'];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("The value of index {0} is {1}", i, abc[i]);
        }
    }
}