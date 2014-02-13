using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _037_permutation
    {

        #region recursive
        /// <summary>
        /// get all permutation of a list of elements.
        /// For example,
        /// [1,1,2] have the following unique permutations:
        /// [1,1,2], [1,2,1], and [2,1,1].
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<List<int>> FindAllPermutation(List<int> input)
        {
            List<List<int>> res = new List<List<int>>();
            GetPermutation(res, input, 0);
            return res;
        }

        public void GetPermutation(List<List<int>> res, List<int> input, int index)
        {
            if (index == input.Count - 1)
            {
                res.Add(new List<int>(input));
            }
            else
            {
                for (int i = index; i < input.Count; i++)
                {
                    Swap(input, index, i);
                    GetPermutation(res, input, index + 1);
                    Swap(input, i, index);
                }
            }
        }

        public void Swap(List<int> input, int i, int j)
        {
            int tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }
        #endregion

        #region recursive with dup
        /// <summary>
        /// Same permutation just with duplicate element in it.
        /// Given a collection of numbers that might contain duplicates, return all possible unique permutations.
        /// For example,
        /// [1,1,2] have the following unique permutations:
        /// [1,1,2], [1,2,1], and [2,1,1].
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<List<int>> FindAllPermutationWithDuP(List<int> input)
        {
            List<List<int>> res = new List<List<int>>();
            GetPermutationWithDup(res, input, 0);
            return res;
        }

        public void GetPermutationWithDup(List<List<int>> res,List<int> input, int start)
        {
            if (start == input.Count - 1) res.Add(new List<int>(input));

            for (int i = start; i < input.Count; i++)
            {
                if (i == start || input[i] != input[start])
                {
                    Swap(input, i, start);
                    GetPermutationWithDup(res, input, start + 1);
                    Swap(input, i, start);
                }
            }
        }
        #endregion

        #region DP

        /*代码分析：
　　      DP的做法
　　      例如：
　　      1，2，3
　　      1 的 所有排列组合 ： 1
　　      1，2 的所有排列组合 = （2，1）， （1，2) 。 就是用2加到之前所有排列组合的前面， 插入到每个元素之间 (这里没有），加到后面。
　　      1，2，3 的所有排列组合 = （3，2，1）前面， （2，3，1）之间， （2，1，3）后面， （3，1，2）前面， （1，3，2）之间， (1，2，3) 后面
        */
        /// <summary>
        /// Find Permutation DP. this is kind of DP, it does have smaller problem set concept though.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<List<int>> FindAllPermutationDP(List<int> input)
        {
            List<List<int>> current = new List<List<int>>();
            List<List<int>> next = new List<List<int>>();

            current.Add(new List<int>() { input[0]});

            for (int i = 1; i < input.Count; i++)
            {
                for (int j = 0; j < current.Count; j++)
                {
                    List<int> tmp = new List<int>(current[j]);
                    int count = tmp.Count;
                    for (int k = 0; k <= count; k++)
                    {
                        tmp.Insert(k, input[i]);
                        next.Add(new List<int>(tmp));
                        tmp.RemoveAt(k);
                    }
                }
                List<List<int>> x = current;
                current = next;
                x.Clear();
                next = x;
            }
            return current;
        }


        /// <summary>
        /// Another try of DP.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static List<List<int>> PermutationDP(List<int> num)
        {
            if (num.Count == 0)
                return null;

            List<List<int>> curr = new List<List<int>>();
            List<List<int>> next = new List<List<int>>();

            curr.Add(new List<int> { num[0] });
            for (int i = 1; i < num.Count; i++)
            {
                for (int p = 0; p < curr.Count; p++)
                {
                    List<int> temp = new List<int>(curr[p]);
                    int temp_count = temp.Count;
                    for (int k = 0; k <= temp_count; k++)
                    {
                        temp.Insert(k, num[i]);
                        next.Add(new List<int>(temp));
                        temp.RemoveAt(k);
                    }
                }
                PermutationDPSwap(ref curr, ref next);
                next.Clear();
            }

            return curr;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="curr"></param>
        /// <param name="next"></param>
        public static void PermutationDPSwap(ref List<List<int>> curr, ref List<List<int>> next)
        {
            List<List<int>> temp;
            temp = curr;
            curr = next;
            next = temp;
        }

        #endregion
    }

}
