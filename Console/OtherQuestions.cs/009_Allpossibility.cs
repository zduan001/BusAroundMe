using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.cs
{
    public class _009_Allpossibility
    {
        /*
         * http://www.mitbbs.com/article_t/JobHunting/32088539.html
         * Write a function that takes an array of five integers, each of which is between 1 and 10, and returns 
         * the number of combination of those integers that sum to 15. For example, calling the function with the 
         * array [1, 2, 3, 4, 5] should return 1, while calling it with [5, 5, 10, 2, 3] should return 4 
         * (5 + 10, 5 + 10, 5 + 5 + 2 + 3, 10 + 2 + 3).
         */
        public List<List<int>> AllSum(int[] input, int targetValue)
        {
            List<int> tracker = new List<int>();
            List<List<int>> res = new List<List<int>>();

            Worker(input, 0, tracker, res, targetValue);
            return res;
        }

        public void Worker(int[] input, int k, List<int> tracker, List<List<int>> res, int targetValue)
        {
            if (tracker == null) throw new ArgumentException();
            if (res == null) throw new ArgumentException();
            int tmp = 0;

            foreach (int i in tracker)
            {
                tmp += i;
            }
            if (tmp == targetValue)
            {
                List<int> abc = new List<int>(tracker);
                res.Add(abc);
                return;
            }
            for (int i = k; i < input.Length; i++)
            {
                tracker.Add(input[i]);
                Worker(input, i + 1, tracker, res, targetValue);
                tracker.Remove(input[i]);
            }
        }

        /// <summary>
        /// for DP solution I think the problem is how to back track all the solution....
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="targetValue"></param>
        public List<List<int>> AllSumDP(int[] input, int targetValue)
        {
            targetValue++;
            List<List<int>>[,] res = new List<List<int>>[input.Length, targetValue];
            // I could initial i = 0, but I also can put it in main loop,.

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < targetValue; j++)
                {
                    List<List<int>> tmp = new List<List<int>>();

                    // if the current element can be a solution
                    // add it as a new solution.
                    if (j == input[i])
                    {
                        tmp.Add(new List<int>() { input[i] });
                    }

                    // if there are solution with out current solution 
                    // add the current value in to the solution become
                    // new solution. 
                    if (i >= 1 && j - input[i] > 0)
                    {
                        if (res[i - 1, j - input[i]]!= null)
                        {
                            foreach (List<int> list in res[i - 1, j - input[i]])
                            {
                                List<int> x = new List<int>(list);
                                x.Add(input[i]);
                                tmp.Add(new List<int>(x));
                            }
                        }
                    }

                    // if there are solutions use less element, copy it up.
                    if (i >= 1 && res[i - 1, j] != null)
                    {
                        foreach (List<int> list in res[i - 1, j])
                        {
                            List<int> x = new List<int>(list);
                            tmp.Add(x);
                        }
                    }

                    if (tmp!= null && tmp.Count != 0)
                    {
                        res[i, j] = tmp;
                    }
                    #region 

                    //if (input[i] == j)
                    //{
                    //    List<int> tmp = new List<int>() { input[i] };
                    //    res[i, j] = new List<List<int>>() { tmp };
                    //}
                    //else
                    //{
                    //    int v = j - input[i];
                    //    List<List<int>> tmp = null;
                    //    if (v >= 0 && i >= 1)
                    //    {
                    //        tmp = res[i - 1, v];
                    //    }
                    //    if (tmp != null)
                    //    {
                    //        res[i, j] = new List<List<int>>();
                    //        foreach (List<int> list in tmp)
                    //        {
                    //            List<int> x = new List<int>(list);
                    //            x.Add(input[i]);
                    //            res[i, j].Add(new List<int>(x));
                    //        }
                    //    }
                    //}
                    //if (i >= 1)
                    //{
                    //    List<List<int>> pre = res[i - 1, j];
                    //    if (pre != null)
                    //    {
                    //        if (res[i, j] == null)
                    //        {
                    //            res[i, j] = new List<List<int>>();
                    //        }
                    //        foreach (List<int> list in pre)
                    //        {
                    //            res[i, j].Add(new List<int>(list));
                    //        }
                    //    }
                    //}
                    #endregion
                }
            }

            return res[input.Length - 1, targetValue - 1];

        }


        /// <summary>
        /// Same DP mathod, but this method use a 1-D array to track the DP 
        /// the trick is, everytime update the tracker array, it has to start
        /// from the end of the array and move forward.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="targetValue"></param>
        /// <returns></returns>
        public List<List<int>> AllSumDPOneArray(int[] input, int targetValue)
        {
            targetValue++;
            List<List<int>>[] res = new List<List<int>>[targetValue];
            for (int i = 0; i< input.Length;i++)
            {
                for (int j = targetValue-1; j > 0  ; j--)
                {
                    // get the solutions with out current input[i]. 
                    // if there are any.
                    List<List<int>> tmp = res[j];
                    if (tmp == null)
                    {
                        tmp = new List<List<int>>();
                    }

                    // if current element is the solution 
                    // add it.
                    if (input[i] == j)
                    {
                        tmp.Add(new List<int>() { input[i] });
                    }

                    // if there are smaller solution. use them
                    // add current node to form new solution.
                    if(j-input[i] >=1)
                    {
                        List<List<int>> prev = res[j - input[i]];
                        if (prev != null)
                        {
                            foreach (List<int> list in prev)
                            {
                                List<int> x = new List<int>(list);
                                x.Add(input[i]);
                                tmp.Add(new List<int>(x));
                            }
                        }
                    }

                    if (tmp.Count != 0)
                    {
                        res[j] = tmp;
                    }
                }
            }
            return res[targetValue - 1];
        }
    }
}
