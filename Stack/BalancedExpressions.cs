using System;
using System.Collections;
using System.Collections.Generic;

namespace the_ultimate_data_structures_and_algorithms.Stack
{
    public class BalancedExpressions
    {
        private readonly static string leftBrackets = "(<[{";
        private readonly static string rightBrackets = ")>]}";

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
                    if (!bracketsMatch(top, ch)) return false;
                }
            }

            return stack.Count == 0 ? true : false;
        }

        private bool isLeftBracket(char ch)
        {
            return leftBrackets.Contains(ch);
        }

        private bool isRightBracket(char ch)
        {
            return rightBrackets.Contains(ch);
        }

        private bool bracketsMatch(char left, char right)
        {
            return leftBrackets.IndexOf(left) == rightBrackets.IndexOf(right);
        }
    }
}