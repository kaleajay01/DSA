namespace Array.reversearray;

using Array.arr;

public class Reversearray
{
    int count=0;
    public int reverse()
    {
        
        Array obj = new Array();

        for (int i = obj.arr.Length - 1; i >= 0; i--)
        {
            Console.Write( obj.arr[i]+" , ");
        }
        Console.WriteLine("");
        count++;
        // int start = 0;
        // int end = obj.arr.Length - 1;

        // while(start < end)
        // {
        //     int temp = obj.arr[start];
        //     obj.arr[start] = obj.arr[end];

        // }
        if(count==3)
        {
            return 0;  
        }
        
        return reverse();
    }
}