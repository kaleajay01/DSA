namespace Array.sumofarray;
using Array.arr;
public class Sumofarray()
{
    public int sum()
    {
        Array obj = new Array();
       // int[] number = obj.arr;
        int sum = 0;

        for(int i = 0; i<obj.arr.Length; i++)
        {
            sum = sum + obj.arr[i];
        }
        Console.WriteLine("Sum Of Array:"+sum);
        return sum;
    }
}