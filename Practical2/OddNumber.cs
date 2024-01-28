
namespace programs.Practical2
{

    public class OddNumber
    {


        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    if (i == 5)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }



            }

        }
    }
}