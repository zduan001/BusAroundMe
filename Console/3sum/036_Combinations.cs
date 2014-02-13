using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _036_Combinations
    {
        /// <summary>
        /// Given two integers n and k, return all possible combinations of k numbers out of 1 ... n. 
        /// For example,
        /// If n = 4 and k = 2, a solution is: 
        /// [
        ///  [2,4],
        ///  [3,4],
        ///  [2,3],
        ///  [1,2],
        ///  [1,3],
        ///  [1,4],
        /// ]
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public List<List<int>> FindAllCombinations(int n, int k)
        {
            res.Clear();
            bool[] isPrint = new bool[n];
            PrintAllCombination(n, 0, k, isPrint);
            return res;
        }

        public void PrintAllCombination(int n, int start, int remain, bool[] isPrint)
        {
            if (remain == 0)
            {
                List<int> printOut = new List<int>();
                for (int i = 0; i < isPrint.Length; i++)
                {
                    if (isPrint[i])
                    {
                        printOut.Add(i);
                    }
                }
                res.Add(printOut);
                return;
            }
            else
            {
                if ((start + remain) > isPrint.Length)
                    return;

                for (int i = start; i < n; i++)
                {
                    if (!isPrint[i])
                    {
                        isPrint[i] = true;
                        PrintAllCombination(n, start + 1, remain - 1, isPrint);
                        isPrint[i] = false;
                    }
                }

            }
        }

        public List<List<int>> res = new List<List<int>>();
        public HashSet<string> hashSet = new HashSet<string>();

        #region second try

        /// <summary>
        /// Second try of 
        /// Given two integers n and k, return all possible combinations of k numbers out of 1 ... n. 
        /// For example,
        /// If n = 4 and k = 2, a solution is: 
        /// [
        ///  [2,4],
        ///  [3,4],
        ///  [2,3],
        ///  [1,2],
        ///  [1,3],
        ///  [1,4],
        /// ]
        /// After many tries, this method passed. I used a method to find all combination of the k element from input array.
        /// and verify the set has not been added to the res yet by a hashset.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        public List<List<int>> FindAllCombinations(List<int> input, int k)
        {
            res.Clear();
            hashSet.Clear();
            FindAllCombinations(input, k, 0);
            return res;
        }

        /// <summary>
        /// Working methods
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <param name="index"></param>
        public void FindAllCombinations(List<int> input, int k,int index)
        {
            if (index == k)
            {
                List<int> tmp = new List<int>();
                for (int i = 0; i < k; i++)
                {
                    tmp.Add(input[i]);
                }
                tmp.Sort();
                string tmpStr = string.Empty;
                foreach (int i in tmp)
                {
                    tmpStr += i.ToString() + ",";
                }
                if (!hashSet.Contains(tmpStr))
                {
                    hashSet.Add(tmpStr);
                    res.Add(tmp);
                }
                return;
            }

            for (int i = index; i < input.Count; i++)
            {
                Swap(input, index, i);
                FindAllCombinations(input, k, index + 1);
                Swap(input, index, i);
            }

        }

        private void Swap(List<int> input, int i, int j)
        {
            int tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }
        #endregion


        #region third try
        /// <summary>
        /// Still feel the second try used a hashset to rule out those already in the list. that is not ideal. try to find another way. 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public List<List<int>> FindAllCombination(List<int> input, int k)
        {
            List<List<int>> res = new List<List<int>>();
            res.Add(new List<int>());
            return res;
        }
        #endregion
    }
}
