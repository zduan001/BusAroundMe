using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_076_To_100
{
    public class _077_Subset
    {
        /*
         * Given a set of distinct integers, S, return all possible subsets. 

            Note:
 
            •Elements in a subset must be in non-descending order.
             •The solution set must not contain duplicate subsets.
 

            For example,
             If S = [1,2,3], a solution is: 
            [
              [3],
              [1],
              [2],
              [1,2,3],
              [1,3],
              [2,3],
              [1,2],
              []
            ]

         */
        public List<int[]> FindAllSubSet(int[] input)
        {
            bool[] tracker = new bool[input.Length];
            List<int[]> res = new List<int[]>();
            Worker(input, tracker, res, 0);
            return res;
        }

        public void Worker(int[] input, bool[] tracker, List<int[]> res, int k)
        {
            if (k == input.Length)
            {
                List<int> tmp = new List<int>();
                for (int i = 0; i < tracker.Length; i++)
                {
                    if (tracker[i])
                    {
                        tmp.Add(input[i]);
                    }
                }
                int[] a = new int[tmp.Count];
                tmp.CopyTo(a);
                res.Add(a);
            }
            else
            {
                Worker(input, tracker, res, k + 1);
                tracker[k] = true;
                Worker(input, tracker, res, k + 1);
                tracker[k] = false;
            }
        }

        /// <summary>
        /// Another method to find all sub set.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<List<int>> FindAllSubSet(List<int> input)
        {
            List<List<int>> res = new List<List<int>>();
            res.Add(new List<int>());

            for (int i = 0; i < input.Count; i++)
            {
                int prev_Count = res.Count;
                for (int j = 0; j < prev_Count; j++)
                {
                    List<int> tmp = new List<int>(res[j]);
                    tmp.Add(input[i]);
                    res.Add(tmp);
                }
            }
            return res;
        }

        /*
         * Given a collection of integers that might contain duplicates, S, return all possible subsets.
            Note:
            •Elements in a subset must be in non-descending order.
             •The solution set must not contain duplicate subsets.
            For example,
             If S = [1,2,2], a solution is: 
            [
              [2],
              [1],
              [1,2,2],
              [2,2],
              [1,2],
              []
            ]

         */
        /// <summary>
        /// I can first de dup the array, but this may not be the ideal, 
        /// I can also sort the array. then when I am recursive call Worker
        /// I check if intput[k] == input[k-1] if true, I only do one call with true.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<List<int>> FindAllSubSetWithDup(List<int> input)
        {
            List<List<int>> res = new List<List<int>>();
            res.Add(new List<int>());

            int start = 0;
            for (int i = 0; i < input.Count; i++)
            {
                int prev_Count = res.Count;
                for (int j = start; j < prev_Count; j++)
                {
                    List<int> tmp = new List<int>(res[j]);
                    tmp.Add(input[i]);
                    res.Add(tmp);
                }
                if(i<input.Count-1 && input[i] == input[i+1])
                {
                    start = prev_Count;
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
