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
            list.removeLast();
            System.Console.WriteLine(list.indexOf(10));
            System.Console.WriteLine(list.indexOf(30));
            System.Console.WriteLine(list.indexOf(0));
            System.Console.WriteLine(list.contains(10));
            System.Console.WriteLine(list.contains(0));
        }
    }
}