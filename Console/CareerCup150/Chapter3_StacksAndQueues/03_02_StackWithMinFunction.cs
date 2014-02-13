using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter3_StacksAndQueues
{
    public class _03_02_StackWithMinFunction
    {
        /*
         * How would you design a stack which, in addition to push and pop, also has a function min 
         * which returns the minimum element? Push, pop and min should all operate in O(1) time.
         */
        Stack<ValueWithMin> s = new Stack<ValueWithMin>();

        public void Push(int input)
        {
            ValueWithMin value = new ValueWithMin()
            {
                Value = input,
                Min = Math.Min(input, s.Peek().Min)
            };

            s.Push(value);
        }

        public int Min()
        {
            if (s.Peek() != null)
            {
                return s.Peek().Min;
            }

            return int.MinValue;
        }
    }

    public class ValueWithMin
    {
        public int Value {get;set;}
        public int Min { get; set; }
    }

    /*
        There’s just one issue with this: if we have a large stack, we waste a lot of space by keeping track 
        of the min for every single element. Can we do better?
        We can (maybe) do a bit better than this by using an additional stack which keeps track of the mins.
     */
    public class StackWithMinFunctionII
    {
        Stack<int> s; // original real stack.
        Stack<int> minStack; // second stack keep track the min value of the stack.

        public void Push(int input)
        {
            if (input < Min())
            {
                minStack.Push(input);
            }
            s.Push(input);
        }

        public int Pop()
        {
            int res = minStack.Pop();
            if (res == Min()) minStack.Pop();
            return res;
        }

        public int Min()
        {
            if (s.Count == 0)
                return int.MaxValue;
            else
                return minStack.Peek();
        }


    }

}
