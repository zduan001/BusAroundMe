using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleQuestions
{
    public class PartitionArray
    {
        /*http://www.mitbbs.com/article_t/JobHunting/32226949.html
         * Partition a set of numbers into two such that difference between their sum
         * is minimum, and both sets have equal number of elements.
         * For example: {1, 4, 9, 16} is partitioned as {1,16} and {4,9} with diff =
         * 17-13=4.
         */
        public int EquallyPartitionArray(int[] input)
        {
            if (input.Length % 2 != 0) return -1;
            int[,] res = new int[input.Length/2, input.Length];
            int sum = 0;
            for(int i = 0;i< input.Length ;i++)
            {
                sum += input[i];
            }
            sum = sum /2;

            for (int i = 0; i < input.Length; i++)
            {
                res[0, i] = input[i];
            }
            
            for (int i = 1; i < input.Length / 2; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    int minDiff = int.MaxValue;
                    int minDiffIndex = -1;
                    for (int k = 0; k < j; k++)
                    {
                        if (Math.Abs(sum - (res[i - 1, k] + input[j])) < minDiff)
                        {
                            minDiff = Math.Abs(sum - (res[i - 1, k] + input[j]));
                            minDiffIndex = k;
                        }
                    }
                    res[i, j] = res[i - 1, minDiffIndex] + input[j];
                }
            }
            int tmp = Math.Abs(sum - res[input.Length / 2 - 1, input.Length - 1]) * 2;
            return tmp;
        }
    }
}
