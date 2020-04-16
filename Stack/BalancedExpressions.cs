using System;
using System.Collections.Generic;

namespace the_ultimate_data_structures_and_algorithms.Stack
{
    public class BalancedExpressions
    {
        public bool isBalanced(string input)
        {
            var stack = new Stack<char>();

            foreach (var ch in input)
            {
                if (ch.Equals('(')) stack.Push(ch);

                if (ch.Equals(')'))
                {
                    if (stack.Count == 0) return false;
                    stack.Pop();
                }
            }

            return stack.Count == 0 ? true : false;
        }
    }
}