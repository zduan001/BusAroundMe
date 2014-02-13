using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_001_To_025
{
    public class _014_EditDistance
    {
        /*
            Given two words word1 and word2, find the minimum number of steps required to convert word1 to word2. (each operation is counted as 1 step.)
 
            You have the following 3 operations permitted on a word:
 
            a) Insert a character
            b) Delete a character
            c) Replace a character
 
            "abc" -> "bbdc" : change 'a' to 'b', remove 'd' : 2 steps
            */
        public int FindEditDistance(string s1, string s2)
        {
            int m = s1.Length;
            int n = s2.Length;
            int[,] res = new int[m, n];
            if (s1[0] == s2[0])
            {
                res[0, 0] = 0;
            }
            else
            {
                res[0, 0] = 1;
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int a = 0;
                    int b = 0;
                    int c = 0;
                    if (i - 1 >= 0)
                    {
                        a = res[i - 1, j] + 1;
                    }
                    if (j - 1 >= 0)
                    {
                        b = res[i, j - 1] + 1;
                    }

                    if (i - 1 >= 0 && j - 1 >= 0)
                    {
                        if (s1[i] == s2[j])
                            c = res[i - 1, j - 1];
                        else
                            c = res[i - 1, j - 1] + 1;
                    }
                    res[i, j] = Math.Min(a, Math.Min(b, c));
                }
            }
            return res[m - 1, n - 1];
        }
    }
}
