using System;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30 };
            Console.WriteLine(numbers.Length);
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}