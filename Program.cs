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
            var array = list.toArray();
            System.Console.WriteLine(String.Join(", ", array));
            list.reverse();
            var arrayReversed = list.toArray();
            System.Console.WriteLine(String.Join(", ", arrayReversed));
        }
    }
}