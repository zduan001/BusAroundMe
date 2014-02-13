using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_026_MakePeek<T> where T:class
    {
        /*
         * iterator has only bool hasNext() and T next() method, write a wrapper for iterator, to support peek() .
         */
        //http://www.mitbbs.com/article_t/JobHunting/32078587.html

        public G_026_MakePeek(Iterator<T> input)
        {
            localIterator = input;
            peekValue = null;
        }

        private Iterator<T> localIterator;
        private T peekValue;

        public T Peek()
        {
            if (peekValue == null)
            {
                if (HasNext())
                {
                    peekValue = localIterator.Next();
                }
            }
            return peekValue;
        }

        public bool HasNext()
        {
            if (peekValue != null)
            {
                return true;
            }
            else
            {
                return localIterator.HasNext();
            }
        }

        public T Next()
        {
            if (peekValue != null)
            {
                T res = peekValue;
                peekValue = null;
                return res;
            }
            else
            {
                if (localIterator.HasNext())
                {
                    return localIterator.Next();
                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}

public class Iterator<T> where T:class
{
    public Iterator(T[] input)
    {
        Tracker = input;
        currentIndex = 0;
    }
    private int currentIndex;
    private T[] Tracker;

    public bool HasNext()
    {
        if (currentIndex < Tracker.Length)
            return true;
        else
            return false;
    }

    public T Next()
    {
        if (this.HasNext())
        {
            T res = Tracker[currentIndex];
            currentIndex++;
            return res;
        }
        else
        {
            throw new Exception();
        }

    }
}
