using System.Globalization;

namespace Simple;

class Sorting
{
    static void Main()
    {
        int[] a ={12,23,43,54,12,11};

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i+1; j<a.Length; j++)
            {
                if (a[i]>a[j])
                {
                    int temp = a[i];
                    a[i]=a[j];
                    a[j]=temp;
                }
            }
        }

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i]+" ");
        }
    }
}