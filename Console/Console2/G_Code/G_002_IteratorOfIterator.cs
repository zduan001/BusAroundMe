using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_002_IteratorOfIterator
    {
        /*
         * 一个java的class,有一个变量是一个Iterator<T>, Iterator<T>可以里面的element可以是数(T)，也可以是Iterator, 实现hasNext, next， 这个要考虑Iterator中含有空Iterator的情况 
         * [[1,2,3], [4], [], [5]]
         * [1,2,3,4,5]
         * interface should be something like this.
         * public class T IteratorOfIterator<T>
         * {
         *      public IteratorOfIterator(Iterator<Iterator<T>> input)
         *      {
         *      }
         *      
         *      public T Next();
         *      public bool HasNext();
         * }
         * during iterview I take the input and convert it into a Iterator<T>[] and operated on the array
         * that is redundant, I should be able to operatr director on the input...
         * I will do the direct operate method here.
         */
    }

    public class IteratorOfIterator<T> where T :class
    {
        private Iterator<Iterator<T>> internalIterator;
        private Iterator<T> currentIterator;
        public IteratorOfIterator(Iterator<Iterator<T>> input)
        {
            internalIterator = input;
            currentIterator = null;
        }

        public T Next()
        {
            if (this.HastNext())
            {
                return currentIterator.Next();
            }
            else
            {
                throw new Exception();
            }
        }

        public bool HastNext()
        {
            if (currentIterator == null)
            {
                if (internalIterator.HasNext())
                {
                    currentIterator = internalIterator.Next();
                    return this.HastNext();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (currentIterator.HasNext())
                    return true;
                else
                {
                    currentIterator = null;
                    return this.HastNext();
                }
            }
        }
    }

    public class Iterator<T> where T:class
    {
        public T Next()
        {
            return null;
        }

        public bool HasNext()
        {
            return false;
        }

    }

}

//-----------------------------------------
//
// This what I wrong in the interview
//
//-----------------------------------------
//interface Iterator<T> {
//  T next();  // return current and advance.  throws exception if past the end
//  bool hasNext();
//}
//Iterator<T> getItemsFromServer();
//Iterator<Iterator<T>> getItemsFromAllServers();
//nested: [ [1,2,3] , [4], [], [5] ]
//flattened: [1,2,3,4,5]

//public class IteratorFlattener<T> : Iterator<T> {
//    public IteratorFlattener<T>( iterator<Iterator<T>> input)
//    {
//        List<Iterator<T>> tmpList = new List<Iterator<T>>();
//        while(input.hasNext())
//        {
//            tmpList.add(input.next());
//        }

//        tmpList.copyto(internalIterator);
//        currentIteratorindex = 0;
//    }


//    private Iterator<T>[] internalIterator;
//    private int currentIteratorindex;
//    public T next()
//    {
//        if(hasNext())
//        {
//            if(inernalItrator[curreniteratorindex].hasNext())
//            {
//                return inernalItrator[curreniteratorindex].next();
//            }
//            else
//            {    
//                curreniteratorindex++
//                this.next();
//            }
//        }
//        else
//        {
//            throw new exception()j;
//        }
//    }

//    bool hasNext()
//    {
//        if(inernalItrator[curreniteratorindex].hasNext())
//        {
//            return true;
//        }
//        else
//        {
//            if(curreniteratorindex ==  internalIterator.Length-1)
//            {
//                return false;
//            }
//            else
//            {
//                curretnIteration++;
//                return hasNext();
//            }
//        }
//    }
//}


