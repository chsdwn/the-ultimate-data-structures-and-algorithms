using System;

namespace the_ultimate_data_structures_and_algorithms.Queue
{
    public class MyQueue
    {
        private int[] items;
        private int rear;
        private int front;
        private int count;

        public MyQueue(int capacity)
        {
            items = new int[capacity];
        }

        public void enqueue(int item)
        {
            if (count == items.Length) throw new Exception();

            items[rear++] = item;
            count++;
        }

        public int dequeue()
        {
            var item = items[front];
            items[front++] = 0;
            count--;

            return item;
        }

        public override string ToString()
        {
            return String.Join(", ", items);
        }
    }
}