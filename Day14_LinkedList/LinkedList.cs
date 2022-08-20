using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_LinkedList
{
    public class LinkedList
    {
        public Node head;
        public Node tail;

        public void Add(int data)
        {

            Node node = new Node(data);
              this.head= node;
            //    Node node = new Node(data);
            //    if (this.head == null)
            //        this.head = node;
            //    else
            //    {
            //        Node temp = head;
            //        while(temp.next != null)
            //        {
            //            temp = temp.next;
            //        }
            //        temp.next = node;
            //    }

            //Console.WriteLine("{0} is inserted into Linked List", node.data);
        }
        public void Insert(int data,int previous)
        {
            
                Node newNode = new Node(data);
                if (head == null & tail == null)
                {
                    head = newNode;
                }
                else
                {
                    Node temp = head;
                    
                    while (temp.data != previous)
                    {
                        temp = temp.next;
                    }
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
            
        }
        public void Append(int data)
        {

            Node node = new Node(data);
           
            if (head == null & tail == null)
            {
                head = node;
                tail = node;
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
            Console.WriteLine($"Added {data} at start of the linkedlist");
        }

        internal void Display()
        {
            Node temp= this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while(temp != null)
            {
                Console.WriteLine(temp.data+"");
                 temp = temp.next;

            }

        }
    }
}
