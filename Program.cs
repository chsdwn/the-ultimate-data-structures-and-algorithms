using System;
using System.Collections.Generic;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "abcd";
            var stack = new Stack<string>();
            foreach (var item in str)
            {
                stack.Push(item.ToString());
            }

            var reversedStr = "";
            foreach (var item in stack.ToArray())
            {
                reversedStr = reversedStr + item;
            }

            System.Console.WriteLine(reversedStr);
        }
    }
}