namespace DoubleLinkedList
{
    public class Node
    {
        public int value;
        public Node next;
        public Node prev;
    }

    public class Operation
    {
        Node head = null;

        public bool IsNull()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void InsertAtFirst(int value)
        {
            if (IsNull())
            {
                Node newNode = new Node();

                newNode.value = value;
                newNode.next = null;
                newNode.prev = null;

                head = newNode;
            }
            else
            {
                Node newNode = new Node();
                newNode.value = value;

                newNode.next = head;
                newNode.prev = null;
                head.prev = newNode;

                head = newNode;
            }
        }

        public void InsertAtLast(int value)
        {
            if (IsNull())
            {
                Node newNode = new Node();

                newNode.value = value;
                newNode.next = null;
                newNode.prev = null;

                head = newNode;
            }
            else
            {
                Node newNode = new Node();
                newNode.value = value;

                Node lastFoundNode = head;
                while (lastFoundNode.next != null)
                {
                    lastFoundNode = lastFoundNode.next;
                }

                newNode.prev = lastFoundNode;
                newNode.next = null;
                lastFoundNode.next = newNode;
            }
        }

        public void DeleteFromLast() 
        {
            if (!IsNull())
            {
                Node lastNode = head;

                while (lastNode.next != null)
                {
                    lastNode = lastNode.next;

                }

                if (lastNode.prev == null)
                {
                    head = null; 
                }
                else
                {
                    lastNode.prev.next = null;
                }
            }
            else
            {
                Console.WriteLine("there is nothing in order to delete!");
            }
        }

        public void DeleteFromFirst()
        {
            if (!IsNull())
            {
                Node tempNode = head.next;
                head = null;
                head = tempNode;
            }
            else
            {
                Console.WriteLine("there is nothing in order to delete!");
            }
        }

        public void ClearList()     
        {
            if (!IsNull()) 
            {
                head = null;
            }
            else
            {
                Console.WriteLine("there is nothing in order to delete!");
            }
        }

        public void Print()
        {
            if (!IsNull())
            {
                Node tempNode = head;
                while (tempNode != null)
                {
                    Console.WriteLine(tempNode.value);
                    tempNode = tempNode.next;
                }
            }
        }
    }
}
