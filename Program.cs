using System;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            string[] names = { "Ali", "Veli" };

            // O(n+2) => O(n)
            Console.WriteLine(""); // O(1)
            foreach (int number in numbers) // O(n)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(""); // O(1)

            // O(2n) => O(n)
            foreach (int number in numbers) // O(n)
            {
                Console.WriteLine(number);
            }
            foreach (int number in numbers) // O(n)
            {
                Console.WriteLine(number);
            }

            // O(n + m) => O(n)
            foreach (int number in numbers) // O(n)
            {
                Console.WriteLine(number);
            }
            foreach (string name in names) // O(m)
            {
                Console.WriteLine(name);
            }
        }
    }
}