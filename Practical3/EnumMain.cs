

namespace programs.Practical3;

public enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday


}



class EnumMain
{
    static void Main(string[] args)
    {
        DaysOfWeek currentDay = DaysOfWeek.Saturday;
        int today = (int)DaysOfWeek.Monday;
        Console.WriteLine(today);
        
    }
}