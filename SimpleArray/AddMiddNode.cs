public class MiddNode
{
    public int data;
    public MiddNode next;
    public MiddNode(int data)
    {
        this.data = data;
        this.next = null;
    }
}
public class AddMiddNode
{
    public static void Main(string[] args)
    {
        MiddNode n1 = new MiddNode(10);
        MiddNode n2 = new MiddNode(12);
        MiddNode n3 = new MiddNode(22);
        MiddNode n4 = new MiddNode(33);
        MiddNode n5 = new MiddNode(11);

        n1.next = n2;
        n2.next = n3;
        n3.next = n4;
        n4.next = n5;

        MiddNode head = n1;

        //add Node in the front of Linked List
        MiddNode newNode = new MiddNode(99);
        MiddNode current = head;
        
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