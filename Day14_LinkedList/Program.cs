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

            Console.WriteLine("Enter the following to perform refered operation");
            Console.WriteLine("\n\n1.To create Simple Linked list \n2.To add 30,56,70 in list \n3.To append 30 and 70 in linked list" +
                "\n4.To insert 30 in between 56 and 70 \n5.To delete first element of linked list \n6.To delete last element of linked list" +
                "\n7.To search 30 in linked list \n8.To insert 40 after 30 in linked list \n9.To delete 40 frm linked list" +
                "\n10.To order linked list in ascending order\n\n\n");
            int entry = Convert.ToInt32(Console.ReadLine());

            switch (entry)
            {
                case 1:
                    Console.WriteLine("\nCreating Simple Linked List\n");
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    Console.WriteLine("\nLinked List Contains:");
                    list.Display();
                    break;
                case 2:
                    Console.WriteLine("\nAdding 30 and 56 to 70");
                    list.Add(70);
                    list.Add(30);
                    list.Add(56);
                    Console.WriteLine("\nLinked List Contains:");
                    list.Display();
                    break;
                case 3:
                    Console.WriteLine("\nAppending in Linked List");
                    list.Add(56);
                    list.Append(30);
                    list.Append(70);
                    Console.WriteLine("\nLinked List Contains:");
                    list.Display();
                    break;
                case 4:
                    Console.WriteLine("\nInserting 30 between 70 & 56");
                    list.Add(56);
                    list.Add(70);
                    list.Insert(30, 56);
                    Console.WriteLine("\nLinked List Contains:");
                    list.Display();
                    break;
                case 5:
                    Console.WriteLine("\nDeleting first element of linked list");
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    Console.WriteLine("\nLinked List Contains:");
                    list.Display();
                    list.DeleteNodeAtFirst();
                    Console.WriteLine("\nLinked List Contains:");
                    list.Display();
                    break;
                case 6:
                    Console.WriteLine("Deleting last element in inked list");
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    Console.WriteLine("\nLinked List Contains:");
                    list.Display();
                    list.PopLast();
                    Console.WriteLine("\nAfter Deleting last element");
                    Console.WriteLine("Linked List Contains:");
                    list.Display();
                    break;
                case 7:
                    Console.WriteLine("Search in linked list");
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    Console.WriteLine("\nSearching node with value 30 in linked list:");
                    if (list.Search(30))
                    {
                        Console.WriteLine("\nNode with value 30 is available in Linked list");
                    }
                    list.Display();
                    break;
                case 8:
                    Console.WriteLine("inserting 40 after 30");
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.Display();
                    Console.WriteLine("\nNode with value 30 is available in Linked list");
                    list.InsertNode(40, 30);
                    list.Display();
                    break;
                case 9:
                    Console.WriteLine("Deleting 40 from linkedlist");
                    break;
                case 10:
                    Console.WriteLine("Ordering linked list in Ascending order");
                    break;
            }
            //list.Add(70);
            //list.Add(30);
            //list.Add(56);
            //list.Display();

            //list.Append(56);
            //list.Append(70);
            //list.Insert(30,56);
            //list.Display();
            //// list.DeleteNodeAtFirst();
            //// list.PopLast();
            ////Console.WriteLine("Search For Node value 30");
            ////list.Display();
            ////if (list.Search(30))
            ////{
            ////    Console.WriteLine("\nNode with value 30 is available in Linked list");
            ////}
            ////list.Display();
            //list.InsertNode(40, 30);
            //list.Display();
        }
    }
}

