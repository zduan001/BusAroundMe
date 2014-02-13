using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _044_Subsets
    {
        /// <summary>
        /// Given a set of distinct integers, S, return all possible subsets.
        /// Note:
        /// Elements in a subset must be in non-descending order.
        /// The solution set must not contain duplicate subsets.
        /// For example,
        /// If S = [1,2,3], a solution is:
        ///  [ [3], [1], [2], [1,2,3], [1,3], [2,3], [1,2], [] ]
        /// </summary>
        /// <param name="input"></param>
        public List<List<int>> FindAllSubSet(List<int> input)
        {
            _036_Combinations obj = new _036_Combinations();
            obj.res.Clear();
            obj.hashSet.Clear();
            for (int i = 0; i <= input.Count; i++)
            {
                obj.FindAllCombinations(input, i,0);
            }
            return obj.res;
        }

        /// <summary>
        /// Same function different way. This one is kind of DP solution...
        /// I need to get familar with this DP method.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<List<int>> FindAllSubSet2(List<int> input)
        {
            List<List<int>> res = new List<List<int>>();
            List<int> empty = new List<int>();
            res.Add(empty);

            for(int i = 0;i < input.Count;i ++)
            {
                int resCount = res.Count;
                for(int j = 0; j< resCount ;j ++)
                {
                    List<int> tmp = new List<int>(res[j]);
                    tmp.Add(input[i]);
                    res.Add(tmp);
                }
            }
            return res;
        }

        /// <summary>
        /// Same function different way, this time try to use recursive.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<List<int>> FindAllSubSet3(List<int> input)
        {
            List<List<int>> res = new List<List<int>>();
            FindAllSubSet3Working(res, input, 0);
            return res;
        }

        private void FindAllSubSet3Working(List<List<int>> res, List<int> input, int index)
        {
            if (index == input.Count)
            {
                res.Add(new List<int>());
            }
            else
            {
                FindAllSubSet3Working(res, input, index + 1);
                int count = res.Count;
                for (int i = 0; i < count; i++)
                {
                    List<int> tmp = new List<int>(res[i]);
                    tmp.Add(input[index]);
                    res.Add(tmp);
                }
            }
        }

        /// <summary>
        /// Same goal with another method.
        /// 代码分析：
        /// 　　介绍一种比较不一样的方法——Combinatoric。
        /// 　　　　例子： S = { 1, 2, 3}
        /// 　　　　i = 0 : (1 << S.Count - 1) = 0 : 111 (就是S有3个数，i 最大到 111， 4个数， i 最大就到 1111 。。。）
        /// 　　　　　　然后 k = i； k & 1 == 1 就把相应 S[index] 加到答案里面。然后k >>= 1;
        /// 　　　　　　　　k = 0;(0x0)　　{}
        /// 　　　　　　　　k = 1;(0x1)　　{1}
        /// 　　　　　　　　k = 2;(0x10)　 {2},
　　    ///                k = 3;(0x11)　 {1,2};
        ///                k = 4;(0x100)  {3};
        ///                k = 5;(0x101)  {1,3};
        ///                k = 6;(0x110)  {2,3};
        ///                k = 7;(0x111)  {1,2,3}; 　
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public List<List<int>> SubsetsCombinatoric(List<int> S)
        {
            S.Sort();
            List<List<int>> ret = new List<List<int>>();

            for (int i = 0; i < (1 << S.Count); i++)
            {
                int k = i;
                int index = 0;
                List<int> subset = new List<int>();
                while (k > 0)
                {
                    if ((k & 1) > 0)
                    {
                        subset.Add(S[index]);
                    }
                    k >>= 1;
                    index++;
                }
                ret.Add(subset);
            }

            return ret;
        }

        /// <summary>
        /// Given a collection of integers that might contain duplicates, S, return all possible subsets.
        /// Note:
        /// Elements in a subset must be in non-descending order.
        /// The solution set must not contain duplicate subsets.
        /// For example,
        /// If S = [1,2,2], a solution is:
        /// [ [2], [1], [1,2,2], [2,2], [1,2], [] ]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<List<int>> FindSubSetsWithDup(List<int> input)
        {
            //First though I have is remove dup from the input list. then do the normal thing, but [1,2,2] is a valid output.
            //So I can not just remove the dup.
            //then I think a hashset can help. but need extra space.

            input.Sort();
            List<List<int>> res = new List<List<int>>();
            res.Add(new List<int>());

            int start = 0;

            for (int i = 0; i < input.Count; i++)
            {
                int count = res.Count;
                for (int j = start; j < count; j++)
                {
                    List<int> tmp = new List<int>(res[j]);
                    tmp.Add(input[i]);
                    res.Add(tmp);
                }
                if (i < input.Count - 1 && input[i] == input[i + 1])
                {
                    start = count;
                }
                else
                {
                    start = 0;
                }
            }

            return res;
        }
    }
}
