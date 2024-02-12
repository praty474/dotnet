namespace programs.Practical3.Inheritance
{

    class Program

    {
        static void Main(string[] args)
        {
            Book book = new Book(111, "Verity", "Colleen Hoover", 319);
            DVD dvd = new DVD(201, "Avengers: End Game", "Russo Brothers", 180);

            // Display information about the items
            Console.WriteLine("Book Information:");
            book.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("DVD Information:");
            dvd.DisplayInfo();
            Console.WriteLine();

            // Check out the items
            book.CheckOut();
            dvd.CheckOut();
            Console.WriteLine();

            // Display updated information after checking out
            Console.WriteLine("Updated Book Information:");
            book.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Updated DVD Information:");
            dvd.DisplayInfo();
            Console.WriteLine();

            // Return the items
            book.Return();
            dvd.Return();
            Console.WriteLine();

            // Display updated information after returning
            Console.WriteLine("Updated Book Information:");
            book.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Updated DVD Information:");
            dvd.DisplayInfo();
        }
    }
}
