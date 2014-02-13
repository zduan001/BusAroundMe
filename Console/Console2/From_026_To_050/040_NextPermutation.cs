using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_026_To_050
{
    public class _040_NextPermutation
    {
        /*
        Implement next permutation, which rearranges numbers into the lexicographically next greater permutation of numbers.
        If such arrangement is not possible, it must rearrange it as the lowest possible order (ie, sorted in ascending order).
        The replacement must be in-place, do not allocate extra memory.
 
        Here are some examples. Inputs are in the left-hand column and its corresponding outputs are in the right-hand column.
        1,2,3 → 1,3,2
        3,2,1 → 1,2,3
        1,1,5 → 1,5,1

         */
        /*
        * 代码分析：
        O(n)， 其实也是BF而已，主要是找到做的方法。
        分三步：
        1. 从后往前找falling edge，下降沿。（下降之后的那个元素）
        2. 从下降沿开始往后找出替换它的元素。（就是第一个比它小的前一个元素）
        3. 反转后面所有元素，让他从小到大sorted（因为之前是从大到小sorted的）
        例如 “547532“
        1. “547532”， 4是下降沿。
        2. “547532”， 5是要替换的元素， 替换后得到 “ 557432”
        3. "557432",   7432反转，得到 “552347”。
         */
        /// <summary>
        /// First thought is: sort s and do a all permutation output and compare to the original s if yes, get the next one.
        /// but on second thought, it seem like I can scane from back of the string. if I see the first s[i] > s[i-1], swap it 
        /// then I got the next permutation. if I can not find one in whole string. I will reverse the whole string...
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string NextPermutation(string s)
        {
            char[] cArray = s.ToCharArray();
            bool found = false;
            int leftIndex = -1;
            int rightIndex   = -1;
            for (int i = cArray.Length - 1; i > 0; i--)
            {
                if (cArray[i] > cArray[i - 1])
                {
                    leftIndex = i - 1;
                    found = true;
                    break;
                }

            }

            if (found)
            {
                for (int i = leftIndex; i < cArray.Length; i++)
                {
                    if (cArray[i] < cArray[leftIndex])
                    {
                        rightIndex = i - 1;
                    }
                }

                if (rightIndex != -1)
                {
                    Swap(cArray, leftIndex, rightIndex-1);
                    int left = leftIndex + 1;
                    int right = cArray.Length - 1;
                    while (left < right)
                    {
                        Swap(cArray, left, right);
                        left++;
                        right--;
                    }
                }
                else
                {
                    Swap(cArray,leftIndex, leftIndex+1);
                }

            }

            if (!found)
            {
                int left = 0;
                int right = cArray.Length - 1;
                while (left < right)
                {
                    char tmp = cArray[left];
                    cArray[left] = cArray[right];
                    cArray[right] = tmp;
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cArray.Length; i++)
            {
                sb.Append(cArray[i].ToString());
            }
            return sb.ToString();
        }

        private void Swap(char[] input, int i, int j)
        {
            char tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }
    }
}
