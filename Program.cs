using System;
using System.Collections.Generic;

namespace LinkedListDataStructureProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC1
            SimpleLinkedList list = new SimpleLinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine("*********Program End**********\n");

            //UC2
            SimpleLinkedList list2 = new SimpleLinkedList();
            list2.Add(70);
            int a = list2.Search(70);
            Console.WriteLine("Index position of 70 is : " + a);
            list2.InsertAtParticularPosition(a+1, 30);
            list2.InsertAtParticularPosition(a+2, 56);
            list2.Display();
            Console.WriteLine("*********Program End**********\n");

            //UC3
            SimpleLinkedList list3 = new SimpleLinkedList();
            list3.Add(56);
            list3.Add(30);
            list3.Add(70);
            list3.Display();
            Console.WriteLine("*********Program End**********\n");

            //UC4
            SimpleLinkedList list4 = new SimpleLinkedList();
            list4.Add(56);
            list4.Add(70);
            int a1 = list4.Search(70);
            Console.WriteLine("Index position of 56 is : " + a1);
            list4.InsertAtParticularPosition(a1+1, 30);
            list4.Display();
            Console.WriteLine("*********Program End**********\n");

            //UC5
            SimpleLinkedList list5 = new SimpleLinkedList();
            list5.Add(56);
            list5.Add(30);
            list5.Add(70);
            list5.Display();
            list5.RemoveFirstNode();
            Console.WriteLine("After Deletion of first element: ");
            list5.Display();
            Console.WriteLine("*********Program End**********\n");

            //UC6
            SimpleLinkedList list6 = new SimpleLinkedList();
            list6.Add(56);
            list6.Add(30);
            list6.Add(70);
            list6.Display();
            list6.RemoveLastNode();
            Console.WriteLine("After Deletion of last element: ");
            list6.Display();
            Console.WriteLine("*********Program End**********\n");

            //UC7
            int a2 = list6.Search(30);
            Console.WriteLine("index position of 30 is : " + a2);
            Console.WriteLine("*********Program End**********\n");

            //UC8
            SimpleLinkedList list8 = new SimpleLinkedList();
            list8.Add(56);
            list8.Add(30);
            list8.Add(70);
            list8.Display();
            int a3 = list8.Search(30);            
            Console.WriteLine("index position of 30 is : " + a3);
            list8.InsertAtParticularPosition(a3+1 , 40);
            list8.Display();
            Console.WriteLine("*********Program End**********\n");

            //UC9
            // Creating a list of integers
            List<int> list9 = new List<int>();

            // Adding items to the list
            list9.Add(56);
            list9.Add(30);
            list9.Add(40);
            list9.Add(70);

            System.Console.WriteLine("Original List:");
            // Printing the list
            list9.ForEach(System.Console.WriteLine);

            // Calling RemoveAt() method
            int a4 = list9.IndexOf(40);           
            Console.WriteLine("Index of 40 is : " + a4);
            list9.Remove(40);
            System.Console.WriteLine("After removing 40:");
            // Printing the list
            list9.ForEach(System.Console.WriteLine);
            Console.WriteLine("*********Program End**********\n");

            //UC10
            SortList<int> sList = new SortList<int>();

            //Adds data to the list  
            sList.addNode(56);
            sList.addNode(30);
            sList.addNode(40);
            sList.addNode(70);
 

            //Displaying original list  
            Console.WriteLine("Original list: ");
            sList.display();

            //Sorting list  
            sList.sortList();

            //Displaying sorted list  
            Console.WriteLine("Sorted list: ");
            sList.display();

            Console.WriteLine("*********Program End**********\n");
        }
    }
}
