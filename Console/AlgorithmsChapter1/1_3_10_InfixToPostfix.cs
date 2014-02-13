using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_3_10_InfixToPostfix
    {
        /*
         * Write a filter InfixToPostfix that converts an arithmetic expression from infix to postfix.
         */
        public string InfixToPostFix(string input)
        {
            char[] x = input.ToCharArray();
            Stack<char> stack = new Stack<char>();
            StringBuilder postFix = new StringBuilder();
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] >= '0' && x[i] <= '9')
                {
                    postFix.Append(x[i]);
                }
                else if (x[i] == '*' || x[i] == '/' || x[i] == '+' || x[i] == '-')
                {
                    if (stack.Count == 0)
                    {
                        stack.Push(x[i]);
                    }
                    else
                    {
                        if (x[i] == '*' || x[i] == '/')
                        {
                            if (stack.Peek() == '+' || stack.Peek() == '-')
                            {
                                stack.Push(x[i]);
                            }
                            else
                            {
                                while (stack.Count != 0 && !(stack.Peek() == '+' || stack.Peek() == '-'))
                                {
                                    postFix.Append(stack.Pop());
                                }
                                stack.Push(x[i]);
                            }
                        }
                        else
                        {
                            while (stack.Count != 0)
                            {
                                postFix.Append(stack.Pop());
                            }
                            stack.Push(x[i]);
                        }
                    }
                }
            }
            while (stack.Count != 0)
            {
                postFix.Append(stack.Pop());
            }
            return postFix.ToString();
        }
    }
}
