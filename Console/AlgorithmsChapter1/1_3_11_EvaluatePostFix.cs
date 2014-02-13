using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_3_11_EvaluatePostFix
    {
        /*
         * Write a program EvaluatePostfix that takes a postfix expression from standard input, evaluates it, 
         * and prints the value. (Piping the output of your program from the previous exercise to this program 
         * gives equivalent behavior to Evaluate .)
         */
        public int EvaluatePostFix(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return 0;
            Stack<int> stack = new Stack<int>();
            char[] x = input.ToCharArray();
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] >= '0' && x[i] <= '9')
                {
                    stack.Push(x[i] - '0');
                }
                else
                {
                    int right = stack.Pop();
                    int left = stack.Pop();
                    switch (x[i])
                    {
                        case '*':
                            stack.Push(left * right);
                            break;
                        case '+':
                            stack.Push(left + right);
                            break;
                        case '/':
                            stack.Push(left / right);
                            break;
                        case '-':
                            stack.Push(left - right);
                            break;
                    }
                }
            }
            return stack.Pop();
        }
    }
}
