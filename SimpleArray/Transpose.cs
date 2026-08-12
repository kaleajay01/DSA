using System;
using System.Runtime.CompilerServices;

class Transpose
{
    static void Main()
    {
        int[,] a =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] b =
        {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

        int[,] sum = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                sum[i, j] = a[j, i];
            }
        }
        Console.WriteLine("Transpose matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(sum[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}


