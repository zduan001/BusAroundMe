using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleQuestions
{
    public class _003_MixArray
    {
        /*
         * 一个数组a1; a2; a3 : : : an; b1; b2; b3 : : : bn, 怎么in place地转化成a1; b1; a2; b2; a3; b3 : : : an; bn
         */
        /*
         * the following solution is O(n^2) this is nice solution, but can we do better? assume requirement is inplace.
         */
        public void MixArray(int[] input)
        {
            int n = input.Length;
            if (n % 2 != 0) throw new ArgumentException();
            n = n / 2;
            int i = 1;
            while (i<input.Length-1)
            {
                MirrorArray(input, i, n);
                MirrorArray(input, i + 1, n - 1);
                i = i + 2;
                n = n - 1;
            }
        }

        public void MirrorArray(int[] input, int startIndex, int length)
        {
            int left = startIndex;
            int right = startIndex + length - 1;
            while (left <= right)
            {
                int tmp = input[left];
                input[left] = input[right];
                input[right] = tmp;
                left++;
                right--;
            }
        }
    }
}
