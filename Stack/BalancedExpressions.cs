using System;
using System.Collections.Generic;

namespace the_ultimate_data_structures_and_algorithms.Stack
{
    public class BalancedExpressions
    {
        public bool isBalanced(string str)
        {
            if (str == null || str.Length == 0) throw new NullReferenceException();

            var opens = "{[(<";
            var closes = "}])>";

            var stack = new Stack<char>();

            foreach (var ch in str)
            {
                for (int i = 0; i < opens.Length; i++)
                {
                    if (ch == closes[i])
                    {
                        if (stack.Count == 0) return false;

                        var item = stack.Pop();
                        if (item != opens[i]) return false;
                    }

                    else if (ch == opens[i])
                        stack.Push(opens[i]);
                }
            }

            return true;
        }
    }
}