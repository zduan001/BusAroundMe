using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
	public class G_050_IteratorOnPairs
	{
        /*
        假设有一很长的数字，比如11224444，被压缩存储为pairs，如(1; 2), (2; 2), (4; 4).然后写
        个Iterator，要求有constructor(to take pairs as input)， next() to give out the digit and move
        to the next position, hasNext() to indicate if there’s any more digit left.
         */
        public G_050_IteratorOnPairs(List<Pair> pairs)
        {
            pairs = pairs;
            CurrentIndex = 0;
            currenCount = pairs[CurrentIndex].count;
        }
        private List<Pair> pairs;
        private int CurrentIndex;
        private int currenCount;

        public bool hasNext()
        {
            if (currenCount == 0)
            {
                CurrentIndex++;
                if (CurrentIndex < pairs.Count)
                {
                    currenCount = pairs[CurrentIndex].count;
                    return hasNext();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public int Next()
        {
            if (hasNext())
            {
                int res = pairs[CurrentIndex].Value;
                currenCount--;
                return res;
            }
            else
            {
                throw new Exception();
            }
        }
    }

    public class Pair
    {
        public int Value;
        public int count;

    }
}
