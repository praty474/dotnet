namespace programs.Practical2
{
    public class PositiveInteger
    {
        public static void Main()
        {
            int userInput;

            do
            {
                Console.Write("Enter a positive integer: ");

                if (int.TryParse(Console.ReadLine(), out userInput))
                {

                    if (userInput > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive integer.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }

            } while (true);

            Console.WriteLine($"You entered a valid positive integer: {userInput}");
        }
    }
}