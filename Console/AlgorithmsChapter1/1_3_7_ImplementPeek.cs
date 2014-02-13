using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    /*
     * Add a method peek() to Stack that returns the most recently inserted item on the stack (without popping it).
     */
    /// <summary>
    /// Nothing fancy just set a private variable to hold peeked value. 
    /// if pop next time, return peeeked value and set the peeked value to null;
    /// if peek next time, return the value.
    /// if push next time, if peekedvalue not null, push peekedvalue first then push the input.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class _1_3_7_ImplementPeek<T> : Stack<T> where T : class
    {
        public _1_3_7_ImplementPeek()
        {
            Peeked = null;
        }

        T Peeked;

        public T Peek()
        {
            if (Peeked == null)
            {
                Peeked = base.Pop();
            }
            return Peeked;
        }

        public  T Pop()
        {
            if (Peeked != null)
            {
                T tmp = Peeked;
                Peeked = null;
                return tmp;
            }
            return base.Pop();
        }

        public void Push(T input)
        {
            if (Peeked != null)
            {
                base.Push(Peeked);
                Peeked = null;
            }
            base.Push(input);
        }
    }
}
