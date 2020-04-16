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
            reverse(queue);
            System.Console.WriteLine(String.Join(", ", queue.ToArray()));
        }

        public static void reverse(Queue<int> queue)
        {
            var stack = new Stack<int>();

            while (queue.Count != 0)
                stack.Push(queue.Dequeue());

            while (stack.Count != 0)
                queue.Enqueue(stack.Pop());
        }
    }
}