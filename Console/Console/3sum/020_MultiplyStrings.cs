using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _020_MultiplyStrings
    {
        /// <summary>
        /// Given two numbers represented as strings, return multiplication of the numbers as a string.
        /// Note: The numbers can be arbitrarily large and are non-negative.
        /// </summary>
        /// <param name="s1">1st string</param>
        /// <param name="s2">2nd string</param>
        /// <returns>result</returns>
        public string MultiplyStrings(string s1, string s2)
        {
            if (!(VerifyString(s1) && VerifyString(s2))) return string.Empty;

            string res = string.Empty;
            char[] c1 = s1.ToCharArray();
            Reverse(c1);
            char[] c2 = s2.ToCharArray();
            Reverse(c2);

            int tmp, mult, carry = 0;
            
            int[] result = new int[c1.Length + c2.Length + 1];


            for (int i = 0; i < c1.Length; i++)
            {
                int a = c1[i] - '0';
                for (int j =0 ; j <  c2.Length ; j++)
                {
                    int b = c2[j] - '0';
                    mult = (a * b + carry) % 10;
                    carry = (a * b + carry) / 10;

                    tmp = mult + result[i + j];
                    result[i + j] = tmp % 10;
                    carry += tmp / 10;
                }
                if (carry > 0)
                {
                    tmp = result[i + c2.Length] + carry;
                    result[i + c2.Length] = tmp % 10;
                    carry = tmp / 10;
                    result[i + c2.Length+1] = carry;
                    carry = 0;
                }
            }

            StringBuilder sb = new StringBuilder();
            if (result[result.Length - 1] != 0) sb.Append(result[result.Length - 1].ToString());
            for (int i = result.Length - 2; i >= 0; i--)
            {
                sb.Append(result[i].ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// verify a string is all numberic.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool VerifyString(string s)
        {
            if (s.Length == 0) return false;
            foreach (char c in s)
            {
                if (c < '0' || c > '9') return false;
            }
            return true;
        }

        /// <summary>
        /// reverse a char array
        /// </summary>
        /// <param name="c"></param>
        private void Reverse(char[] c)
        {
            char tmp;
            for (int i = 0; i < c.Length / 2; i++)
            {
                tmp = c[i];
                c[i] = c[c.Length-1 - i];
                c[c.Length - 1 - i] = tmp;
            }
        }
    }
}
