using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _009_Triangle
    {
        /*
         * http://leetcode.com/onlinejudge#question_120
         *      [2],
                [3,4],
               [6,5,7],
              [4,1,8,3]

         */
        public int FindMinPath(List<List<int>> input)
        {
            List<List<int>> tracker = new List<List<int>>();

            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input[i].Count; j++)
                {
                    if (i == 0)
                    {
                        tracker.Add(new List<int>() { input[0][0] });
                    }
                    else if (j == 0)
                    {
                        tracker.Add(new List<int>() { tracker[i-1][0] + input[i][0]});
                    }
                    else if (j == input[i].Count - 1)
                    {
                        tracker[i].Add(tracker[i - 1][j - 1]+ input[i][j]);
                    }
                    else
                    {
                        int tmp = Math.Min(tracker[i - 1][j - 1],tracker[i - 1][j]);
                        tracker[i].Add(input[i][j] + tmp);
                    }
                }
            }

            int res = int.MaxValue;
            foreach (int value in tracker[input.Count - 1])
            {
                res = value < res ? value : res;
            }

            return res;
        }
    }
}
