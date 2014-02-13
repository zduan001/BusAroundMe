using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookQuestions
{
    class _009_LastMinute
    {
        const int SIZE = 60 * 60; //seconds in one hour
        int[] arr = new int[SIZE];
        int hour = 0;
        int minute = 0;
        long last = 0;

        long currSecond()
        {
            DateTime centuryBegin = new DateTime(2001, 1, 1);
            long elapseTicks = DateTime.Now.Ticks - centuryBegin.Ticks;
            TimeSpan elapse = new TimeSpan(elapseTicks);
            return (long)elapse.TotalSeconds;
        }

        long Update()
        {
            long curr = currSecond();
            if (curr > last)
            {
                // if curr-last > size, that mean. for the last hour there is no request.
                // clear the array and numbers.
                if (curr - last >= SIZE)
                {
                    hour = 0;
                    minute = 0;
                    Array.Clear(arr, 0, arr.Length);
                }
                else
                {
                    // same logic as last minute. last minute has no data.
                    // clear cached last minute
                    if (curr - last >= 60)
                    {
                        minute = 0;
                    }
                    else
                    {
                        // clear old request count from minutes if any.
                        for (long i = last - 60 + 1; i <= curr - 60; i++)
                        {
                            minute -= arr[(int)(i % SIZE)];
                        }
                    }

                    // clear old request from last hour.
                    for (long i = last + 1; i <= curr; i++)
                    {
                        int p = (int)(i % SIZE);
                        hour -= arr[p];
                        arr[p] = 0;
                    }
                }
                last = curr;
            }

            return curr;
        }

        void request()
        {
            long curr = Update();

            // increase the counter.
            arr[(int)(curr % SIZE)]++;
            hour++;
            minute++;
        }

        int lastSecond()
        {
            long curr = Update();
            return arr[(int)(curr % SIZE)];
        }

        int lastMinute()
        {
            Update();
            return minute;
        }

        int lastHour()
        {
            Update();
            return hour;
        }
    }
}
