using System;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };

            // O(n + n^3) => O(n^3)
            foreach (int number in numbers) // O(n)
            {
                Console.WriteLine(number);
            }

            foreach (int number in numbers) // O(n)
            {
                foreach (int number2 in numbers) // O(n)
                {
                    foreach (int number3 in numbers) // O(n)
                    {
                        Console.WriteLine($"{number}, {number2}, {number3}");
                    }
                }
            }
        }
    }
}