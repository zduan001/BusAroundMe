using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.cs
{
    public class _017_MinDiff
    {
        /*http://www.mitbbs.com/article_t/JobHunting/32349083.html
         * Given three arrays: A,B,C, you can get three element a,b,c from each of them. 
         * Find the minimum distance |a-b|+|b-c|+|c-a|.
         */
        public int FindMinDiff(int[] a, int[] b, int[] c)
        {
            // Sort three array O(nlgn).
            Array.Sort(a);
            Array.Sort(b);
            Array.Sort(c);

            int[] array = new int [a.Length + b.Length+ c.Length];
            char[] tracker = new char [a.Length + b.Length+ c.Length];

            //Merge 3 arraies O(n). space O(n)
            int i = 0,j = 0, k= 0;
            int l = 0;
            while(i < a.Length || j < b.Length ||k < c.Length)
            {
                if(i< a.Length &&
                    (j >= b.Length || a[i] <= b[j]) && 
                    (k >= c.Length || a[i] <= c[k]))
                {
                    array[l] = a[i];
                    tracker[l] = 'a';
                    i++;
                }
                else if(j< b.Length &&
                    (i >= a.Length || b[j] <= a[i]) && 
                    (k >= c.Length || b[j] <= c[k]))
                {
                    array[l] = b[j];
                    tracker[l] = 'b';
                    j ++;
                }
                else if(k<c.Length &&
                    (i>=a.Length || c[k] < a[i]) &&
                    (j>=b.Length || c[k] < b[j]))
                {
                    array[l] = c[k];
                    tracker[l] = 'c';
                    k++;
                }
                l++;
            }

            int minDiff = int.MaxValue;
            i = 0;
            string s = string.Empty;
            // scan through merged array. calculate min Diff. O(n)
            while (i < array.Length)
            {
                char ch = tracker[i];
                if (CountDistinctChar(s) == 2)
                {
                    if (ch == s[s.Length - 1])
                    {
                        s += ch;
                    }
                    else 
                    {
                        s += ch;
                        if (ch != s[0])
                        {
                            int tmp = (array[i] - array[i - s.Length + 1]) * 2;
                            minDiff = minDiff < tmp ? minDiff : tmp;
                            s = s[s.Length - 2].ToString() + s[s.Length - 1].ToString();
                        }
                        else
                        {
                            s = s[s.Length - 2].ToString() + s[s.Length - 1].ToString();
                        }
                    }
                }
                else
                {
                    if (s == string.Empty)
                    {
                        s = ch.ToString();
                    }
                    else if (s[s.Length - 1] != ch)
                    {
                        s = s[s.Length - 1] + ch.ToString();
                    }
                }
                i++;
            }

            return minDiff;
        }

        private int CountDistinctChar(string s)
        {
            HashSet<char> res = new HashSet<char>();
            foreach (char c in s)
            {
                if (!res.Contains(c))
                {
                    res.Add(c);
                }
            }
            return res.Count;
        }


    }
}
