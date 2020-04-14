using System;
using the_ultimate_data_structures_and_algorithms.LinkedList;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyLinkedList();
            System.Console.WriteLine(list.size());
            list.addLast(10);
            System.Console.WriteLine(list.size());
            list.addLast(20);
            list.addLast(30);
            System.Console.WriteLine(list.size());
            list.removeLast();
            list.removeLast();
            list.removeFirst();
            System.Console.WriteLine(list.size());
        }
    }
}