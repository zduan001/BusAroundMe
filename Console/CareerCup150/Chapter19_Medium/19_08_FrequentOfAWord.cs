using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter19_Medium
{
    public class _19_08_FrequentOfAWord
    {
        /*
         * Design a method to find the frequency of occurrences of any given word in a book.
         */
        public Dictionary<string, int> FindFrequency(string[] book)
        {
            Dictionary<string, int> tracker = new Dictionary<string, int>();
            foreach (string str in book)
            {
                if (tracker.ContainsKey(str))
                {
                    tracker[str]++;
                }
                else
                {
                    tracker.Add(str, 1);
                }
            }
            return tracker;
        }
    }
}
