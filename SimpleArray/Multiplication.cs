using System;

class Multiplication
{
    static void Main()
    {
        int[,] A =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] B =
        {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

        int[,] C = new int[3, 3];

        // Matrix Multiplication
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            { 
                for (int k = 0; k < 3; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        Console.WriteLine("Result of Matrix Multiplication:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(C[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}