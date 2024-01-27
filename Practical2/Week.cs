namespace programs.Practical2;

using System;

class Week
{

    static void Main(string[] args)
    {
        Console.WriteLine("Enter day of week");
        string? day = Console.ReadLine();


        switch (day)
        {

            case "SUNDAY":
                Console.WriteLine("Weekend");
                break;


            case "MONDAY":
                Console.WriteLine("Week day");
                break;
            case "TUESDAY":
                Console.WriteLine("Week day");
                break;
            case "WEDNESDAY":
                Console.WriteLine("Week day");
                break;
            case "THURSDAY":
                Console.WriteLine("Week day");
                break;
            case "FRIDAY":
                Console.WriteLine("Week day");
                break;
            case "SATURDAY":
                Console.WriteLine("Weekend");
                break;



        }
    }
}