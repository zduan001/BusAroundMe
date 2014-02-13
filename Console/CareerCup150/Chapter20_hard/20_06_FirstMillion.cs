using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter20_hard
{
    class _20_06_FirstMillion
    {
        /*
         * Describe an algorithm to find the largest 1 million numbers in 1 billion numbers. Assume that the computer memory can hold all one billion numbers.
         */
        /*
         * Approach 1: Sorting
        Sort the elements and then take the first million numbers from that. Complexity is O(n log n).
         * 
         * 
        Approach 2: Max Heap
        1. Create a Min Heap with the first million numbers.
        2. For each remaining number, insert it in the Min Heap and then delete the minimum value from the heap.
        3. The heap now contains the largest million numbers.
        4. This algorithm is O(n log m), where m is the number of values we are looking for.
         * 
         * 
        Approach 3: Selection Rank Algorithm (if you can modify the original array)
        Selection Rank is a well known algorithm in computer science to find the ith smallest (or largest) element in an array in expected linear time. The basic algorithm for finding the ith smallest elements goes like this:
        »»Pick a random element in the array and use it as a ‘pivot’. Move all elements smaller than that element to one side of the array, and all elements larger to the other side.
        »»If there are exactly i elements on the right, then you just find the smallest element on that side.
        »»Otherwise, if the right side is bigger than i, repeat the algorithm on the right. If the right side is smaller than i, repeat the algorithm on the left for i – right.size().
        Given this algorithm, you can either:
        »»Tweak it to use the existing partitions to find the largest i elements (where i = one million).
        »»Or, once you find the ith largest element, run through the array again to return all elements greater than or equal to it.
        This algorithm has expected O(n) time.
         */
    }
}
