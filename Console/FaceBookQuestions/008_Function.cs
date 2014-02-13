using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookQuestions
{
    public class _008_Function
    {
        /*
         * Write the following function

            double&nbsp; solveForX(string s) {&nbsp;&nbsp; }

            input will be linear equation in x with +1 or -1 coefficient.

            output will be value of x.

            s can be as follows

            i/p&nbsp;&nbsp; x + 9 – 2 -4 + x = – x + 5 – 1 + 3 – x&nbsp;&nbsp; o/p&nbsp; 1.00

            i/p&nbsp;&nbsp;&nbsp; x + 9 -1 = 0&nbsp; o/p -8.00

            i/p&nbsp;&nbsp;&nbsp; x + 4 = – 3 – x&nbsp; o/p&nbsp; -3.500

            it has second part

            if the i/p string can have ‘(‘ or&nbsp; ‘)’

            x + 9 – 2 -(4 + x) = – (x + 5 – 1 + 3) – x

            x + 9 + (3 + – x – ( -x + (3 – (9 – x) +x = 9 -(5 +x )
         */

        public double solveForX(string s)
        {
            // check null empty string.
            int index = s.IndexOf("=");
            string left = s.Substring(0, index);
            string right = s.Substring(index + 1);

            KeyValuePair<int, int> leftpair = parseString(left);
            KeyValuePair<int, int> rightpair = parseString(right);

            double res = (rightpair.Value - leftpair.Value) / (leftpair.Key - rightpair.Key);
            return res;
        }

        private KeyValuePair<int, int> parseString(string s)
        {
            Stack<char> operators = new Stack<char>();
            Stack<int> operand = new Stack<int>();

            int parentheseCount = 0;
            int i = 0;
            int countOfX = 0;
            while (i < s.Length)
            {
                if (s[i] == 'x')
                {
                    if (operators.Count == 0)
                    {
                        countOfX++;
                    }
                    else
                    {
                        char a = operators.Pop();
                        if (a == '+')
                        {
                            countOfX++;
                        }
                        else if (a == '-')
                        {
                            countOfX--;
                        }
                        else
                        {
                            // throw exception
                        }
                    }
                }
                else if (s[i] >= '0' && s[i] <= '9')
                {
                    if (operators.Count != 0)
                    {
                        int k = s[i] - '0';
                        int l = 0;

                        if (operand.Count != 0)
                        {
                            l = operand.Pop();
                        }

                        char op = operators.Pop();
                        if (op == '-')
                        {
                            operand.Push(l - k);

                        }
                        else
                        {
                            operand.Push(l + k);
                        }
                    }
                    else
                    {
                        operand.Push(s[i] - '0');
                    }
                }
                else if (s[i] == '+' || s[i] == '-')
                {
                    operators.Push(s[i]);
                }

                i++;
            }

            // assert operand.count != 0;
            KeyValuePair<int, int> res = new KeyValuePair<int, int>(countOfX, operand.Pop());

            return res;
        }
    }
}
