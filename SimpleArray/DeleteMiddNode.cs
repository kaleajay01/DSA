using System;

public class DeleteMiddNode
{
    public int data;
    public DeleteMiddNode next;

    public DeleteMiddNode(int data)
    {
        this.data = data;
        this.next = null;
    }
}

public class UpdateNode
{
    public static void Main(string[] args)
    {
        DeleteMiddNode n1 = new DeleteMiddNode(10);
        DeleteMiddNode n2 = new DeleteMiddNode(12);
        DeleteMiddNode n3 = new DeleteMiddNode(22);
        DeleteMiddNode n4 = new DeleteMiddNode(33);
        DeleteMiddNode n5 = new DeleteMiddNode(11);

        n1.next = n2;
        n2.next = n3;
        n3.next = n4;
        n4.next = n5;

        DeleteMiddNode head = n1;

        // Value to search
        int oldValue = 11;

        // New value
        int newValue = 57;

        DeleteMiddNode current = head;

        while (current != null)
        {
            if (current.data == oldValue)
            {
                current.data = newValue;
                break;
            }

            current = current.next;
        }

        // Display the updated linked list
        current = head;

        while (current != null)
        {
            Console.Write(current.data + " -> ");
            current = current.next;
        }

        Console.Write("null");
    }
}