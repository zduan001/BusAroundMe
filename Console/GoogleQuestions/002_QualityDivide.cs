using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleQuestionTest
{
    public class _002_QualityDivide
    {
        /*
         * http://www.mitbbs.com/article_t/JobHunting/32078073.html
         * You are given a String number containing the digits of a phone number (the number
            of digits, n, can be any positive integer) . To help you memorize the number, you want
            to divide it into groups of contiguous digits. Each group must contain exactly 2 or 3 digits.
            There are three kinds of groups:
             Excellent: A group that contains only the same digits. For example, 000 or 77.
             Good: A group of 3 digits, 2 of which are the same. For example, 030, 229 or 166.
             Usual: A group in which all the digits are distinct. For example, 123 or 90.
            The quality of a group assignment is defined as 2 × (number of excellent groups) + (number
            of good groups), Divide the number into groups such that the quality is maximized.
         */
        /*
         * Solution: I think it can be solved by DP. Max(n) = Max[ [max(n-3) + v(last 3)], [max(n-2) + v(last_2)] ]
         * give the formula, we can even optimize by only keep the last 3 value, and use % to find the right value...
         */
        public string FindBestDivdor(char[] input)
        {
            if(input == null) return null;
            if(input.Length < 1) return null;
            List<Item> tracker = new List<Item>();

            tracker.Add(new Item() {Quality = 0, Length = 0});
            int second = 0;
            if(input[0] == input[1]) 
            {
                second = 3;
            }
            tracker.Add(new Item() {Quality = second, Length = 2});

            int third = 0;
            if(input[0] == input[1] && input[1] == input[2])
            {
                third = 3;
            }
            else if(input[0] == input[1] || input[1] == input[2] || input[0] == input[2])
            {
                third = 2;
            }
            tracker.Add(new Item() {Quality = third, Length = 3});



            for (int i = 3; i < input.Length; i++)
            {
                int valueof2 = 0;
                
                if(input[i] == input[i-1])
                {
                    valueof2 = 3;
                }
                valueof2 += tracker[i-2].Quality;
                
                int valueof3 = 0;

                if(input[i] == input[i-1] && input[i-1] == input[i-2])
                {
                    valueof3 = 3;
                }
                else if(input[i] == input[i-1] || input[i] == input[i-2] || input[i-1] == input[i-2])
                {
                    valueof3 = 2;
                }
                valueof3 += tracker[i-3].Quality; 
                

                if(valueof2> valueof3) 
                {
                    tracker.Add(new Item() { Quality = valueof2, Length = 2});
                }
                else
                {
                    tracker.Add(new Item() {Quality = valueof2, Length = 3});
                }
            }


            string res = string.Empty;
            int k = tracker.Count - 1;
            int lastIndex = input.Length-1;
            while (k>=0)
            {
                if (tracker[k].Length == 2)
                {
                    res = input[lastIndex] + res;
                    res = input[lastIndex - 1] + res;
                    res = ' ' + res;

                    lastIndex = lastIndex - 2;
                    k = k - 2;
                }
                else if(tracker[k].Length == 3)
                {
                    res = input[lastIndex] + res;
                    res = input[lastIndex - 1] + res;
                    res = input[lastIndex - 2] + res;
                    res = ' ' + res;
                    lastIndex = lastIndex - 3;
                    k = k - 3;
                }
            }
            return res;
        }


        public string FindBestDividorRec(char[] input)
        {
            bool[] tracker = new bool [input.Length];
            Worker(input, tracker, 0);

            return string.Empty;

        }

        public int Worker(char[] input, bool[] tracker, int k)
        {
            if (k == input.Length - 2 || k == input.Length - 3)
            {
                //Calculate the quality and return the best one.
                return 0;
            }

            tracker[k + 2] = true;
            int a = Worker(input, tracker, k + 2);
            tracker[k + 2] = false;
            tracker[k + 3] = true;
            int b = Worker(input, tracker, k + 3);
            tracker[k + 3] = false;

            return a > b ? a : b;
        }
    }

    public class Item
    {
        public int Quality;
        public int Length;
    }
}
