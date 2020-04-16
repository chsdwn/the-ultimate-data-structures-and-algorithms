using System;
using the_ultimate_data_structures_and_algorithms.Stack;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "{(12^2 * [(|-1| / 2) % 2])}";
            var bs = new BalancedExpressions();
            System.Console.WriteLine(bs.isBalanced(str));
        }
    }
}