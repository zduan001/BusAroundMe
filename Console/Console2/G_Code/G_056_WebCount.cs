using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Console2.G_Code
{
    /* design. 
    class webcounter {
            void increment();
            int lastmin();
            int lasthour();
            int lastday();
    }
     */
    /// <summary>
    /// First I have to ask for the definition of Lastmin and Lasthour, and lastDay.
    /// I will define them as following
    ///     lastmin means from now to the last time second = 0;
    ///     lasthour means from now to the last time min = 0;
    ///     lastday means from now to the last time hour = 0;
    /// as long as these item defined, keep a current count and roll over the current min count of "lastmin" count it will work.
    /// 
    /// I added Semaphore and condition variable to make sure this is thread safe.
    /// </summary>
    public class G_056_WebCount
    {
        public G_056_WebCount()
        {
            timer = new System.Timers.Timer();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            lastminlock = new Semaphore(0, 1);
            lastdaylock = new Semaphore(0, 1);
            lastHourlock = new Semaphore(0, 1);
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (DateTime.Now.Minute == 0)
            {
                lastHourlock.WaitOne();
                lastHourCount += lastMinCount;
                lastHourlock.Release();

                lastminlock.WaitOne();
                lastMinCount = 0;
                lastminlock.Release();
            }

            lastdaylock.WaitOne();
            lastdayCount = 0;
            lastdaylock.Release();
        }


        int lastMinCount = 0;
        int lastdayCount = 0;
        int lastHourCount = 0;

        Semaphore lastminlock;
        Semaphore lastdaylock;
        Semaphore lastHourlock;


        System.Timers.Timer timer;

        public int LastMin()
        {
            return lastMinCount;
        }

        public int LastHour()
        {
            return lastHourCount;
        }

        public int LastDay()
        {
            return lastdayCount;
        }
    }
}
