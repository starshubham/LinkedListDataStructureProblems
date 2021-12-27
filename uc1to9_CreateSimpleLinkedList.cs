using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructureProblems
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int key)
        {
            this.data = key;
            next = null;
        }
    }
    internal class LinkedList
    {
        internal Node head;

        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        public bool InsertAfter(int data, int after)    //insert in between the sequences
        {
            bool flag = false;
            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == after)
                    {
                        Node newNode = new Node(data);
                        newNode.next = temp.next;
                        temp.next = newNode;
                        flag = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (!flag)
                    Console.WriteLine("The Element is Absent");
            }
            return flag;
        }
        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid Position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node newNode = new Node(data);
                        newNode.next = this.head.next;
                        head.next = newNode;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }
        internal int Search(int value)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        public bool DeleteAny(int data)     //delete data
        {
            bool flag = false;
            int count = 0;

            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                Node previousNode = null;
                while (temp != null)
                {
                    count++;
                    if (temp.data == data)
                    {
                        if (count == 1)
                        {
                            head = temp.next;
                        }
                        else
                        {
                            previousNode.next = temp.next;
                        }
                        flag = true;
                        break;
                    }
                    previousNode = temp;
                    temp = temp.next;
                }
                if (!flag)
                    Console.WriteLine("The Element is Absent");
            }

            return flag;
        }
        public int size()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
        internal Node RemoveFirstNode()
        {
            if(this.head == null)
            {
                return null;
            }               
            this.head = this.head.next;
            return this.head;
        }
        internal Node RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
