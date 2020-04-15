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
            System.Console.WriteLine(String.Join(", ", list.toArray()));
            System.Console.WriteLine(list.getKthFromTheEnd(1));
            System.Console.WriteLine(list.getKthFromTheEnd(2));
            System.Console.WriteLine(list.getKthFromTheEnd(7));
        }
    }
}