using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_5_1_UnionFinder
    {
        private int[] tracker;
        private int[] sz;
        public _1_5_1_UnionFinder(int n)
        {
            tracker = new int[n];
            sz = new int[n];
            for (int i = 0; i < n; i++)
            {
                sz[i] = 1;
                tracker[i] = i;
            }
        }

        public void Union(int first, int second)
        {
            int i = Find(first);
            int j = Find(second);
            if (i != j)
            {
                if (sz[i] <= sz[j])
                {
                    tracker[i] = tracker[j];
                    sz[j] += sz[i];
                }
                else
                {
                    tracker[j] = tracker[i];
                    sz[i] += sz[j];
                }
                
            }
        }

        public void UnionWithCompress(int first, int second)
        {
            int i = Find(first);
            int j = Find(second);
            if (i != j)
            {
                if (sz[i] < sz[j])
                {
                    tracker[i] = tracker[j];
                    while (first != tracker[first])
                    {
                        tracker[first] = tracker[j];
                        first = tracker[first];
                        sz[j] += sz[i];
                    }
                }
                else
                {
                    tracker[j] = tracker[i];
                    while (second != tracker[second])
                    {
                        tracker[second] = tracker[i];
                        second = tracker[second];
                        sz[i] += sz[j];
                    }
                }
            }
        }

        public bool IsConnectioned(int i, int j)
        {
            return (Find(i) == Find(j));
        }

        public int Find(int i)
        {
            while (i != tracker[i]) 
                i = tracker[i];
            return i;
        }

        public int Count()
        {
            return tracker.Length;
        }
    }
}
