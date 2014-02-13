using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _012_InterleaveSortString
    {
        /*
         * 
        16. a1a2a3b1b2b3  排序成   a1b1a2b2a3b3
        From <http://www.mitbbs.com/article_t/JobHunting/32448865.html> 

         */
        public void solve(int[] arr, int s, int e)
        {
            if (s >= e)
                return;

            int center = (s + e) / 2;

            //left part: s,...,center;  
            //right part center+1,...,e  
            int ls = s;
            int le = center;
            int rs = center + 1;
            int re = e;

            for (int i = (le + ls) / 2 + 1, j = rs; i <= le; i++, j++)
                Swap(arr, i, j);

            //奇数个  
            if (le!= ls && (le - ls) % 2 == 0)
            {
                le++;
                rs--;
            }

            solve(arr, ls, le);
            solve(arr, rs, re);
        }

        private void Swap(int[] input, int left, int right)
        {
            int tmp = input[left];
            input[left] = input[right];
            input[right] = tmp;
        }
    }
}
