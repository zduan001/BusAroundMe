using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.cs
{
    public class _013_SeparatorPositiveandNegative
    {
        /*
         * an array has possitive and negative number. spearate them.
         * 
         */
        public void Separate(int[] input)
        {
            // validation
            if (input == null) return;
            if (input.Length < 1) return;
            int left = 0;
            int right = input.Length-1;
            while (left <= right)
            {
                int a = left;
                while (input[a] <= 0) a++;

                int b = right;
                while (input[b] > 0) b--;

                int tmp = input[a];
                input[a] = input[b];
                input[b] = tmp;

                left = a + 1;
                right = b - 1;

            }
        }
    }
}
