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
                if (ch.Equals('(') || ch.Equals('<') || ch.Equals('[') || ch.Equals('{'))
                    stack.Push(ch);

                if (ch.Equals(')') || ch.Equals('>') || ch.Equals(']') || ch.Equals('}'))
                {
                    if (stack.Count == 0) return false;

                    var top = stack.Pop();
                    if (
                        (ch.Equals(')') && top != '(') ||
                        (ch.Equals('>') && top != '<') ||
                        (ch.Equals(']') && top != '[') ||
                        (ch.Equals('}') && top != '{')
                    ) return false;
                }
            }

            return stack.Count == 0 ? true : false;
        }
    }
}