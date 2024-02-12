namespace programs.Practical3.Overriding;
class Shape
{
    public virtual double CalculateArea()
    {
        return 0;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("This is a generic shape.");
    }
}