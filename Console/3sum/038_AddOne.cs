using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _038_AddOne
    {
        /// <summary>
        /// Given a number represented as an array of digits, plus one to the number.
        /// Not hard at all just make sure carry the carry.
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public List<int> AddOne(List<int> digits)
        {
            int carry = 0;
            for (int i = digits.Count - 1; i >= 0; i--)
            {
                int tmp = digits[i];
                if (i == digits.Count - 1) tmp++;
                tmp += carry;
                if (tmp >= 10)
                {
                    digits[i] = tmp - 10;
                    carry = 1;
                }
                else
                {
                    digits[i] = tmp;
                    carry = 0;
                    break;
                }
            }
            if (carry > 0)
                digits.Insert(0, carry);

            return digits;
        }
    }
}
