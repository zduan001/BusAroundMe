using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConque
{
    public class TopKElement
    {
        /*
         * give an integer array find top k largest element.
         */
        public void FindTopK(int[] input, int k)
        {
            int pivot = 0;
            int left = 0;
            int right = input.Length - 1;

            Random ran = new Random();
            

            while (true)
            {
                Swap(input, pivot, ran.Next(pivot, right));
                while (left <= right)
                {
                    while (left < right && input[left] >= input[pivot] )
                        left++;
                    while (right > left && input[right] <= input[pivot])
                        right--;

                    Swap(input, left, right);
                    left++;
                    right--;
                }

                if (right + 1 == k) return;
                else
                {
                    Swap(input, pivot, right);
                    if (right < k)
                    {
                        pivot = left;
                        left = pivot;
                        right = input.Length - 1;
                    }
                    else
                    {
                        right = left >=input.Length-1? input.Length-1: left;
                        left = 0;
                        pivot = 0;
                        
                    }
                }
            }
        }

        private void Swap(int[] input, int i, int j)
        {
            // check array size and indices ..
            int tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }
    }
}
