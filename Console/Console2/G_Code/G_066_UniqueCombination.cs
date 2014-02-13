using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_066_UniqueCombination
    {
        /*
         * 四位数字_ _ _ _ ，要求填写这四位数，满足每位数字都是unique，而且前两位+ 后两位的和为100， 比如2 4 7 6， 问有多少种组合。
         */
        public int UniqueCombination()
        {
            int[] tracker = new int[10];
            for(int i = 0;i< 10;i++)
            {
                tracker[i] = i;
            }
            int count = 0;
            Worker(tracker, 0, 4, ref count);
            return count;
        }

        public void Worker(int[] input, int k, int cap, ref int count)
        {
            if (k == cap)
            {
                if (Verify(input))
                    count++;
            }
            else
            {
                for (int i = k; i < input.Length; i++)
                {
                    Swap(input, i, k);
                    Worker(input, k + 1, cap, ref count);
                    Swap(input, i, k);

                }
            }

        }

        private bool Verify(int[] input)
        {
            int left = input[1] + input[0] * 10;
            int right = input[3] + input[2] * 10;
            if (left + right == 100) return true;
            else
                return false;
        }

        private void Swap(int[] input, int i, int j)
        {
            int tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }
    }
}
