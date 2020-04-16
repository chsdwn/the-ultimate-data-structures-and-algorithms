using System;

namespace the_ultimate_data_structures_and_algorithms.Stack
{
    public class MyStack
    {
        private int[] items = new int[5];
        private int count;

        public void push(int item)
        {
            if (count == items.Length)
                throw new StackOverflowException();
            items[count++] = item;
        }

        public int pop()
        {
            if (count == 0) throw new Exception();
            return items[--count];
        }

        public int peek()
        {
            if (count == 0) throw new Exception();
            return items[count - 1];
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public override string ToString()
        {
            var result = "";
            for (int i = 0; i < count; i++)
            {
                result += items[i];
                if (i != count - 1) result += ", ";
            }
            return result;
        }
    }
}