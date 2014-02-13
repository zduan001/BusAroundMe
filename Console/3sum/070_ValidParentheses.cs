using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _070_ValidParentheses
    {
        /// <summary>
        /// Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        /// The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool ValidParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if (stack.Count != 0)
                    {
                        char c = stack.Pop();
                        switch (c)
                        {
                            case '[':
                                if (s[i] != ']') return false;
                                break;
                            case '(':
                                if (s[i] != ')') return false;
                                break;
                            case '{':
                                if (s[i] != '}') return false;
                                break;
                            default:
                                return false;
                        }
                    }
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
