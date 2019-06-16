using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Nicholas Zarek
 * Module 6 Programming Project
 * Part B
 * 
 * This program demonstrates Linked List implementation.
 *
 */
namespace LinkedList
{

    class Program
    {
        class ListNode
        {
            public object Data { get; private set; }
            public ListNode Next { get; private set; }

            public ListNode(object dataValue) : this(dataValue, null) { }

            public ListNode(object dataValue, ListNode nextNode)
            {
                Data = dataValue;
                Next = nextNode;
            }
        }

        public class List
        {
            private ListNode firstNode;
            private ListNode lastNode;
            private string name;

            public List(string listName)
            {
                name = listName;
                firstNode = lastNode = null;
            }

            public List() : this("list") { }

            public void insertFront(object insertItem)
            {
                if (IsEmpty())
                {
                    firstNode = lastNode = new ListNode(insertItem);
                }
                else
                {
                    firstNode = new ListNode(insertItem, firstNode);
                }
            }

            
            public bool IsEmpty()
            {
                return firstNode == null;
            }

            public void sortList()
            {
                /*ListNode current == head;
                 * current == min;
                 * minPrev == min;
                 *  for loop
                 *  while loop
                */
            }


            public void sumList()
            {
                
            }

            public void avgList()
            {

            }
          
            public void Display()
            {
                if (IsEmpty())
                {
                    Console.WriteLine($"The {name}");
                }
                else
                {
                    Console.Write($"The {name} is: ");
                    ListNode current = firstNode;
                    
                    while (current != null)
                    {
                        Console.Write($"{current.Data} ");
                            current = current.Next;
                    }

                    Console.WriteLine("\n");

                }
            }
        }

        static void Main(string[] args)
        {

            Random ranNumber = new Random();
            var list = new List();
            int intTemp = 999;

            list.insertFront(ranNumber.Next(1, 101));
            list.insertFront(ranNumber.Next(1, 101));
            list.insertFront(ranNumber.Next(1, 101));
            list.insertFront(ranNumber.Next(1, 101));
            list.insertFront(ranNumber.Next(1, 101));
            list.insertFront(ranNumber.Next(1, 101));
            list.insertFront(ranNumber.Next(1, 101));
            list.insertFront(ranNumber.Next(1, 101));
            list.insertFront(ranNumber.Next(1, 101));
            list.insertFront(ranNumber.Next(1, 101));
            list.sortList();
            list.Display();

            
            while (intTemp != 0)
            {
                while (intTemp != 0)
                {
                    Console.WriteLine("Enter a value or press 0 to Quit: ");
                    intTemp = Convert.ToInt32(Console.ReadLine());
                    if (intTemp == 0)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        list.insertFront(intTemp);
                        list.sortList();
                        list.sumList();
                        list.avgList();
                        list.Display();
                        
                        break;
                    }
                }                
            }
            
            Console.ReadKey();
        }

    }
}
