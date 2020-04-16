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
                if (isLeftBracket(ch))
                    stack.Push(ch);

                if (isRightBracket(ch))
                {
                    if (stack.Count == 0) return false;

                    var top = stack.Pop();
                    if (bracketsMatch(top, ch)) return false;
                }
            }

            return stack.Count == 0 ? true : false;
        }

        private bool isLeftBracket(char ch)
        {
            return ch.Equals('(') || ch.Equals('<') || ch.Equals('[') || ch.Equals('{');
        }

        private bool isRightBracket(char ch)
        {
            return ch.Equals(')') || ch.Equals('>') || ch.Equals(']') || ch.Equals('}');
        }

        private bool bracketsMatch(char left, char right)
        {
            return (right.Equals(')') && left != '(') ||
                    (right.Equals('>') && left != '<') ||
                    (right.Equals(']') && left != '[') ||
                    (right.Equals('}') && left != '{');
        }
    }
}