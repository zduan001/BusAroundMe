using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// Find all the set of 3 numbers which are added to 0.
        /// </summary>
        /// <param name="inputArray">the input array.</param>
        /// <returns>the set of list of integers.</returns>
        public static HashSet<List<int>> Find3Sum(int[] inputArray)
        {
            HashSet<List<int>> ret = new HashSet<List<int>>();

            Dictionary<string, List<int>> retDic = new Dictionary<string, List<int>>();
            Array.Sort(inputArray);

            for (int i = 0; i < inputArray.Length - 2; i++)
            {
                int start = i + 1;
                int end = inputArray.Length - 1;

                while (start < end)
                {
                    if (inputArray[i] + inputArray[start] + inputArray[end] == 0)
                    {
                        List<int> list = new List<int>() { inputArray[i], inputArray[start], inputArray[end] };
                        string key = inputArray[i].ToString() + "," + inputArray[start].ToString() + "," + inputArray[end].ToString();
                        if (!retDic.ContainsKey(key))
                        {
                            retDic.Add(key, list);
                        }
                        start++;
                    }
                    else
                    {
                        if (inputArray[i] + inputArray[start] + inputArray[end] < 0)
                        {
                            start++;
                        }
                        else
                        {
                            end--;
                        }
                    }
                }
            }
            foreach (List<int> list in retDic.Values)
            {
                ret.Add(list);
            }
            return ret;
        }

        /// <summary>
        /// Given an array S of n integers, find three integers in S such that the sum is closest to a given number, target. 
        /// Return the sum of the three integers. You may assume that each input would have exactly one solution.
        /// </summary>
        /// <param name="inputArray">the array</param>
        /// <param name="value">target value</param>
        /// <returns>the list of integers</returns>
        public static List<int> FindClosest3Sum(int[] inputArray, int value)
        {
            int maxDifference = int.MaxValue;
            List<int> ret = new List<int>();

            Array.Sort(inputArray);

            for (int i = 0; i < inputArray.Length - 2; i++)
            {
                int start = i + 1;
                int end = inputArray.Length - 1;
                while (start < end)
                {
                    if (Math.Abs(value - inputArray[i] - inputArray[start] - inputArray[end]) < maxDifference)
                    {
                        ret = new List<int>() { inputArray[i], inputArray[start], inputArray[end] };
                        maxDifference = Math.Abs(value - inputArray[i] - inputArray[start] - inputArray[end]);
                    }

                    if ((inputArray[i] + inputArray[start] + inputArray[end]) < value)
                    {
                        start++;
                    }
                    else if ((inputArray[i] + inputArray[start] + inputArray[end]) > value)
                    {
                        end--;
                    }
                    else
                    {
                        return ret;
                    }
                }
            }

            return ret;
        }
    }
}
