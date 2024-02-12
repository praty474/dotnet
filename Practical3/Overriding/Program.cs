namespace programs.Practical3.Overriding;
class Program
{
    static void Main(string[] args)
    {
        Shape shape1 = new Circle(2);
        Shape shape2 = new Rectangle(2, 4);

        shape1.DisplayInfo();
        shape2.DisplayInfo();
    }
}