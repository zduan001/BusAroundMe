using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter20_hard
{
    public class _20_01_AddWithoutplus
    {
        /*
         * Write a function that adds two numbers. You should not use + or any arithmetic operators.
         */
        /// <summary>
        /// selling point:
        /// 1. digit = (n1^ n2^carry) //if there are two 1's among n1, n2, carry, the res digit is 0
        /// 2. carry = (n1&n2) | (n1&carry) |(n2&carry) //as long as there is 2 number in n1, n2, carry then the carray is 1. 
        /// 3. new new digit has to been shift left i before add to result.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public int Add(int number1, int number2)
        {
            int res = 0;
            //assume this is a 32 bit number.
            int resultdigit = 0;
            int carry = 0;
            for (int i = 0; i < 32; i++)
            {
                int n1 = number1 & 1;
                int n2 = number2 & 1;
                resultdigit = n1 ^ n2 ^ carry;
                carry = (n1 & n2) | (n1 & carry) | (n2 & carry);
                
                res += resultdigit<<i;
                number1 = number1 >> 1;
                number2 = number2 >> 1;

            }
            if (carry == 1) throw new OverflowException();
            return res;
        }
    }
}