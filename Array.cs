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

        public void print()
        {
            for (int i = 0; i < count; i++)
            {
                System.Console.WriteLine(items[i]);
            }
        }
    }
}