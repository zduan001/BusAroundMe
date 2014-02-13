using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _046_AtoI
    {
        /// <summary>
        /// Implement atoi to convert a string to an integer.
        /// Hint: Carefully consider all possible input cases. If you want a challenge, please do not see below and ask yourself what are the possible input cases.
        /// Notes: It is intended for this problem to be specified vaguely (ie, no given input specs). You are responsible to gather all the input requirements up front.
        /// Assumption:
        /// 1. first letter can be - + or a number, other wise throw format exception.
        /// 2. do not need to worry about overflow.
        /// 3. no 10E2 format allowed.
        /// 4. all input trade as decimal integer.
        /// the only allowed format is "123", "+123", "-123"
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int AtoI(string input)
        {
            bool isNegative = false;
            if (input[0] == '-')
            {
                isNegative = true;
            }

            int res=0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 && (input[0] == '-' || input[0] == '+'))
                {
                    continue;
                }
                
                int tmp = input[i] - '0';
                if(tmp < 0 || tmp > 9) 
                    throw new FormatException();

                res = res * 10 + tmp;
            }
            

            return isNegative? -res:res;
        }
    }
}
