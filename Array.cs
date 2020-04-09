namespace the_ultimate_data_structures_and_algorithms
{
    public class Array
    {
        private int[] items;
        private int count;

        public Array(int length)
        {
            items = new int[length];
        }

        public void insert(int item)
        {
            // If the array is full, resize it
            if (items.Length == count)
            {
                // Create a new array (twice the size)
                int[] newItems = new int[count * 2];

                // Copy all the existing items
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }

                // Set "items" to this new array
                items = newItems;
            }

            // Add the new item at the end
            items[count++] = item;
        }

        public void print()
        {
            for (int i = 0; i < count; i++)
            {
                System.Console.WriteLine(items[i]);
            }
        }
    }
}