namespace programs.Practical3.Overriding;
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Rectangle - Width: {Width}, Height: {Height}, Area: {CalculateArea()}");
    }
}
