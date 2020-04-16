using System;
using the_ultimate_data_structures_and_algorithms.Stack;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;

            StringReverser reverser = new StringReverser();
            var result = reverser.reverse(str);
            System.Console.WriteLine(result);
        }
    }
}