using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_1_6_CircularShift
    {
        /*
         * A string s is a circular rotation of a string t if it matches when the characters are circularly 
         * shifted by any number of positions; e.g., ACTGACG is a circular shift of TGACGAC, and vice versa. 
         * Detecting this condition is important in the study of genomic sequences. Write a program that checks
         * whether two given strings s and t are circular shifts of one another. Hint: The solution is 
         * a one-liner with indexOf() , length() , and string concatenation.
         */
        public int VerifyStringShift(string s1, string s2)
        {
            if(s1.Length == 0 || s2.Length == 0) return -1;
            if(string.IsNullOrWhiteSpace(s1) || string.IsNullOrWhiteSpace(s2)) return -1;
            s2 = s2 + s2;

            for (int i = 0; i <= s1.Length; i++)
            {
                for (int j = 0; j < s1.Length; j++)
                {
                    if (s2[i + j] != s1[j])
                    {
                        break;
                    }
                    if (j == s1.Length - 1)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
