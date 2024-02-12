namespace programs.Practical3.Overloading{

class Calc
{
    // Addition
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Overloaded Addition for doubles
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Subtraction
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    // Overloaded Subtraction for doubles
    public double Subtract(double a, double b)
    {
        return a - b;
    }

    // Multiplication
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    // Overloaded Multiplication for doubles
    public double Multiply(double a, double b)
    {
        return a * b;
    }

    // Division
    public int Divide(int a, int b)
    {
        // Assuming non-zero denominator
        return a / b;
    }

    // Overloaded Division for doubles
    public double Divide(double a, double b)
    {
        // Assuming non-zero denominator
        return a / b;
    }
}
}