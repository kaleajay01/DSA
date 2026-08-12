public class LastNode1
{
    public int data;
    public LastNode1 next;
    public LastNode1(int data)
    {
        this.data = data;
        this.next = null;
    }
}
public class AddLastNode11
{
    public static void Main(string[] args)
    {
        LastNode1 n1 = new LastNode1(10);
        LastNode1 n2 = new LastNode1(12);
        LastNode1 n3 = new LastNode1(22);
        LastNode1 n4 = new LastNode1(33);
        LastNode1 n5 = new LastNode1(11);

        n1.next = n2;
        n2.next = n3;
        n3.next = n4;
        n4.next = n5;

        LastNode1 head = n1;

        LastNode1 current = head;
        while (current.next != null)
        {
            Console.Write(current.data + " -> ");
            current = current.next;            
        }
        Console.Write("null");
    }
}