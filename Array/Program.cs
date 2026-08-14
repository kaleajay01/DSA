using Array.arr;
using Array.lowarray;
using Array.maxarray;
using Array.reversearray;
using Array.sumofarray;

class Program
{
    static void Main()
    {
        Sumofarray obj = new Sumofarray();
        obj.sum();

        Maxarrayvalue obj1 = new Maxarrayvalue();
        obj1.max();

        Lowarrayvalue obj2 = new Lowarrayvalue();
        obj2.low();

        Reversearray obj3 = new Reversearray();
        obj3.reverse();
    }
}