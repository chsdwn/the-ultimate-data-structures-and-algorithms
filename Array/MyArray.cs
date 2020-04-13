using System;

namespace the_ultimate_data_structures_and_algorithms
{
    public class MyArray
    {
        private int _length;
        private int[] array;
        private int emptyValues;

        public MyArray(int length = 1)
        {
            _length = length;
            emptyValues = length;
            initialize();
        }

        private void initialize()
        {
            array = new int[_length];
            for (int i = 0; i < _length; i++)
            {
                array[i] = 0;
            }
        }

        public void insert(int item)
        {
            if (emptyValues > 0)
            {
                array[_length - emptyValues] = item;
                emptyValues--;
            }
            else if (emptyValues == 0)
            {
                var updatedArray = new int[_length + 1];

                for (int i = 0; i < _length; i++)
                {
                    updatedArray[i] = array[i];
                }
                updatedArray[_length] = item;
                array = updatedArray;
                _length++;
            }
        }

        public int indexOf(int item)
        {
            for (int i = 0; i < _length; i++)
            {
                if (array[i] == item)
                    return i;
            }
            return -1;
        }

        public int max()
        {
            int max = array[0];
            for (int i = 1; i < _length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

        public int intersect()
        {
            var counts = new int[_length];

            for (int i = 0; i < _length - 1; i++)
            {
                for (int j = i + 1; j < _length; j++)
                {
                    if (array[i] == array[j])
                        counts[i]++;
                }
            }

            int commonIndex = 0;
            for (int i = 0; i < _length - 1; i++)
            {
                if (counts[i] < counts[i + 1])
                    commonIndex = counts[i + 1];
            }

            return array[commonIndex];
        }

        public void insertAt(int item, int index)
        {
            if (index < 0 || index >= _length)
                throw new ArgumentException();

            _length++;
            var inserted = false;
            var insertedArray = new int[_length];
            for (int i = 0; i < _length; i++)
            {
                if (i == index && !inserted)
                {
                    insertedArray[i] = item;
                    inserted = true;
                }
                else if (inserted)
                    insertedArray[i] = array[i - 1];
                else
                    insertedArray[i] = array[i];
            }

            array = insertedArray;
        }

        public void removeAt(int index)
        {
            if (index < 0 || index >= _length)
                throw new ArgumentException();

            _length--;
            var removed = false;
            var removedArray = new int[_length];
            for (int i = 0; i < _length; i++)
            {
                if (i == index)
                    removed = true;
                if (!removed)
                    removedArray[i] = array[i];
                if (removed)
                    removedArray[i] = array[i + 1];
            }
            array = removedArray;
        }

        public void reverse()
        {
            var reversedArray = new int[_length];
            for (int i = 0; i < _length; i++)
            {
                reversedArray[i] = array[_length - 1 - i];
            }

            array = reversedArray;
        }

        public void print()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);

            }
        }
    }
}