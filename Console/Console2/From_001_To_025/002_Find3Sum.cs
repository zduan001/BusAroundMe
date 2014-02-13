using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2
{
    public class _002_Find3Sum_Round2
    {
        /// <summary>
        /// Find all the set of 3 numbers which are added to 0.
        /// Question need to ask.
        /// 1. does the array contains dup?
        /// 2. can I have dups in the result set.
        /// 3. if array contans dup. does res allow to contains dup? such as {2,-3,-3,1} can I have 2 {2,-3,1} in the result?
        /// 
        /// following code assume, there is might be dups in the input and dup in the res is not allowed.
        /// </summary>
        /// <param name="input">the input array.</param>
        /// <returns>the set of list of integers.</returns>
        public List<List<int>> Find3Sum(int[] input)
        {
            if (input.Length < 3) return new List<List<int>>();
            Array.Sort(input);
            List<List<int>> res = new List<List<int>>();
            HashSet<string> tracker = new HashSet<string>();

            for (int i = 0; i < input.Length - 2; i++)
            {
                int left = i + 1;
                int right = input.Length - 1;
                while (left < right)
                {
                    int tmp = input[i] + input[left] + input[right];
                    if (tmp == 0)
                    {
                        string s = input[i].ToString() + "," + input[left].ToString() + "," + input[right].ToString();
                        if (!tracker.Contains(s))
                        {
                            res.Add(new List<int>() { input[i], input[left], input[right] });
                            tracker.Add(s);
                        }
                        left++;
                        right--;
                    }
                    else if (tmp < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return res;
        }

        /// <summary>
        /// Given an array S of n integers, find three integers in S such that the sum is closest to a given number, target. 
        /// Return the sum of the three integers. You may assume that each input would have exactly one solution.
        /// 
        /// Question need to ask.
        /// 1. does the array contains dup?
        /// 2. if there is more than one set of number has closed value, which on I should return?
        /// 
        /// normally if the question is find "THE ....." then ask if there is dup which one should return.
        /// if the question is find "ALL ...." then ask if dup is allowed in the dup? what does dup mean? if set contains same 
        /// elements but different order does that conaidered as dup?
        /// </summary>
        /// <param name="input">the array</param>
        /// <param name="value">target value</param>
        /// <returns>the list of integers</returns>
        public List<int> FindClosest3Sum(int[] input, int value)
        {
            if (input.Length < 3) return new List<int>();
            List<int> res = new List<int>();
            int minDistance = int.MaxValue;

            for (int i = 0; i < input.Length - 2; i++)
            {
                int left = i + 1;
                int right = input.Length - 1;
                while (left < right)
                {
                    int tmp = input[i] + input[left] + input[right] - value;
                    if (tmp == 0)
                    {
                        return new List<int>() { input[i], input[left], input[right] };
                    }
                    else if (Math.Abs(tmp) < minDistance)
                    {
                        res = new List<int>() { input[i], input[left], input[right] };
                        minDistance = Math.Abs(tmp);
                    }

                    if (tmp < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return res;
        }

        /*
         * Given an array S of n integers, are there elements a, b, c, and d in S such that a + b + c + d = target? Find all 
         * unique quadruplets in the array which gives the sum of target.
 
            Note:
            •Elements in a quadruplet (a,b,c,d) must be in non-descending order. (ie, a ≤ b ≤ c ≤ d)
            •The solution set must not contain duplicate quadruplets.
 
            For example, given array S = {1 0 -1 0 -2 2}, and target = 0.

            A solution set is:
            (-1,  0, 0, 1)
            (-2, -1, 1, 2)
            (-2,  0, 0, 2)
         */
        /// <summary>
        /// this method really does not have "ji shu han liang" O(n^3), brutal force.....
        /// there must be something smart out there. I should try to find it.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<List<int>> Find4Sum(int[] input)
        {
            if (input.Length < 4) return new List<List<int>>();
            Array.Sort(input);
            List<List<int>> res = new List<List<int>>();
            HashSet<string> tracker = new HashSet<string>();

            for (int i = 0; i < input.Length - 3; i++)
            {
                for (int j = i + 1; j < input.Length - 2; j++)
                {

                    int left = j + 1;
                    int right = input.Length - 1;
                    while (left < right)
                    {
                        int tmp = input[i] + input[j]  + input[left] + input[right];
                        if (tmp == 0)
                        {
                            string s = input[i].ToString() + "," + input[j].ToString() + "," + input[left].ToString() + "," + input[right].ToString();
                            if (!tracker.Contains(s))
                            {
                                res.Add(new List<int>() { input[i], input[j], input[left], input[right] });
                                tracker.Add(s);
                            }
                            left++;
                            right--;
                        }
                        else if (tmp < 0)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }
            }
            return res;
        }
    }
}
