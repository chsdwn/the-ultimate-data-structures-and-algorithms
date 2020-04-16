using System;
using the_ultimate_data_structures_and_algorithms.Stack;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new MyStack();
            stack.push(10);
            stack.push(20);
            stack.push(30);
            stack.pop();
            var peek = stack.peek();
            System.Console.WriteLine(peek);
            System.Console.WriteLine(stack.ToString());
        }
    }
}