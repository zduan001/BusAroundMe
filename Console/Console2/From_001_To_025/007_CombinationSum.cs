using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_001_To_025
{
    public class _007_CombinationSum
    {
        /*
            Given a set of candidate numbers (C) and a target number (T), find all unique combinations in C where the candidate numbers sums to T.
            The same repeated number may be chosen from C unlimited number of times.
 
            Note:
            All numbers (including target) will be positive integers.
            Elements in a combination (a1, a2, … ,ak) must be in non-descending order. (ie, a1 ≤ a2 ≤ … ≤ ak).
            The solution set must not contain duplicate combinations.
            For example, given candidate set 2,3,6,7 and target 7, 
            A solution set is: 
            [7] 
            [2, 2, 3]
         */
        /// <summary>
        /// DP, what else? this is Knapsack problem.....
        /// I assume input is not sorted. and there might be a lot of number is C is larger than target value.
        /// So it is worth it to sort it frist.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value"></param>
        public List<List<int>> CombinationSum(int[] input, int value)
        {
            if (value <= 0) return null;
            Array.Sort(input);
            List<List<int>>[] tmp = new List<List<int>>[value + 1];
            tmp[0] = new List<List<int>>();

            for (int i = 1; i <= value; i++)
            {
                List<List<int>> res = new List<List<int>>();
                for (int j = 0; j < input.Length; j++)
                {
                    if (i - input[j] > 0)
                    {
                        if (tmp[i - input[j]] != null && tmp[i - input[j]].Count != 0)
                        {
                            foreach (List<int> l in tmp[i - input[j]])
                            {
                                // this line make sure the result is in a increase order. 
                                //but can select same value. [2,2,3] is allowed.
                                //[2,3,2] is not allowed.
                                if (input[j] >= l.Last())
                                {
                                    List<int> newList = new List<int>(l);
                                    newList.Add(input[j]);
                                    res.Add(newList);
                                }
                            }
                        }

                    }
                    else if (i == input[j])
                    {
                        res.Add(new List<int>() { input[j] });
                    }
                    else
                    {
                        // if input[j] already larget than then there 
                        // is no need to go further.
                        break;
                    }
                    tmp[i] = res;
                }
            }
            return tmp[value];
        }

        /*
            Given a collection of candidate numbers (C) and a target number (T), find all unique combinations in C 
            where the candidate numbers sums to T.
 
            Each number in C may only be used once in the combination.
 
            Note:
            All numbers (including target) will be positive integers.
            Elements in a combination (a1, a2, … ,ak) must be in non-descending order. (ie, a1 ≤ a2 ≤ … ≤ ak).
            The solution set must not contain duplicate combinations.
            For example, given candidate set 10,1,2,7,6,1,5 and target 8, 
            A solution set is: 
            [1, 7] 
            [1, 2, 5] 
            [2, 6] 
            [1, 1, 6]
          */
        /// <summary>
        /// DP... there is still a bug in the following code. I need to figurat it out.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<List<int>> CombinationSumNoRepeat(int[] input, int value)
        {
            Array.Sort(input);
            List<List<int>>[,] res = new List<List<int>>[input.Length, value + 1];

            for (int i = 1; i <= value; i++)
            {
                
                for (int j = 0; j < input.Length; j++)
                {
                    List<List<int>> tmp = new List<List<int>>();
                    if (j - 1 > 0 && res[j - 1, i] != null && res[j - 1, i].Count > 0)
                    {
                        foreach (List<int> list in res[j - 1, i])
                        {
                            List<int> newList = new List<int>(list);
                            tmp.Add(newList);
                        }
                    }

                    if (i - input[j] > 0 && j-1 >0)
                    {
                        if (res[j - 1, i - input[j]] != null && res[j - 1, i - input[j]].Count > 0)
                        {
                            foreach (List<int> list in res[j - 1, i - input[j]])
                            {
                                if (input[j] >= list.Last())
                                {
                                    List<int> newList = new List<int>(list);
                                    newList.Add(input[j]);
                                    tmp.Add(list);
                                }
                            }
                        }
                    }
                    
                    if (i - input[j] == 0)
                    {
                        tmp.Add(new List<int>() { input[j] });
                    }

                    res[j, i] = tmp;
                }

            }
            return res[input.Length - 1, value];
        }
    }
}
