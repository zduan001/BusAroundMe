using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_3_12_CopyStack
    {
        /*
         * Clone a stack.
         */
        public Stack<int> Copy(Stack<int> input)
        {
            Stack<int> tmp = new Stack<int>();
            Stack<int> res = new Stack<int>();

            while (input.Count != 0)
            {
                tmp.Push(input.Pop());
            }

            while (tmp.Count != 0)
            {
                int value = tmp.Pop();
                res.Push(value);
                input.Push(value);
            }
            return res;
        }
    }
}
