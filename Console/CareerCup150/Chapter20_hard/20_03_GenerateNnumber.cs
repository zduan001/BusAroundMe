using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter20_hard
{
    public class _20_03_GenerateNnumber
    {
        /*
         * Write a method to randomly generate a set of m integers from an array of size n. Each element must have equal probability of being chosen.
         */

        public int[] GenerateRandom(int n, int m)
        {
            if (n < m) return null;
            int[] tmp = new int[n];
            for (int i = 1; i <= n; i++)
            {
                tmp[i - 1] = i;
            }
            Random ran = new Random();
            for (int i = 0; i < m; i++)
            {
                int randomNumber = ran.Next(i, n-1);
                Swap(tmp, i, randomNumber);
            }
            int[] res = new int[m];
            for (int i = 0; i < m; i++)
            {
                res[i] = tmp[i];
            }
            return res;
        }

        public void Swap(int[] input, int i, int j)
        {
            int tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }
    }
}
