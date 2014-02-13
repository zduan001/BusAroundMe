using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Console2.From_026_To_050;

namespace Console2.From_051_To_75
{
    public class _052_KthPermutation
    {
        /*
            The set [1,2,3,…,n] contains a total of n! unique permutations.
            By listing and labeling all of the permutations in order,
            We get the following sequence (ie, for n = 3): 
            •"123"
            •"132"
            •"213"
            •"231"
            •"312"
            •"321"
            Given n and k, return the kth permutation sequence.
            Note: Given n will be between 1 and 9 inclusive.
         */
        public string FindKthPermutation(int n, int k)
        {
            string res = string.Empty;
            int[] input = new int[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = i + 1;
            }
            int l = 0;
            Worker(input, k-1, ref l,  0, ref res);
            return res;
        }

        public void Worker(int[] input, int k, ref int l, int length, ref string res)
        {
            if (l > k) return;
            if (length == input.Length-1)
            {
                if(k == l)
                {
                    StringBuilder sb = new StringBuilder();
                    for(int i = 0;i< input.Length;i ++)
                    {
                        sb.Append(input[i].ToString());
                    }
                    res = sb.ToString();

                }
                l++;
            }
            else
            {
                for (int i = length; i < input.Length; i++)
                {
                    Swap(input, i, length);
                    Worker(input, k, ref l,  length + 1, ref res);
                    Swap(input, i, length);
                }
            }
        }

        private void  Swap (int[] input, int i, int j)
        {
            int tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }

        public string KthPermutation(string s, int k)
        {
            _040_NextPermutation next = new _040_NextPermutation();
            for (int i = 0; i < k; i++)
            {
                s = next.NextPermutation(s);
            }
            return s;
        }
    }
}
