using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_026_To_050
{
    public class _032_FindMedianOf2Array
    {
        /*
        There are two sorted arrays A and B of size m and n respectively. 
        Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).
        */
        public int FindMedian(int[] a1, int[] a2)
        {
            int[] input = new int[a1.Length + a2.Length];
            for (int i = 0; i < a1.Length; i++)
            {
                input[i] = a1[i];
            }
            for (int i = 0; i < a2.Length; i++)
            {
                input[a1.Length + i] = a2[i];
            }
            int res = FindKth(input, 0, input.Length-1, input.Length / 2);
            return res;
        }

        public int FindKth(int[] input, int left, int right, int k)
        {
            int start = left;
            int end = right;
            while (start < end)
            {
                while (input[start] <= input[left] && start < end) start++;
                while (input[end] >= input[left] && end > start) end--;
                Swap(input, start, end);

            }
            if (start - 1 == k)
            {
                return input[start - 1];
            }
            else if (k > start - 1)
            {
                return FindKth(input, start, right, k);

            }
            else
            {
                return FindKth(input, left, start - 1, k);
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
