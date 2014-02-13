using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_062_Find3Index
    {
        /*
         * Given a array of integers , find 3 indexes i; j; k such that, i < j < k and a[i] < a[j] < a[k].
         */
        public List<int> Find3Index(int[] input)
        {
            int n = input.Length;
            int[] left = new int[n];
            int[] right = new int[n];

            int min = 0;
            for (int i = 1; i < n; i++)
            {
                if (input[i] < input[left[i - 1]])
                {
                    left[i] = i;
                }
                else
                {
                    left[i] = left[i - 1];
                }
            }

            right[n - 1] = n - 1;
            for (int i = n - 2; i >= 0; i--)
            {
                if (input[i] > input[right[i + 1]])
                {
                    right[i] = i;
                }
                else
                {
                    right[i] = right[i + 1];
                }
            }

            for (int i = 1; i < n - 1; i++)
            {
                if (left[i] < i && i < right[i] && input[left[i]] < input[i] && input[i] < input[right[i]])
                {
                    List<int> res = new List<int>();
                    res.Add(left[i]);
                    res.Add(i);
                    res.Add(right[i]);
                    return res;
                }
            }
            return null;
        }
    }
}
