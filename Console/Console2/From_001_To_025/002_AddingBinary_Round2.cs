using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2
{
    public class _002_AddingBinary_Round2
    {
        /// <summary>
        /// Given two binary strings, return their sum (also a binary string). 
        /// 
        /// tell the interviewer, the least significant digit is the index 0 of the string.
        /// if this is not true, I can simply reverse the string at the beginning of the 
        /// method.
        /// </summary>
        /// <param name="s1">first binary string</param>
        /// <param name="s2">second binary string</param>
        /// <returns>result as integer value</returns>
        public string AddBinaryString(string s1, string s2)
        {
            int carry= 0;
            int a;
            int b;
            int res=0;
            int length = s1.Length > s2.Length ? s1.Length : s2.Length;
            for (int i = 0; i < length; i++)
            {
                #region do not write code like this
                // I really need to get ride of the following writing habit.
                //if (i < s1.Length)
                //{
                //    a = int.Parse(s1[i].ToString());
                //}
                //else
                //{
                //    a = 0;
                //}

                //if (i < s2.Length)
                //{
                //    b = int.Parse(s2[i].ToString());
                //}
                //else
                //{
                //    b = 0;
                //}
                #endregion

                a = i < s1.Length ? s1[i] - '0' : 0;
                b = i < s2.Length ? s2[i] - '0' : 0;

                res = res | (((a ^ b) ^ carry) << i);
                carry = (a & b) | (b & carry) | (a & carry);
            }
            res |= carry << length;

            StringBuilder sb = new StringBuilder();
            while (res > 0)
            {
                sb.Append((res & 1).ToString());
                res = res >> 1;
            }

            return sb.ToString();
        }

        /// <summary>
        /// same method just hate last function has to work on the reverted string.
        /// this is just actually a one line change.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public string AddBinaryStringRightOrder(string s1, string s2)
        {
            int carry= 0;
            int a;
            int b;
            int res=0;
            int length = s1.Length > s2.Length ? s1.Length : s2.Length;
            for (int i = 0; i < length; i++)
            {
                a = i < s1.Length ? s1[s1.Length-i -1] - '0' : 0;
                b = i < s2.Length ? s2[s2.Length-i -1] - '0' : 0;

                res = res | (((a ^ b) ^ carry) << i);
                carry = (a & b) | (b & carry) | (a & carry);
            }
            res |= carry << length;

            StringBuilder sb = new StringBuilder();
            while (res > 0)
            {
                sb.Append((res & 1).ToString());
                res = res >> 1;
            }

            char[] c = sb.ToString().ToCharArray();
            Array.Reverse(c);
            return new string(c);
        }
    }
}
