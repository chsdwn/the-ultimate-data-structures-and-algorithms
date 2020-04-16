using System;
using the_ultimate_data_structures_and_algorithms.Stack;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new StackExercises();
            stack.push1(6);
            stack.push1(2);
            stack.push1(3);
            stack.push1(4);
            stack.push1(5);

            stack.push2(10);
            stack.push2(20);
            stack.push2(30);
            stack.push2(40);
            stack.push2(50);
            stack.push2(60);
            stack.push1(1);

            stack.pop1();
            System.Console.WriteLine(stack.min1());
            stack.push1(7);

            System.Console.WriteLine(stack.ToString());
        }
    }
}