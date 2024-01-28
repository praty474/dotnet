

namespace programs.Practical2
{
    class Reference
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"value of b is {b}");
            swap(ref a, ref b);
            Console.WriteLine($"value of a is {a} value of b is {b}");



            void swap(ref int a, ref int b)
            {
                a = a + b;
                b = a - b;
                a = a - b;


            }



        }
    }
}