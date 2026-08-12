using System.Formats.Asn1;

namespace swaap;

class Swaap
{
    public void swap()
    {
        int a = 10;
        int b = 11;
        Console.WriteLine("After swap");
        Console.WriteLine("A:" + a);
        Console.WriteLine("B:" + b);
        int temp = a;

        a = b;
        b = temp;
        Console.WriteLine("Before swap");
        Console.WriteLine("A:" + a);
        Console.WriteLine("B:" + b);
    }
    static void Main()
    {
        Swaap P1 = new Swaap();
        P1.swap();
    }
}