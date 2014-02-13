using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _016_ImplementStrStr
    {
        /// <summary>
        /// Returns a pointer to the first occurrence of needle in haystack, or null if needle is not part of haystack.
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int FindStrInStr(string haystack, string needle)
        {
            if (haystack.Length < needle.Length) return 0;
            for (int i = 0; i <= haystack.Length - needle.Length; i++) 
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j]) break;
                    if (j == needle.Length - 1) return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Find string in a string using Z algorithm.
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int FindStrStrZAlgorithm(string haystack, string needle)
        {
            string s = needle + "#" + haystack;
            int n = s.Length;
            int[] z = new  int[n];
            int goal = needle.Length;
            int r = 0, l = 0, i;

            for(int k = 1; k< n ; k ++)
            {
                if(k> r)
                {
                    for(i = k ;i< n && s[i] == s[i-k]; i ++);
                    if(i>k)
                    {
                        z[k] = i -k;
                        r = i-1;
                    }
                }
                else
                {
                    int kt = k -1, b = r-k +1;
                    if(z[kt] > b)
                    {
                        for(i = r+1; i< n && s[i] == s[i-k]; i ++);
                            z[k] = i-k;
                        l=k;
                        r = i -1;
                    }
                }
                if(z[k] == goal)
                    return k - goal -1;
            }
            return -1;

        }
    }
}
