using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructureProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine("*********Program End**********\n");

            //UC2
            LinkedList list2 = new LinkedList();
            list2.Add(70);
            int a = list2.Search(70);
            Console.WriteLine("index position of 70 is : " + a);
            list2.InsertAtParticularPosition(a + 1, 30);
            list2.InsertAtParticularPosition(a + 1, 56);
            list2.Display();
            Console.WriteLine("*********Program End**********\n");

            //UC3
            LinkedList list3 = new LinkedList();
            list3.Add(56);
            list3.InsertAfter(30, 56);
            list3.InsertAfter(70, 30);
            Console.WriteLine("List after appending 30 and 70");
            list3.Display();
            Console.WriteLine("*********Program End**********\n");

            //UC4
            LinkedList list4 = new LinkedList();
            list4.Add(56);
            list4.Add(70);
            int a2 = list4.Search(70);
            Console.WriteLine("index position of 70 is : " + a2);
            list4.InsertAtParticularPosition(a2 + 1, 30);
            list4.Display();
            Console.WriteLine("*********Program End**********\n");

            //UC5
            LinkedList list5 = new LinkedList();
            list5.Add(56);
            list5.Add(30);
            list5.Add(70);
            list5.Display();
            list5.RemoveFirstNode();
            Console.WriteLine("After removing first element");
            list5.Display();
            Console.WriteLine("*********Program End**********\n");

            //UC6
            LinkedList list6 = new LinkedList();
            list6.Add(56);
            list6.Add(30);
            list6.Add(70);
            list6.Display();
            list6.RemoveLastNode();
            Console.WriteLine("After removing last element");
            list6.Display();
            Console.WriteLine("*********Program End**********\n");

            //UC7
            LinkedList list7 = new LinkedList();
            list7.Add(56);
            list7.Add(30);
            list7.Add(70);
            int a3 = list7.Search(30);
            Console.WriteLine("index position of 30 is : " + a3);
            list7.Display();
            Console.WriteLine("*********Program End**********\n");

            //UC8
            LinkedList list8 = new LinkedList();
            list8.Add(56);
            list8.Add(30);
            list8.Add(70);
            list8.Display();
            int a4 = list8.Search(30);
            Console.WriteLine("index position of 30 is : " + a4);
            list8.InsertAfter(40, 30);
            Console.WriteLine("list after update");
            list8.Display();
            Console.WriteLine("*********Program End**********\n");

            //UC9
            LinkedList list9 = new LinkedList();
            list9.Add(56);
            list9.Add(30);
            list9.Add(40);
            list9.Add(70);
            list9.Display();
            list9.DeleteAny(40);            
            Console.WriteLine("List after deletion of 40");
            list9.Display();
            Console.WriteLine("Size of Linked List is: " + list9.size());
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
