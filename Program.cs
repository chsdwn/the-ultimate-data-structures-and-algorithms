using System;
using System.Collections.Generic;
using the_ultimate_data_structures_and_algorithms.Queue;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new MyQueue(5);
            queue.enqueue(10);
            queue.enqueue(20);
            queue.enqueue(30);
            System.Console.WriteLine(queue.dequeue());
            queue.enqueue(40);
            queue.enqueue(50);
            queue.enqueue(60);
            System.Console.WriteLine(queue.dequeue());
            queue.enqueue(70);
            System.Console.WriteLine(queue);
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