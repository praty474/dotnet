namespace programs.Practical2;

public class Guess
{

    public static void Main(string[] args)
    {

        int userGuess = 0;
        Random number = new Random();
        int guess = number.Next(10);

        Console.WriteLine("Enter a number");
        while (userGuess != guess)
        {
            userGuess = Convert.ToInt32(Console.ReadLine());

            if (userGuess < guess)
            {
                Console.WriteLine("Incorrect guess");
            }
            else if (userGuess > guess)
            {
                Console.WriteLine("Incorrect guess");
            }
            else if (userGuess == guess)
            {
                Console.WriteLine("Correct Guess");
            }
        }




    }
}