using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_026_To_050
{
    /*
    Given two numbers represented as strings, return multiplication of the numbers as a string.
    Note: The numbers can be arbitrarily large and are non-negative.
    */
    public class _038_MultiplyStrings
    {
        /// <summary>
        /// Beside do a real multiplication is any other smart way to do it?
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public string Multiply(string s1, string s2)
        {
            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();

            int[] n1 = new int[c1.Length];
            int[] n2 = new int[c2.Length];

            for (int i = 0; i < n1.Length; i++)
            {
                n1[i] = int.Parse(c1[i].ToString());
            }
            for (int i = 0; i < n2.Length; i++)
            {
                n2[i] = int.Parse(c2[i].ToString());
            }

            int[] res = new int[n1.Length + n2.Length + 5];

            for (int i = 0; i < n1.Length; i++)
            {
                for (int j = 0; j < n2.Length; j++)
                {
                    int pro = n1[i] * n2[j];
                    int OneDigit = pro % 10;
                    int TenthDigit = (pro / 10) % 10;

                    int res1 = OneDigit + res[i + j];
                    res[i + j] = res1 % 10;
                    int carry = 0;
                    if (res1 >= 10) carry = 1;


                    int res2 = TenthDigit + res[i + j + 1] + carry;
                    res[i + j + 1] = res2 % 10;
                    carry = 0;
                    if (res2 >= 10) carry = 1;
                    res[i + j + 2] += carry;
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < res.Length; i++)
            {
                sb.Append(res[i].ToString());
            }
            // need to trim down the end '0'

            return sb.ToString().TrimEnd(new char[] { '0' });
        }
    }
}
