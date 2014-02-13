using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapt1_ArraysAndStrings
{
    public class _01_02_ReverseString
    {
        /*
         * Write code to reverse a C-Style String. (C-String means that “abcd” is represented as five characters, including the null character.
         */
        public string ReverseStr(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return string.Empty;
            }

            char[] chars = s.ToArray();

            for (int i = 0; i < chars.Length/2; i++)
            {
                char c = chars[i];
                chars[i] = chars[chars.Length - i-1];
                chars[chars.Length - i-1] = c;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < chars.Length; i++)
            {
                sb.Append(chars[i]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Maybe when I need to do a mirro, while loop is better
        /// I do not have to consider the +/- 1 on index.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReverseStrWhileLoop(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return string.Empty;
            }

            char[] chars = s.ToArray();

            int left = 0;
            int right = chars.Length - 1;
            while (left < right)
            {
                char c = chars[left];
                chars[left] = chars[right];
                chars[right] = c;
                // increase and decrease left right index. 
                // never ever forget it while interview.
                left++;
                right--;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < chars.Length; i++)
            {
                sb.Append(chars[i]);
            }
            return sb.ToString();
        }
    }
}
