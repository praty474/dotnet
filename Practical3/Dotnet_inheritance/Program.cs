
using System;
namespace programs.Practical3.Dotnet_inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Print();

            B b = new B();
            b.Print();

            object[] arr = new object[]{
                "Pratyush",
                1,
                false
            };
            foreach (object item in arr)
            {
                if (item is string)
                {
                    Console.WriteLine($"String item is {item}");
                }
                else if (item is int)
                {
                    Console.WriteLine($"Int item is {item}");
                }
                else if (item is bool)
                {
                    Console.WriteLine($"Bool item is {item}");
                }
            }
        }
    }
}