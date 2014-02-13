using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_076_To_100
{
    public class _087_ValidParentheses
    {
        /*
         * Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
           The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
         */
        public bool IsValidParentheses(string str)
        {
            Stack<char> s = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '[' || str[i] == '{')
                {
                    s.Push(str[i]);
                }
                else
                {
                    switch (str[i])
                    {
                        case '}':
                            if (s.Pop() != '{') return false;
                            break;
                        case ')':
                            if (s.Pop() != '(') return false;
                            break;
                        case ']':
                            if (s.Pop() != '[') return false;
                            break;
                        default:
                            return false;
                    }
                }
            }
            return true;
        }
    }
}
