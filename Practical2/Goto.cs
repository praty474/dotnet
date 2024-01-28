using System;
namespace programs.Practical2
{
    class Goto
    {
        static void Main(string[] args)
        {

        top:
            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                goto top;

            }
            else
            {
                Console.WriteLine("number is positive");
                Console.ReadLine();
            }
        }
    }
}