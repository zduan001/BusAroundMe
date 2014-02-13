using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _047_SortColor
    {
        /// <summary>
        /// Given an array with n objects colored red, white or blue, sort them so that objects of the same color are adjacent, with the colors in the order red, white and blue.
        /// Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.
        /// Note:
        /// You are not suppose to use the library's sort function for this problem.
        /// Follow up:
        /// A rather straight forward solution is a two-pass algorithm using counting sort.
        /// First, iterate the array counting number of 0's, 1's, and 2's, then overwrite array with total number of 0's, then 1's and followed by 2's.
        /// Could you come up with an one-pass algorithm using only constant space?
        /// 代码分析：
        /// 　　只撸一遍的做法，做三个指针， l， r， k， k顺序往前走，碰到0， Swap(A[k++], A[l++]), 
        /// 　　碰到1不管，碰到2， Swap（A[k], A[r--]), 因为前面的数肯定不会是2， 所有k可以++，但是后面的数有可能是0, 
        /// 　　交换后，还有跟前面交换，所以k不能++。
        /// </summary>
        /// <param name="input"></param>
        public void SortColorWithOnePass(int[] input)
        {
            int zeroTail = 0;
            int twoHead = input.Length - 1;
            int index = 0;

            while (input[zeroTail] == 0)
            {
                zeroTail++;
            }
            zeroTail--;
            while (input[twoHead] == 2)
            {
                twoHead--;
            }
            twoHead++;
            index = zeroTail+1;


            while (index < twoHead)
            {
                if (input[index] == 0)
                {
                    swap(input, zeroTail+1, index);
                    zeroTail++;
                    index++;// since and 2 before index should already been moved away, index can ++ here to save one round of while.
                }
                else if (input[index] == 2)
                {
                    swap(input, index, twoHead-1);
                    twoHead--;
                }
                else
                {
                    index++;
                }
            }
        }

        private void swap(int[] input, int i, int j)
        {
            int tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }
    }
}
