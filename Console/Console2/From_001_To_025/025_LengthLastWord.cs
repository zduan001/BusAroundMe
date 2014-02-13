using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_001_To_025
{
    public class _025_LengthLastWord
    {
        /*
        Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.
        If the last word does not exist, return 0.
        Note: A word is defined as a character sequence consists of non-space characters only.
        For example, 
        Given s = "Hello World",
        return 5.
        */
        /// <summary>
        /// this question might be interesting to c++ but for c# it does not mean anything.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FindLengthOfLastWord(string s)
        {
            int i = s.Length - 1;
            while (s[i] != ' ' && i >= 0)
            {
                i--;
            }
            if (i >= 0) return s.Length-1  - i;
            else return 0;
        }
    }
}
