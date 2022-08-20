using System;
namespace Day14_LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Problem");
            Console.WriteLine("==============================");

            LinkedList list= new LinkedList();

            //list.Add(70);
            //list.Add(30);
            //list.Add(56);
            //list.Display();

            list.Append(56);
            list.Append(70);
            list.Insert(30,56);
            list.Display();
            // list.DeleteNodeAtFirst();
            // list.PopLast();
            Console.WriteLine("Search For Node value 30");
            list.Display();
            if (list.Search(30))
            {
                Console.WriteLine("\nNode with value 30 is available in Linked list");
            }
            list.Display();
        }
    }
}
 