using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleQuestions
{
    public class _001_SortString
    {
        /*
         * http://www.mitbbs.com/article_t/JobHunting/32079701.html
         * Given an input string and an order string, e.g., “house” and “soup”, print out
            characters in input string according to character order in order string. For characters in
            input string but not in order string, output them in the end, their relative order doesn’t
            matter.
            So for “house”, “souhe” and “soueh” are valid outputs.
         */
        /*
         * solution: may not match the code below:
         * 1. write a hash table put the pattern's string's character and index in the the hashtable
         * 2. go through the target string (s1) keep count of each charater. if a character is not in 
         * the hash table. write it into a tmp string, this tmp string will be append to the end of the res string
         * 3. go through the hash table by the index and count, construct the res string
         * 4. append the tmp string to the end of the res string and out put.
         * 
         * solution2:
         * 1. write a hash table put the pattern's string's character and index in the hashtable.
         * 2. sort the first string base on the index in the hashtable. if a character is not in the hash table set it's index as int_Max.
         * 3. output the sorted string.
         */
        public char[] SortStringBaseOnString(string s1, string s2)
        {
            char[] res = new char[s1.Length];
            for (int i = 0; i < s1.Length; i++)
            {
                res[i] = s1[i];
            }

            HashSet<char> visited = new HashSet<char>(); // used to track char's visited in s2, incase s2 has dup char.
            int startIndex = 0;

            for (int i = 0; i < s2.Length; i++)
            {
                if (!visited.Contains(s2[i]))
                {
                    visited.Add(s2[i]);
                    int tmp = startIndex;
                    while (tmp < res.Length)
                    {
                        if (res[tmp] == s2[i])
                        {
                            char c = res[startIndex];
                            res[startIndex] = res[tmp];
                            res[tmp] = c;
                            startIndex++;
                        }
                        tmp++;
                    }
                }
            }
            return res;
        }
    }
}
