using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_026_To_050
{
    public class _030_LongestValideParentheses
    {
        /*
        Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.
        For "(()", the longest valid parentheses substring is "()", which has length = 2.
        Another example is ")()())", where the longest valid parentheses substring is "()()", which has length = 4.
        */
        /// <summary>
        /// O(n^2)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FindLongestValideParentheses(string s)
        {
            Stack<char> left = new Stack<char>();
            Stack<char> right = new Stack<char>();
            int maxLength = int.MinValue;
            for (int i = 0; i < s.Length; i++)
            {
                left.Clear();
                right.Clear();
                int k = i;
                while (k < s.Length)
                {
                    if (s[k] == '(')
                    {
                        left.Push(s[k]);
                    }
                    if (s[k] == ')')
                    {
                        if (right.Count < left.Count)
                        {
                            right.Push(s[k]);
                        }
                        else
                        {
                            maxLength = maxLength > right.Count * 2 ? maxLength : right.Count * 2;
                            break;
                        }
                    }
                    if (k == s.Length - 1)
                    {
                        maxLength = maxLength > right.Count * 2 ? maxLength : right.Count * 2;
                    }

                    k++;
                }
            }
            return maxLength;
        }
    }
}
