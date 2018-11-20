using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using DoublyLinkedListImplementation.LinkedListClasses;

namespace DoublyLinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new list
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            //Add elements to the list
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(3);
            list.Add(5);
            //iterate and print the list
            Console.WriteLine("List after adding the elements:");
            list.iterate();
            //remove an element from the list
            bool output = list.Remove(3);
            //iterate and print the list
            Console.WriteLine("List after removing the elements:");
            list.iterate();
           
            Console.ReadLine();
        }
    }
}
