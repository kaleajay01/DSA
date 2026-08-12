using System.Globalization;

namespace Simple;

class Simple
{
    static void Main()
    {
        int [,] a=
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int [,] b =
        {
            {4, 6, 8},
            {9, 2, 1},
            {5, 9, 1}
        };

        Console.WriteLine("Addition of 2 matrix");
        int[,] c = new int[3,3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j<3; j++)
            {
                c [i,j] = a[i,j]+b[i,j];
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(c[i, j]+"\t");
            }
            Console.WriteLine();
        }
    }
}