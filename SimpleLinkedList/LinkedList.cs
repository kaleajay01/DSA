using LinkedList.CreateNode;

namespace LinkedList.List
{
    public class linkedlist
    {
        Node head = null;


        public void AddNodeEnd(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = node;

            }
        }

        public void AddNodeMiddle(int data,int loc)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node current = head;
                int traverseIndex=1;
                while (traverseIndex != loc-1)
                {
                    current = current.next;
                    traverseIndex++;
                }
                node.next= current.next;
                current.next=node;

            }
        }

        public void AddNodeFirst(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
        }

        public void display()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + "-->");
                current = current.next;
            }
        }

        public void DeleteFromEnd()
        {
            Node current = head;
            while (current.next.next != null)
            {
                current = current.next;
            }
            current.next = null;

        }

        public void DeleteFromFirst()
        {
            head = head.next;

        }

        public void DeleteFromMiddle(int data)
        {
            Node current = head;
            while (current.next.data != data)
            {
                current = current.next;
            }
            current.next = current.next.next;

        }


    }

}