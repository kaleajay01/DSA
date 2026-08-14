namespace Array.lowarray;
using Array.arr;

public class Lowarrayvalue()
{
    public int low()
    {
        Array obj = new Array();
        int[] number = obj.arr;
        int low = obj.arr[0];

        for(int i = 0; i < obj.arr.Length; i++)
        {
            if (obj.arr[i] < low)
            {
                low = obj.arr[i];
            }
        }
        Console.WriteLine("Low value in the Array:"+low);
        return low;
    }
}