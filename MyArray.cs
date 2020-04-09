using System;

namespace the_ultimate_data_structures_and_algorithms
{
    public class MyArray
    {
        private int _length;
        private int[] array;
        private int emptyValues;

        public MyArray(int length)
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

        public void print()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);

            }
        }
    }
}