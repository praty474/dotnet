namespace programs.Practical3.Overriding;
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Circle - Radius: {Radius}, Area: {CalculateArea()}");
    }
}