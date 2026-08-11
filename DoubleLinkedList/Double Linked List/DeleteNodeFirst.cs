using System.Diagnostics;
public class DeleteNodeFirst
{
    public int data;
    public DeleteNodeFirst prev;
    public DeleteNodeFirst next;

    public DeleteNodeFirst(int data)
    {
        this.data = data;
    }
}
public class DoubleLinkedListt
{
    public static void Main(string[] args)
    {
        DeleteNodeFirst n1 = new DeleteNodeFirst(11);
        DeleteNodeFirst n2 = new DeleteNodeFirst(22);
        DeleteNodeFirst n3 = new DeleteNodeFirst(33);
        DeleteNodeFirst n4 = new DeleteNodeFirst(44);

        //forward linked list
        n1.next = n2;
        n2.next = n3;
        n3.next = n4;

        //backword linked list
        n2.prev = n1;
        n3.prev = n2;
        n4.prev = n3;

        DeleteNodeFirst head = n1;

        DeleteNodeFirst newNode = new DeleteNodeFirst(55);

        newNode.next = head;
        head = newNode;

        DeleteNodeFirst current = head;
        
        while(current != null)
        {
            Console.Write(current.data + "->");
            current = current.next;
        }
        Console.Write("");

    }
}