using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_1_29_FindEqualKey
    {
        /*
         * Equal keys. Add to BinarySearch a static method rank() that takes a key and a sorted 
         * array of int values (some of which may be equal) as arguments and returns the number 
         * of elements that are smaller than the key and a similar method count() that returns 
         * the number of elements equal to the key. Note : If i and j are the values returned by 
         * rank (key, a) and count(key, a) respectively, then a[i..i+j-1 ] are the values in the 
         * array that are equal to key .
         */
        public void FindStartAndLength(int[] input, int value, ref int startIndex, ref int length)
        {
            int left = 0;
            int right = input.Length;
            int mid = -1;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (input[mid] == value)
                {
                    break;
                }
                else if (input[mid] < value)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }


            //find left start index;
            int leftstart = -1;
            left = 0;
            right = mid;
            while (left <= right)
            {
                leftstart = (left + right) / 2;
                if (leftstart == 0 && input[leftstart] == value)
                {
                    break;
                }

                if (input[leftstart] == value)
                {
                    if (input[leftstart] > input[leftstart - 1])
                    {
                        break;
                    }
                    else
                    {
                        right = leftstart - 1;
                    }
                }
                else
                {
                    left = leftstart + 1;
                }
            }

            // find right index
            int rightEnd = -1;
            left = mid + 1;
            right = input.Length - 1;
            while (left <= right)
            {
                rightEnd = (left + right) / 2;
                if (rightEnd == input.Length - 1 && input[rightEnd] == value)
                {
                    break;
                }
                if (input[rightEnd] > value)
                {
                    if (input[rightEnd - 1] == value && input[rightEnd] > input[rightEnd - 1])
                    {
                        rightEnd--;
                        break;
                    }
                    else
                    {
                        right = rightEnd - 1;
                    }
                }
                else
                {
                    left = rightEnd + 1;
                }
            }

            startIndex = leftstart;
            length = rightEnd - leftstart + 1;

        }
    }
}
