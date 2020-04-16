using System;
using System.Collections.Generic;

namespace the_ultimate_data_structures_and_algorithms.Stack
{
    public class StringReverser
    {
        public string reverse(string input)
        {
            if (input == null) throw new NullReferenceException();

            var stack = new Stack<char>();

            // for (int i = 0; i < input.Length; i++)
            //     stack.Push(input[i]);

            foreach (var ch in input)
                stack.Push(ch);

            var reversed = "";
            while (stack.Count != 0)
                reversed += stack.Pop();

            return reversed;
        }
    }
}