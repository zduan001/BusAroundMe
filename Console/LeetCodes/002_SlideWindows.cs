using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class _002_SlideWindows
    {
        /*http://leetcode.com/2011/01/sliding-window-maximum.html
         * A long array A[] is given to you. There is a sliding window of size w which is moving from the very left of the array to the very right. You can only see the w numbers in the window. Each time the sliding window moves rightwards by one position. Following is an example:
        The array is [1 3 -1 -3 5 3 6 7], and w is 3.
        Window position                Max
        ---------------               -----
        [1  3  -1] -3  5  3  6  7       3
         1 [3  -1  -3] 5  3  6  7       3
         1  3 [-1  -3  5] 3  6  7       5
         1  3  -1 [-3  5  3] 6  7       5
         1  3  -1  -3 [5  3  6] 7       6
         1  3  -1  -3  5 [3  6  7]      7

        Input: A long array A[], and a window width w
        Output: An array B[], B[i] is the maximum value of from A[i] to A[i+w-1]
        Requirement: Find a good optimal way to get B[i]

         */
        public int[] FindSlideWindowsMax(int[] input, int k)
        {
            PriorityQueue<PairIndex> pq = new PriorityQueue<PairIndex>();
            int[] b = new int[input.Length - k + 1];
            for (int i = 0; i < k; i++)
            {
                pq.Enqueue(new PairIndex() { Value = input[i], Index = i });
            }

            for (int i = k; i < input.Length; i++)
            {
                PairIndex tmp = pq.Peek();
                b[i - k] = tmp.Value;
                while (tmp.Index < i - k)
                {
                    pq.Dequeue();
                    tmp = pq.Peek();
                }
                pq.Enqueue(new PairIndex() { Value = input[i], Index = i });
            }
            b[input.Length - k] = pq.Peek().Value;
            return b;
        }

        public int[] FindSlideWindowsMaxII(int[] input, int k)
        {
            if (input == null || input.Length == 0 || k < 1) return null;

            int[] b = new int[input.Length - k + 1];
            Deque<PairIndex> dq = new Deque<PairIndex>();
            for (int i = 0; i < k; i++)
            {
                if (dq.IsEmpty() || input[i] > dq.PeekFront().Value)
                {
                    dq.PushFront(new PairIndex() { Value = input[i], Index = i });
                }
            }

            for (int i = k; i < input.Length; i++)
            {
                b[i - k] = dq.PeekFront().Value;
                if (dq.IsEmpty() || input[i] > dq.PeekFront().Value)
                {
                    dq.PushFront(new PairIndex() { Value = input[i], Index = i });
                    if (dq.PeekFront().Index < i - k) dq.PopBack();
                }
            }
            b[input.Length - k] = dq.PopFront().Value;

            return b;
        }


    }

    public class PairIndex : IComparable
    {
        public int Value { get; set; }
        public int Index { get; set; }

        public int CompareTo(object obj)
        {
            PairIndex input = (PairIndex)obj;
            if (Value > input.Value) return -11;
            if (Value == input.Value) return 0;
            if (Value < input.Value) return 1;
            return 0;
        }
    }

    public class PriorityQueue<T> where T : IComparable
    {
        private List<T> data;

        public PriorityQueue()
        {
            this.data = new List<T>();
        }

        public void Enqueue(T item)
        {
            data.Add(item);
            int ci = data.Count - 1; // child index; start at end
            while (ci > 0)
            {
                int pi = (ci - 1) / 2; // parent index
                if (data[ci].CompareTo(data[pi]) >= 0) break; // child item is larger than (or equal) parent so we're done
                T tmp = data[ci]; data[ci] = data[pi]; data[pi] = tmp;
                ci = pi;
            }
        }

        public T Dequeue()
        {
            // assumes pq is not empty; up to calling code
            int li = data.Count - 1; // last index (before removal)
            T frontItem = data[0];   // fetch the front
            data[0] = data[li];
            data.RemoveAt(li);

            --li; // last index (after removal)
            int pi = 0; // parent index. start at front of pq
            while (true)
            {
                int ci = pi * 2 + 1; // left child index of parent
                if (ci > li) break;  // no children so done
                int rc = ci + 1;     // right child
                if (rc <= li && data[rc].CompareTo(data[ci]) < 0) // if there is a rc (ci + 1), and it is smaller than left child, use the rc instead
                    ci = rc;
                if (data[pi].CompareTo(data[ci]) <= 0) break; // parent is smaller than (or equal to) smallest child so done
                T tmp = data[pi]; data[pi] = data[ci]; data[ci] = tmp; // swap parent and child
                pi = ci;
            }
            return frontItem;
        }

        public T Peek()
        {
            T frontItem = data[0];
            return frontItem;
        }

        public int Count()
        {
            return data.Count;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < data.Count; ++i)
                s += data[i].ToString() + " ";
            s += "count = " + data.Count;
            return s;
        }

        public bool IsConsistent()
        {
            // is the heap property true for all data?
            if (data.Count == 0) return true;
            int li = data.Count - 1; // last index
            for (int pi = 0; pi < data.Count; ++pi) // each parent index
            {
                int lci = 2 * pi + 1; // left child index
                int rci = 2 * pi + 2; // right child index

                if (lci <= li && data[pi].CompareTo(data[lci]) > 0) return false; // if lc exists and it's greater than parent then bad.
                if (rci <= li && data[pi].CompareTo(data[rci]) > 0) return false; // check the right child too.
            }
            return true; // passed all checks
        } // IsConsistent
    } // PriorityQueue
}
