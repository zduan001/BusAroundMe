using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftQuestions
{
    public class _002_StringEditDistance
    {
        /*
         * string edit distance的递归解法。
         * http://www.mitbbs.com/article_t1/JobHunting/32267699_0_1.html
         * 
         * 
         */
        public int FindEditDistance(string s1, string s2)
        {
            if (s1.Length == 0)
            {
                return s2.Length;
            }
            else if (s2.Length == 0)
            {
                return s1.Length;
            }
            else
            {
                int a = FindEditDistance(s1.Substring(1), s2) + 1;
                int b = FindEditDistance(s1, s2.Substring(1)) + 1;
                int c = FindEditDistance(s1.Substring(1), s2.Substring(1));
                c = s1[0] == s2[0] ? c : c + 1;
                return Math.Min(Math.Min(a, b), c);
            }
        }

        public int FindEditDistanceDP(string s1, string s2)
        {
            int m = s1.Length;
            int n = s2.Length;
            int[,] res = new int[m, n];

            return 0;

        }
    }
}
