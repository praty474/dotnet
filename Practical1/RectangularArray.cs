using System;

public class RectangularArray
{
    static void Main(string[] args)
    {
        int m, n, i, j;

        m = 3;
        n = 3;

        char[,] arr = new char[3, 3];
        arr[0, 0] = 'a';
        arr[0, 1] = 'b';
        arr[0, 2] = 'c';
        arr[1, 0] = 'd';
        arr[1, 1] = 'e';
        arr[1, 2] = 'f';
        arr[2, 0] = 'g';
        arr[2, 1] = 'h';
        arr[2, 2] = 'i';


        for (i = 0; i < m; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + "\t");

            }
            Console.WriteLine();
        }

    }
}