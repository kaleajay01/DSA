using System.Diagnostics;
public class AddNodeFirst
{
    public int data;
    public AddNodeFirst prev;
    public AddNodeFirst next;

    public AddNodeFirst(int data)
    {
        this.data = data;
    }
}
public class DoubleLinkedList
{
    public static void Main(string[] args)
    {
        AddNodeFirst n1 = new AddNodeFirst(11);
        AddNodeFirst n2 = new AddNodeFirst(22);
        AddNodeFirst n3 = new AddNodeFirst(33);
        AddNodeFirst n4 = new AddNodeFirst(44);

        //forward linked list
        n1.next = n2;
        n2.next = n3;
        n3.next = n4;

        //backword linked list
        n2.prev = n1;
        n3.prev = n2;
        n4.prev = n3;

        AddNodeFirst head = n1;

        AddNodeFirst newNode = new AddNodeFirst(55);

        newNode.next = head;
        head = newNode;

        AddNodeFirst current = head;

        while(current != null)
        {
            Console.Write(current.data + "->");
            current = current.next;
        }
        Console.Write("");

    }
}