using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges
{
    public class Median
    {
        public SortedDictionary<int, int> MinHeap;
        public SortedDictionary<int, int> MaxHeap;
    }

    public class Operation
    {
        public char Action{get;set;}
        public int Value{get;set;}
    }
}
