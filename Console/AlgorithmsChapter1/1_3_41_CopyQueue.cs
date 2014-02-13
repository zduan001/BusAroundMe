using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_3_41_CopyQueue
    {
        /*
         * Clone a queue.
         * 
         */
        public Queue<int> Copy(ref Queue<int> input)
        {
            if (input == null) return null;
            Queue<int> res = new Queue<int>();
            Queue<int> tmp = new Queue<int>();
            while (input.Count != 0)
            {
                int value = input.Dequeue();
                tmp.Enqueue(value);
                res.Enqueue(value);
            }
            input = tmp;
            return res;
        }
    }
}
