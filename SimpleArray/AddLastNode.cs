public class LastNode
{
    public int data;
    public LastNode next;
    public LastNode(int data)
    {
        this.data = data;
        this.next = null;
    }
}
public class AddLastNode
{
    public static void Main(string[] args)
    {
        LastNode n1 = new LastNode(10);
        LastNode n2 = new LastNode(12);
        LastNode n3 = new LastNode(22);
        LastNode n4 = new LastNode(33);
        LastNode n5 = new LastNode(11);

        n1.next = n2;
        n2.next = n3;
        n3.next = n4;
        n4.next = n5;

        LastNode head = n1;

        //add Node in the front of Linked List
        LastNode newNode = new LastNode(99);
        LastNode current = head;

        while(current.next != null)
        {
            current = current.next;
        }
        current.next = newNode;

        current = head;
        while (current != null)
        {
            Console.Write(current.data + " -> ");
            current = current.next;            
        }
        Console.Write("null");
    }
}