using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_3_4_ValideParentheses
    {
        /*
         * Write a stack client Parentheses that reads in a text stream from standard 
         * input and uses a stack to determine whether its parentheses are properly 
         * balanced. For example, your program should print true for [()]{}{[()()]()} and false for [(]) 
         */
        /// <summary>
        /// Assume in s there are only {,(,[, and },),] if there is any other charactor throw exception
        /// ignore them is fine too. 
        /// this is a classic stack question.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool ValideParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{' || s[i] == '(' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else if (s[i] == '}' || s[i] == ')' || s[i] == ']')
                {
                    char c = stack.Pop();
                    if (c == '{' && s[i] != '}')
                    {
                        return false;
                    }
                    if (c == '(' && s[i] != ')')
                    {
                        return false;
                    }
                    if (c == '[' && s[i] != ']')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
