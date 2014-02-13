using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_016_SeparateArray
    {
        /*
         * 利用快速排序的划分方法，把数组分成三部分，< val, = val, > val。
         */
        public void SeparateArray(int[] input, int value)
        {
            int left = 0;
            int right = input.Length - 1;
            while (left < right)
            {
                while (left <input.Length && input[left] < value) left++;
                while (right > 0 && input[right] >= value) right--;
                Swap(input, left, right);
                left++;
                right--;
            }

            right = input.Length - 1;
            while (left < right)
            {
                while (input[left] == value) left++;
                while(input[right] > value) right --;
                Swap(input, left, right);
                left++;
                right --;
            }

        }

        public void Swap(int[] input, int i, int j)
        {
            int tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }
    }
}
