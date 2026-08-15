namespace Array.find2ndsmallestvalue;
using Array.arr;

public class Find2ndsmallestvalue
{
    public int secondlowvalue()
    {
        Array obj = new Array();
        int firsts = obj.arr[obj.arr.Length-1] ;
        int seconds = obj.arr[obj.arr.Length-1];

        for(int i =  0; i < obj.arr.Length; i++)
        {
            if (obj.arr[i] < firsts)
            {
                seconds = firsts;
                firsts = obj.arr[i];
            }
            else if(obj.arr[i]<seconds && seconds != firsts)
            {
                seconds = obj.arr[i];
            }
        }
        Console.WriteLine("Second Smallest Number:"+seconds);
        return seconds ;
    }
}