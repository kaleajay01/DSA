using System.Diagnostics;

public class AddNodeMidd
{
    public int data;
    public AddNodeMidd prev;
    public AddNodeMidd next;

    public AddNodeMidd(int data)
    {
        this.data = data;
    }
}

public class DoubleLinkedList
{
    public static void Main(string[] args)
    {
        AddNodeMidd n1 = new AddNodeMidd(11);
        AddNodeMidd n2 = new AddNodeMidd(22);
        AddNodeMidd n3 = new AddNodeMidd(33);
        AddNodeMidd n4 = new AddNodeMidd(44);

        //forward linked list
        n1.next = n2;
        n2.next = n3;
        n3.next = n4;

        //backword linked list
        n2.prev = n1;
        n3.prev = n2;
        n4.prev = n3;

        AddNodeMidd head = n1;
        AddNodeMidd newNode = new AddNodeMidd(26);
        AddNodeMidd current = head;

        while (current.next.data < newNode.data)
        {
            current = current.next;
        }
        
        newNode.next = current.next;
        current.next.prev = newNode;
        current.next = newNode;
        newNode.prev = current;

        current = head;
        while (current != null)
        {
            Console.Write(current.data + "->");
            current = current.next;
        }
        Console.Write("");

    }
}