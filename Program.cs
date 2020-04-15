using System;
using the_ultimate_data_structures_and_algorithms.LinkedList;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyLinkedList();
            list.addLast(10);
            list.addLast(20);
            list.addLast(30);
            list.addLast(40);
            list.addLast(50);
            System.Console.WriteLine(list.hasLoop());
        }
    }
}