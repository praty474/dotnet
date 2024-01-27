using System;

public class Largest
{
    static void Main(string[] args)
    {
        int i = 0;
        int large = 0;
        int[] numbers = { 20, 17, 110, 33, 55 };

        large = numbers[0];


        for (i = 1; i < numbers.Length; i++)
        {
            if (large < numbers[i])
                large = numbers[i];
        }
        Console.WriteLine("Largest element in array : " + large);

    }
}