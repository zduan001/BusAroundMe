using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Console2.G_Code
{
    public class G_051_PartitionASet
    {
        /*
        Partition a set of numbers into two such that dierence between their sum is
        minimum, and both sets have equal number of elements.
        For example: [1; 4; 9; 16] is partitioned as [1; 16] and [4; 9] with di: 17 􀀀 13 = 4.
         */
        /// <summary>
        /// Assume input size is even. I think the following code is working now
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public BitArray PartitionASet(List<int> input)
        {
            int n = input.Count;
            int left = 0;
            int right = 0;
            int k = 0;
            int minDiff = int.MaxValue;
            BitArray ba = new BitArray(input.Count);
            BitArray res = new BitArray(input.Count);
            Worker(input, ba, left, right, k, res, ref minDiff);
            return res;
        }

        public void Worker(List<int> input, BitArray ba, int left, int right, int k, BitArray res, ref int minDiff)
        {
            if ((left == input.Count / 2) && (right == input.Count / 2))
            {
                int tmp = FindDiff(input, ba);
                if (tmp < minDiff)
                {
                    for (int i = 0; i < ba.Length; i++)
                    {
                        res[i] = ba[i];
                    }
                    minDiff = tmp;
                }
                return;
            }
            else
            {
                if (k < input.Count)
                {
                    ba[k] = true;
                    Worker(input, ba, left + 1, right, k + 1, res, ref minDiff);
                    ba[k] = false;
                    Worker(input, ba, left, right + 1, k + 1, res, ref minDiff);
                }
            }
        }

        public int FindDiff(List<int> input, BitArray ba)
        {
            int leftTotal = 0;
            int rightTotal = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (ba[i])
                {
                    leftTotal += input[i];
                }
                else
                {
                    rightTotal += input[i];
                }
            }
            return Math.Abs(leftTotal - rightTotal);
        }
    }
}