using System.Diagnostics;

public class AddNodeLast
{
    public int data;
    public AddNodeLast prev;
    public AddNodeLast next;

    public AddNodeLast(int data)
    {
        this.data = data;
    }
}

public class DoubleLinkedList
{
    public static void Main(string[] args)
    {
        AddNodeLast n1 = new AddNodeLast(11);
        AddNodeLast n2 = new AddNodeLast(22);
        AddNodeLast n3 = new AddNodeLast(33);
        AddNodeLast n4 = new AddNodeLast(44);

        //forward linked list
        n1.next = n2;
        n2.next = n3;
        n3.next = n4;

        //backword linked list
        n2.prev = n1;
        n3.prev = n2;
        n4.prev = n3;

        AddNodeLast head = n1;
        AddNodeLast newNode = new AddNodeLast(55);
        AddNodeLast current = head;

        while (current.next != null)
        {
            current = current.next;
        }

        current.next = newNode;
        newNode.prev = current;

        Console.WriteLine("after insert:");
        current = head;

        while (current != null)
        {
            Console.Write(current.data + "->");
            current = current.next;
        }
        Console.Write("");

    }
}