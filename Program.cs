using System;
using System.Collections;
using System.Collections.Generic;
using the_ultimate_data_structures_and_algorithms.Stack;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            System.Console.WriteLine(String.Join(", ", queue.ToArray()));
            var front = queue.Dequeue();
            System.Console.WriteLine(front);
            System.Console.WriteLine(String.Join(", ", queue.ToArray()));
        }
    }
}