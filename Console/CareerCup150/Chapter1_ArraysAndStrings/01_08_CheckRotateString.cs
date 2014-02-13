using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapt1_ArraysAndStrings
{
    public class _01_08_CheckRotateString
    {
        /*
         * Assume you have a method isSubstring which checks if one word is a substring of another.
         * Given two strings, s1 and s2, write code to check if s2 is a rotation of s1 using only
         * one call to isSubstring (i.e., “waterbottle” is a rotation of “erbottlewat”).
         */
        public bool IsRotateString(string s1, string s2)
        {
            string tmp = s2 + s2;
            return IsSubstring(tmp, s1);
        }

        private bool IsSubstring(string s1, string s2)
        {
            return s1.IndexOf(s2) > -1;
        }
    }
}
