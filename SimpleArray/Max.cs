using System.Globalization;

namespace Simple;

class Max
{
    static void Main()
    {
        int[,] a =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int c = a[0, 0];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (c < a[i, j])
                {
                    c = a[i,j];
                }
            }
        }

        Console.WriteLine("Max Number in matrix:" + c);
    }
}