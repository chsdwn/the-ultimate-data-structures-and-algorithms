using System;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ali", "Veli", "Ahmet" };

            // O(n) space - How much extra space need to run
            string[] copy = new string[names.Length];
            foreach (string name in names)
            {
                Console.WriteLine($"Ne yaptın {name}");
            }
        }
    }
}