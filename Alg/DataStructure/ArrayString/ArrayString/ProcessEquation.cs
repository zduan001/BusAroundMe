using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class ProcessEquation
    {
        /*
         * process a string of equestion "1*25 + 24/2/4" = 25+ 3 = 28
         */
        public int Calculator(string input)
        {
            Stack<char> operators = new Stack<char>();
            Stack<string> operands = new Stack<string>();

            while (input != string.Empty)
            {
                if (input[0] == '+' ||
                    input[0] == '-' ||
                    input[0] == '*' ||
                    input[0] == '/')
                {
                    // check operator stack to see if we should pop the operator and operate on it.
                    operators.Push(input[0]);
                    input = input.Substring(1);
                }
                else
                {
                    int i = 0;
                    while (i < input.Length && (input[i] <= '9' && input[i] >= '0'))
                    {
                        i++;
                    }
                    string op = input.Substring(0, i);
                    operands.Push(op);
                    input = input.Substring(i);

                    if (operators.Count > 0 && (operators.Peek() == '*' || operators.Peek() == '/'))
                    {
                        string op2 = operands.Pop();
                        string op1 = operands.Pop();
                        int res = compute(op1, op2, operators.Pop());
                        operands.Push(res.ToString());
                    }
                }
            }

            Stack<char> operator2 = new Stack<char>();
            Stack<string> oprand2 = new Stack<string>();
            while (operators.Count != 0)
            {
                operator2.Push(operators.Pop());
            }

            while (operands.Count != 0)
            {
                oprand2.Push(operands.Pop());
            }

            while (operator2.Count != 0)
            {
                string op1 = oprand2.Pop();
                string op2 = oprand2.Pop();
                int res = compute(op1, op2, operator2.Pop());
                oprand2.Push(res.ToString());
            }

            return int.Parse(oprand2.Pop());
        }

        private int compute(string op1, string op2, char op)
        {
            int res = 0;
            int num1 = int.Parse(op1);
            int num2 = int.Parse(op2);
            switch (op)
            {
                case '*':
                    res = num1 * num2;
                    break;
                case '/':
                    res = num1 / num2;
                    break;
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
            }

            return res;
        }
    }
}
