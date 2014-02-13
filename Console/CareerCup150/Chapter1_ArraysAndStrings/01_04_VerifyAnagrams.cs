using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapt1_ArraysAndStrings
{
    public class _01_04_VerifyAnagrams
    {
        /*
         * Write a method to decide if two strings are anagrams or not.
         */
        /// <summary>
        /// this just simulate c style string, sort the char array and compare 2 arraries
        /// to see if 2 arraies are same.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public bool IsAnagrams(string s1, string s2)
        {
            if (string.IsNullOrWhiteSpace(s1) || string.IsNullOrWhiteSpace(s2)) return false;
            if (s1.Length != s2.Length) return false;
            char[] c1 = s1.ToArray();
            char[] c2 = s2.ToArray();

            Array.Sort(c1);
            Array.Sort(c2);

            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            for (int i = 0; i < c1.Length; i++)
            {
                sb1.Append(c1[i]);
                sb2.Append(c2[i]);
            }

            return sb1.ToString() == sb2.ToString();
        }
    }
}
