using System;
using System.Collections;
using System.Collections.Generic;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.RemoveAt(0);
            list.ToArray();
            System.Console.WriteLine(string.Join(", ", list));
        }
    }
}