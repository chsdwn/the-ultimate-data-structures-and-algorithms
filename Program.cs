using System;
using System.Collections.Generic;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            System.Console.WriteLine(String.Join(", ", stack.ToArray()));
            var top = stack.Pop();
            System.Console.WriteLine(top.ToString());
            System.Console.WriteLine(String.Join(", ", stack.ToArray()));
            top = stack.Peek();
            System.Console.WriteLine(top.ToString());
        }
    }
}