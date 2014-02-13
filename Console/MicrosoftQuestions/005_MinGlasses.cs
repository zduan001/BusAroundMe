using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftQuestions
{
    public class _005_MinGlasses
    {
        /*
         * Suppose you are going to organize a party from 9:00 am to 20:00 pm. You have invited ‘n’ number of 
         * guests for the party. You are given the arrival time and the departure time of all guests. Every 
         * time a new guest arrives, you give him a glass of wine and when he leaves, you take the glass back. 
         * If someone has left and returned the glass, you can give the same glass to a new guest who has just arrived.
         * Based on the given schedule for guests, determine the minimum number of glasses required for the 
         * party. A guest can come or leave at any time, but you are given the fixed schedule. Write code for 
         * the given problem
         */
        public int FindMinGlasses(List<Interval> input)
        {
            List<TimeSlot> slots = new List<TimeSlot>();
            foreach (Interval item in input)
            {
                slots.Add(new TimeSlot() { Time = item.Start, Istart = 0 });
                slots.Add(new TimeSlot() { Time = item.End, Istart = 1 });
            }

            IEnumerable<TimeSlot> tmp =
                from slot in slots
                orderby slot.Time ascending, slot.Istart ascending
                select slot;

            int max = 0;
            int counter = 0;
            foreach (TimeSlot slot in tmp)
            {
                if (slot.Istart == 0)
                {
                    counter++;
                    if (max < counter)
                    {
                        max = counter;
                    }
                }
                if (slot.Istart == 1)
                {
                    counter--;
                }
            }
            return max;
        }
    }

    public class Interval
    {
        public int Start;
        public int End;
    }

    public class TimeSlot 
    {
        public int Time;
        public int Istart;
    }
}
