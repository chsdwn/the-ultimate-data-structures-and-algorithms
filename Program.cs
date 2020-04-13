using System;
using System.Collections.Generic;
using the_ultimate_data_structures_and_algorithms.LinkedList;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList list = new MyLinkedList();
            list.AddFirst(20);
            list.AddLast(50);
            list.AddFirst(40);
            list.AddLast(30);
            list.AddFirst(60);
            list.AddLast(10);
            list.AddFirst(80);
            list.DeleteFirst();
            list.DeleteLast();
            list.Print();
            System.Console.WriteLine(list.Contains(60));
            System.Console.WriteLine(list.Contains(10));
            System.Console.WriteLine(list.IndexOf(50));
            System.Console.WriteLine(list.IndexOf(10));
        }
    }
}