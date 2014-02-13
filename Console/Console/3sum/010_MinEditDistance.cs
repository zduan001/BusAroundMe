using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _010_MinEditDistance
    {
        /// <summary>
        /// Given two words word1 and word2, find the minimum number of steps required to convert word1 to word2. (each operation is counted as 1 step.)
        /// You have the following 3 operations permitted on a word:
        /// a) Insert a character
        /// b) Delete a character
        /// c) Replace a character
        /// "abc" -> "bbdc" : change 'a' to 'b', remove 'd' : 2 steps
        /// solution: use DP, 
        /// </summary>
        /// <param name="s1">first string</param>
        /// <param name="s2">second string</param>
        /// <returns>min edit distance</returns>
        public int FindMinEditDistance(string s1, string s2)
        {
            int m = s1.Length;
            int n = s2.Length;
            int[,] track = new int[m,n];
            track[0,0] = s1[0] == s2[0] ? 0: 1;
            for (int i = 1; i < n; i++)
            {
                track[0, i] = s1[0] == s2[i] ? track[0, i - 1] : track[0, i - 1] + 1;
            }
            for (int i = 1; i < m; i++)
            {
                track[i, 0] = s1[i] == s2[0] ? track[i-1, 0] : track[i-1, 0] + 1;
            }
            for(int i = 1; i < m; i ++)
            {
                for(int j = 1; j< n ; j ++)
                {
                    track[i,j] = Math.Min( Math.Min(track[i-1,j] +1, track[i,j-1] + 1), s1[i]==s2[j]? track[i-1,j-1]:track[i-1,j-1] +1);
                }
            }
            return track[m-1,n-1];
        }
    }
}
