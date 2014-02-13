using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_001_To_025
{
    public class _018_StrInStr
    {
        /*
         Implement strStr().
         Returns a pointer to the first occurrence of needle in haystack, 
         or -1 if needle is not part of haystack.
         */
        public int StrInStr(string haystack, string needle)
        {
            
            int h = haystack.Length;
            int k = needle.Length;
            if (k > h) return -1;

            for (int i = 0; i < h - k + 1; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (haystack[i + j] == needle[j])
                    {
                        if (j == k - 1)
                        {
                            return i;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return -1;
        }
    }
}
