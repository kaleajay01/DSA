// public class Node
// {
//     public int data;
//     public Node next;
//     public Node(int data)
//     {
//         this.data = data;
//         this.next = null;
//     }
// }
// public class LinkedList
// {
//     public static void Main(string[] args)
//     {
//         Node n1 = new Node(10);
//         Node n2 = new Node(12);
//         Node n3 = new Node(22);
//         Node n4 = new Node(33);
//         Node n5 = new Node(11);

//         n1.next = n2;
//         n2.next = n3;
//         n3.next = n4;
//         n4.next = n5;

//         Node head = n1;

//         Node current = head;

//         while (current != null)
//         {
//             Console.Write(current.data + " -> ");
//             current = current.next;
//         }

//         Console.Write("");
//     }
// }