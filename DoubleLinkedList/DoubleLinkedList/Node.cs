using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    public class Node
    {
        public int value;
        public Node next;
        public Node prev;
    }

    public class LinkedListOperation
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
                Console.WriteLine("there is nothing to delete!");
            }
        }

        public void InsertAfter(int index, int value)
        {
            if (!IsNull())
            {
                Node tempNode = head;
                Node newNode = new Node();
                newNode.value = value;

                while (tempNode.value != index)
                {
                    tempNode = tempNode.next;

                    if (tempNode == null)
                    {
                        Console.WriteLine("Invalid Input!");
                        return;
                    }
                }

                if (tempNode.next == null)
                {
                    InsertAtLast(value);
                }
                else
                {
                    tempNode.next.prev = newNode;
                    newNode.next = tempNode.next;
                    tempNode.next = newNode;
                    newNode.prev = tempNode.next;
                }
            }
            else
            {
                Console.WriteLine("Something went wrong");
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
                Console.WriteLine("there is nothing to delete!");
            }
        }

        public void DeleteFromMiddle(int popedItemValue)
        {
            if (!IsNull())
            {
                Node tempNode = head;

                if (popedItemValue == head.value)
                {
                    DeleteFromFirst();
                }
                else
                {
                    while (tempNode.value != popedItemValue)
                    {

                        tempNode = tempNode.next;

                        if (tempNode == null)
                        {

                            Console.WriteLine("item not found");
                            return;
                        }
                    }

                    if (tempNode.next == null)
                    {
                        tempNode.prev.next = null;
                    }
                    else
                    {
                        tempNode.prev.next = tempNode.next;
                        tempNode.next.prev = tempNode.prev;
                    }
                }
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
