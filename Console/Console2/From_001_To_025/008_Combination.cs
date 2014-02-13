using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_001_To_025
{
    public class _008_Combination_Round2
    {
        /*
         * Given two integers n and k, return all possible combinations of k numbers out of 1 ... n.
 
            For example,
            If n = 4 and k = 2, a solution is:
 
             [2,4],
             [3,4],
             [2,3],
             [1,2],
             [1,3],
             [1,4]

         */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="count"></param>
        public List<List<int>> GetCombinations(int n, int k)
        {
            if (n < k) return null;

            int[] input = new int[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = i + 1;
            }

            List<List<int>> res = new List<List<int>>();
            CombinationWorker(input, res, k, k);

            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="tracker"></param>
        /// <param name="k"></param>
        /// <param name="remain"></param>
        public void CombinationWorker(int[] input, List<List<int>> tracker, int k, int remain)
        {
            if (remain == 0)
            {
                List<int> tmp = new List<int>();
                for (int i = 0; i < k; i++)
                {
                    tmp.Add(input[i]);
                }
                tracker.Add(tmp);
            }


            for (int i = k - remain + 1; i < input.Length; i++)
            {
                Swap(input, k - remain, i);
                CombinationWorker(input, tracker, k, remain - 1);
                Swap(input, k - remain, i);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        private void Swap(int[] input, int i, int j)
        {
            int tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }

        /// <summary>
        /// Same goal as last method, this one use iterative, and hope this is a bug free method.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public List<List<int>> FindCombinationII(int n, int k)
        {
            List<List<int>>[] res = new List<List<int>>[k];
            res[0] = new List<List<int>>();
            res[1] = new List<List<int>>();
            for (int i = 1; i <= n; i++)
            {
                res[0].Add(new List<int>() { i });
            }
            int preIndex = 0;
            int curIndex = 1;

            for (int i = 1; i < k; i++)
            {
                curIndex = i % 2;
                res[curIndex].Clear();

                foreach (List<int> origList in res[preIndex])
                {
                    int maxItem = origList.Last();
                    for (int j = maxItem + 1; j <= n; j++)
                    {
                        List<int> newList = new List<int>(origList);
                        newList.Add(j);
                        res[curIndex].Add(newList);
                    }
                }
                preIndex = curIndex;
            }
            return res[preIndex];
        }
    }
}
