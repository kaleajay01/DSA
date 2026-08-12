public class Node1
{
    public int data;
    public Node1 next;
    public Node1(int data)
    {
        this.data = data;
        this.next = null;
    }
}
public class DeleteNode1
{
    public static void Main(string[] args)
    {
        Node1 n1 = new Node1(10);
        Node1 n2 = new Node1(12);
        Node1 n3 = new Node1(22);
        Node1 n4 = new Node1(33);
        Node1 n5 = new Node1(11);

        n1.next = n2;
        n2.next = n3;
        n3.next = n4;
        n4.next = n5;

        Node1 head = n1;

        Node1 current = head.next;
        while (current != null)
        {
            Console.Write(current.data + " -> ");
            current = current.next;
        }

        Console.Write("null");
    }
}









// public void DeleteFromEnd()
// {
//     Node current = head;
//     while (current.next.next != null)
//     {
//         current = current.next;
//     }
//     current.next = null;

// }

// public void DeleteFromFirst()
// {
//     head = head.next;

// }

// public void DeleteFromMiddle(int data)
// {
//     Node current = head;
//     while (current.next.data != data)
//     {
//         current = current.next;
//     }
//     current.next = current.next.next;

// }