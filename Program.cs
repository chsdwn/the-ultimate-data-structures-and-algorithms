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
            reverse(queue);
        }

        public static void reverse(Queue<int> queue)
        {
            var reversedQueue = new Queue<int>();
            var queueCount = queue.Count;
            var count = queue.Count;
            var step = 1;
            var swap = new Queue<int>();

            for (; ; )
            {
                if (queueCount == reversedQueue.Count) break;

                if (step == count)
                {
                    reversedQueue.Enqueue(queue.Dequeue());
                    queue = swap;
                    count--;
                    step = 1;
                }
                else
                {
                    step++;
                    swap.Enqueue(queue.Dequeue());
                }
            }

            System.Console.WriteLine(
                "reversed: " + String.Join(", ", reversedQueue.ToArray())
            );
        }
    }
}