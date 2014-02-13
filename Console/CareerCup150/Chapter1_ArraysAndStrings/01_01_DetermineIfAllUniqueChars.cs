using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapt1_ArraysAndStrings
{
    public class _01_01_DetermineIfAllUniqueChars
    {
        /*
         * Implement an algorithm to determine if a string has all unique characters. 
         * What if you can not use additional data structures?
         */

        public bool IsUnique(string s)
        {
            HashSet<char> tracker = new HashSet<char>(); // I can use a bitArray here to reduce the size of memory using.
            foreach (char c in s)
            {
                if (tracker.Contains(c))
                {
                    return false;
                }
                tracker.Add(c);
            }
            return true;
        }

        /// <summary>
        /// No additional DS. 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsUniqueNoAdditionalDS(string s)
        {
            char[] chars = s.ToArray();
            Array.Sort(chars);

            for (int i = 0; i < chars.Length - 1; i++)
            {
                if (chars[i] == chars[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
