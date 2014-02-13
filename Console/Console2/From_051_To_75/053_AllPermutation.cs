using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_051_To_75
{
    public class _053_AllPermutation
    {
        /*
        Given a collection of numbers, return all possible permutations. 
        For example,
         [1,2,3] have the following permutations:
         [1,2,3], [1,3,2], [2,1,3], [2,3,1], [3,1,2], and [3,2,1]. 
         */
        /*
         * This method should also work for the input which has dups.
        Given a collection of numbers that might contain duplicates, return all possible unique permutations.
 
        For example,
         [1,1,2] have the following unique permutations:
         [1,1,2], [1,2,1], and [2,1,1]. 

         */
        public List<int[]> GetAllPermutation(int[] input)
        {
            List<int[]> res = new List<int[]>();
            GetAllPermutationWorker(input, 0, res);
            return res;
        }

        public void GetAllPermutationWorker(int[] input, int k, List<int[]> res)
        {
            if (k == input.Length)
            {
                int[] tmp = new int[input.Length];
                input.CopyTo(tmp, 0);
                res.Add(tmp);
            }
            else
            {
                for (int i = k; i < input.Length; i++)
                {
                    if (i == k || input[i] != input[k])
                    {
                        Swap(input, i, k);
                        GetAllPermutationWorker(input, k + 1, res);
                        Swap(input, i, k);
                    }
                }
            }
        }


        private void Swap(int[] input, int i, int j)
        {
            int tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }


        /*
         * Now the same question can I try DP method?
         */
        /// <summary>
        /// using List<int> as input to manuplate the code better.
        /// For DP I can not figure out a GOOD way to exclude the dups
        /// except I can use hasset to save the result. but this is not
        /// very elegant.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<List<int>> GetAllPermutationDP(List<int> input)
        {
            List<List<int>> res = new List<List<int>>();
            List<List<int>> tmp = new List<List<int>>();
            tmp.Add(new List<int>() {input[0]});

            
            for (int i = 1; i < input.Count; i++)
            {
                for (int j = 0; j < tmp.Count; j++)
                {
                    for (int k= 0; k < tmp[j].Count; k++)
                    {
                        List<int> list = new List<int>(tmp[j]);
                        list.Insert(k, input[i]);
                        res.Add(list);
                    }
                    List<int> lastList = new List<int>(tmp[j]);
                    lastList.Add(input[i]);
                    res.Add(lastList);
                }
                tmp = res;
                res = new List<List<int>>();
            }
            return tmp;
        }
    }
}
