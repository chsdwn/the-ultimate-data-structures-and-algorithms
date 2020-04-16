using System;

namespace the_ultimate_data_structures_and_algorithms.Stack
{
    public class StackExercises
    {
        private int[] items = new int[10];
        private int count1 = 0;
        private int count2 = 0;
        private int startIndex = 5;
        private int increment = 5;

        public void push1(int item)
        {
            if (count1 < startIndex)
                items[count1++] = item;
            else
            {
                var updatedArray = new int[items.Length + increment];
                startIndex += increment;
                for (int i = 0; i < count1; i++)
                    updatedArray[i] = items[i];

                for (int j = 0; j < count2; j++)
                    updatedArray[j + startIndex] = items[j + startIndex - increment];

                updatedArray[count1++] = item;
                items = updatedArray;
            }
        }

        public void push2(int item)
        {
            if (count2 != items.Length - startIndex)
                items[startIndex + count2++] = item;
            else
            {
                var updatedArray = new int[items.Length + increment];
                for (int i = 0; i < count2 + startIndex; i++)
                {
                    updatedArray[i] = items[i];
                }
                updatedArray[startIndex + count2++] = item;
                items = updatedArray;
            }
        }

        public int pop1()
        {
            return items[--count1];
        }

        public int pop2()
        {
            return items[startIndex + --count2];
        }

        public bool isEmpty1()
        {
            return count1 == 0;
        }

        public bool isEmpty2()
        {
            return count2 == 0;
        }

        public bool isFull1()
        {
            return count1 == startIndex;
        }

        public bool isFull2()
        {
            return count2 == items.Length - startIndex;
        }

        public int min1()
        {
            var min = items[0];
            for (int i = 1; i < count1; i++)
            {
                if (items[i] < min) min = items[i];
            }
            return min;
        }

        public override string ToString()
        {
            return String.Join(", ", items);
        }
    }
}