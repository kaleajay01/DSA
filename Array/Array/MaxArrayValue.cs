namespace Array.maxarray;
using Array.arr;
public class Maxarrayvalue
{
    public int max()
    {
        Array obj = new Array(); 
        int[] number = obj.arr;
        int max = obj.arr[0];
        for (int i = 0; i<obj.arr.Length; i++)
        {
            if (obj.arr[i] > max)
            {
                max = obj.arr[i];
            }
        }
        Console.WriteLine("Max Value In the Array:"+max);
        return max;
    }
}