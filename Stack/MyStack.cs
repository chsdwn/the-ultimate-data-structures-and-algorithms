using System;

namespace the_ultimate_data_structures_and_algorithms.Stack
{
    public class MyStack
    {
        private int[] array = new int[0];
        private int size = 0;

        // push
        public void push(int item)
        {
            if (size == 0)
            {
                array = new int[] { item };
                size++;
                return;
            }

            var updatedArray = new int[++size];
            updatedArray[0] = item;
            for (int i = 1; i < size; i++)
                updatedArray[i] = array[i - 1];

            array = updatedArray;
        }

        // pop
        public int pop()
        {
            var updatedArray = new int[--size];

            System.Console.WriteLine(size);
            if (size > 0)
            {
                for (int i = 0; i < size; i++)
                    updatedArray[i] = array[i + 1];

            }
            var popedItem = array[0];
            array = updatedArray;

            return popedItem;
        }

        // peek
        public int peek()
        {
            if (size == 0) throw new Exception();
            return array[0];
        }

        // isEmpty
        public bool isEmpty()
        {
            return size <= 0;
        }

        public void print()
        {
            System.Console.WriteLine(String.Join(", ", array));
        }
    }
}