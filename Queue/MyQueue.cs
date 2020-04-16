using System;

namespace the_ultimate_data_structures_and_algorithms.Queue
{
    public class MyQueue
    {
        private int[] items = new int[5];
        private int count = 0;
        private int frontIndex = 0;
        private int rearIndex = 0;

        // enqueue
        public void enqueue(int item)
        {
            if (count == 0)
                items[0] = item;
            else
            {
                items[++rearIndex] = item;
            }

            count++;
        }

        // dequeue
        public int dequeue()
        {
            count--;
            return items[frontIndex++];
        }

        // peek
        public int peek()
        {
            return items[frontIndex];
        }

        // isEmpty
        public bool isEmpty()
        {
            return count == 0;
        }

        // isFull
        public bool isFull()
        {
            return items.Length - 1 == rearIndex;
        }

        public override string ToString()
        {
            return String.Join(", ", items);
        }
    }
}