using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.cs
{
    public class _018_FidnRegions
    {
        /*
         * 8   -1    4
           3   -1   -1
           5    2    2
         * total region =2， 一個是 83522. 另一個是4，
         * -1就是 當 一個 分隔區域的 separator
         */
        public int CountRegions(int[,] input, int n)
        {
            bool[,] tracker = new bool[n, n];

            int regions = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (input[i, j] != -1 && !tracker[i, j])
                    {
                        regions++;
                        Travel(input, i, j, tracker, n);
                    }
                }
            }
            return regions;
        }

        private void Travel(int[,] input, int i, int j, bool[,] tracker, int n)
        {
            tracker[i, j] = true;
            for (int l = i - 1; l <= i + 1; l++)
            {
                for (int m = j - 1; m <= j + 1; m++)
                {
                    if (l >= 0 && l < n &&
                        m >= 0 && m < n &&
                        input[l, m] != -1 &&
                        !tracker[l, m])
                    {
                        Travel(input, l, m, tracker, n);
                    }
                }
            }
        }
    }
}
