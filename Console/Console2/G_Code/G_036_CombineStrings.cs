using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_036_CombineStrings
    {
        /*
         * 一个数组a1; a2; a3 : : : an; b1; b2; b3 : : : bn, 怎么in place地转化成a1; b1; a2; b2; a3; b3 : : : an; bn.
         */
        public void InPlace(int[] input, int start, int end)
        {
            if (end - start <= 2)
            {
                return;
            }
            else if (end - start == 3)
            {
                Swap(input, start + 1, start + 2);
            }
            else
            {
                // the following code still have bugs.
                int length = end - start + 1;
                int halfLength = length / 2;
                int quarterLength = length / 4;
                Reverse(input, start + quarterLength + 1, start + quarterLength + 1 + halfLength);
                Reverse(input, start + quarterLength + 1, start + halfLength + 1);
                Reverse(input, halfLength + 2, start + quarterLength + 1 + halfLength);
                InPlace(input, start, start + halfLength);
                InPlace(input, start + halfLength + 1, end);
            }
        }

        public void Swap(int[] input, int i, int j)
        {
            int tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }

        public void Reverse(int[] input, int i, int j)
        {
            while (i <= j)
            {
                Swap(input, i, j);
                i++;
                j--;
            }
        }


    }
}
