using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class AddBinary
    {
        /// <summary>
        /// Given two binary strings, return their sum (also a binary string). 
        /// </summary>
        /// <param name="s1">first binary string</param>
        /// <param name="s2">second binary string</param>
        /// <returns>result as integer value</returns>
        public int AddBinaryString(string s1, string s2)
        {
            int a;
            int b;
            int result = 0;
            int carry = 0;

            int length = Math.Max(s1.Length, s2.Length);

            for (int i = 0; i < length; i++)
            {
                a = s1.Length > i && s1[s1.Length - i - 1] == '1' ? 1 : 0;
                b = s2.Length > i && s2[s2.Length - i - 1] == '1' ? 1 : 0;
                result = result | (((a ^ b) ^ carry) << i);
                carry = (a & b) | (a & carry) | (b & carry);
            }

            result |= carry << length;

            return result;
        }
    }
}
