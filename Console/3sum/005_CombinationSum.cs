using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _005_CombinationSum
    {
        /// <summary>
        /// Given a set of candidate numbers (C) and a target number (T), find all unique 
        /// combinations in C where the candidate numbers sums to T.
        /// The same repeated number may be chosen from C unlimited number of times.
        /// </summary>
        /// <param name="array"></param>
        public List<List<int>> FindCombinationSum(int[] array, int target)
        {
            Dictionary<int, List<List<int>>> result = new Dictionary<int, List<List<int>>>();

            Array.Sort(array);

            for (int k = 0; k <= target; k++)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (k < array[i])
                    {
                        continue;
                    }
                    if (k == array[i])
                    {
                        List<int> tmp = new List<int> { array[i] };
                        if (result.ContainsKey(k))
                        { result[k].Add(tmp); }
                        else
                        { result.Add(k, new List<List<int>>() { tmp }); }
                    }
                    else
                    {
                        if (result.ContainsKey(k - array[i]))
                        {
                            List<List<int>> kthList = new List<List<int>>();
                            foreach (List<int> list in result[k - array[i]])
                            {
                                if (array[i] < list.Last())
                                {
                                    continue; // make sure only new combination is going to be added.
                                }
                                List<int> tmp = new List<int>();
                                tmp.AddRange(list);
                                tmp.Add(array[i]);
                                kthList.Add(tmp);
                            }

                            if (result.ContainsKey(k))
                            {
                                result[k].AddRange(kthList);
                            }
                            else
                            {
                                result[k] = kthList;
                            }
                        }
                    }
                }
            }

            if (result.ContainsKey(target))
            {
                return result[target];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Given a set of candidate numbers (C) and a target number (T), find all unique 
        /// combinations in C where the candidate numbers sums to T.
        /// The same repeated number may be used ONLY once.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        public List<List<int>> FindCombinationSumWithUnique(int[] array, int target)
        {
            Dictionary<int, List<List<int>>> result = new Dictionary<int, List<List<int>>>();

            Array.Sort(array);

            for (int k = 0; k <= target; k++)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (k < array[i])
                    {
                        continue;
                    }
                    if (k == array[i])
                    {
                        List<int> tmp = new List<int> { i };
                        if (result.ContainsKey(k))
                        {
                            result[k].Add(tmp);
                        }
                        else
                        {
                            result.Add(k, new List<List<int>>() { tmp });
                        }
                    }
                    else
                    {
                        if (result.ContainsKey(k - array[i]))
                        {
                            List<List<int>> kthList = new List<List<int>>();
                            foreach (List<int> list in result[k - array[i]])
                            {
                                // Since the list contains the index of the value. 
                                // check to see if the index is already included 
                                // if the index is already include just skip.
                                if (list.Contains(i) || i <= list.Last())
                                {
                                    continue;
                                }
                                List<int> tmp = new List<int>();
                                tmp.AddRange(list);
                                tmp.Add(i);
                                kthList.Add(tmp);
                            }

                            if (result.ContainsKey(k))
                            {
                                result[k].AddRange(kthList);
                            }
                            else
                            {
                                result[k] = kthList;
                            }
                        }
                    }
                }
            }

            if (result.ContainsKey(target))
            {
                HashSet<string> hashSet = new HashSet<string>();
                List<List<int>> valueResult = new List<List<int>>();
                foreach (List<int> list in result[target])
                {
                    List<int> tmp = new List<int>();
                    StringBuilder sb = new StringBuilder();
                    foreach (int i in list)
                    {
                        tmp.Add(array[i]);
                        sb.Append(array[i].ToString());
                    }

                    // hashset make sure same group won't be
                    // able to insert twice.
                    if (!hashSet.Contains(sb.ToString()))
                    {
                        hashSet.Add(sb.ToString());
                        valueResult.Add(tmp);
                    }
                }
                return valueResult;
            }
            else
            {
                return null;
            }
        }
    }
}
