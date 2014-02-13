using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _033_LongestValidParenthesis
    {
        /// <summary>
        /// Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.
        /// For "(()", the longest valid parentheses substring is "()", which has length = 2.
        /// Another example is ")()())", where the longest valid parentheses substring is "()()", which has length = 4.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int LongestValidParenthesis(string input)
        {
            // first thought come in to my mind is DP, but how to create a sub case?
            Stack<int> s = new Stack<int>();
            int maxLength = 0;
            int start = input.Length;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(') s.Push(i);
                if (input[i] == ')')
                {
                    if (!(s.Count == 0))
                    {
                        int tmp = s.Pop();
                        start = start > tmp ? tmp : start;
                        maxLength = (i - start) > maxLength ? (i - start) : maxLength;
                    }
                    else
                    {
                        start = input.Length;
                    }
                }
            }
            return maxLength +1;
        }
    }
}
