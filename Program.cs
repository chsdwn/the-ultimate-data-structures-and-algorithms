using System;
using System.Collections.Generic;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddFirst(5);
            System.Console.WriteLine(list.Contains(10));
            System.Console.WriteLine(list.Count);
            System.Console.WriteLine(String.Join(", ", list));
        }
    }
}