using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _066_TwoSum
    {
        /// <summary>
        /// Given an array of integers, find two numbers such that they add up to a specific target number.
        /// The function twoSum should return indices of the two numbers such that they add up to the target, 
        /// where index1 must be less than index2. Please note that your returned answers (both index1 and index2) are not zero-based.
        /// You may assume that each input would have exactly one solution.
        /// Input: numbers={2, 7, 11, 15}, target=9
        /// Output: index1=1, index2=2
        /// 
        /// HashTable?????
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<int> TwoSum(List<int> numbers, int value)
        {
            Dictionary<int, int> set = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (!set.ContainsKey(value - numbers[i]))
                    set.Add(numbers[i], i);
                else
                {
                    return new List<int>() { i, set[value - numbers[i]] };
                }
            }

            return null;
        }
    }
}
