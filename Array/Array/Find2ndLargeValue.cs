namespace Array.find2ndlargevalue;
using Array.arr;

public class Find2ndlargevalue
{
    public int secondmaxvalue()
    {

        int firstl = 0;
        int secondl = 0;
        Array obj = new Array();

        for(int i =  0; i < obj.arr.Length; i++)
        {
            if (obj.arr[i] > firstl)
            {
                secondl = firstl;
                firstl = obj.arr[i];
            }
            else if(obj.arr[i]>secondl && secondl != firstl)
            {
                secondl = obj.arr[i];
            }
        }
        Console.WriteLine("Second Large Number:"+secondl);
        return secondl ;
    }
}