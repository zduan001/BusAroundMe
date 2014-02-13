using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadWriteLock
{
    class Program
    {
        public static RW rw = new RW();
        public static Mutex mu = new Mutex(false,"my mutex");
        public static object o = new object();
        static void Main(string[] args)
        {
            Random random = new Random();
            
            for (int i = 0; i < 20; i++)
            {
                if (mu.WaitOne(1))
                {
                    Console.WriteLine("------------get the lock------------------------");
                }

                //Thread t = null;
                //if (random.Next(3) >= 2)
                //{
                //    t = new Thread(ReadSometing);
                //}
                //else
                //{
                //    t = new Thread(WriteSomething);
                //}
                //t.Start();
            }
            Console.WriteLine("---------------------EOD---------------------");
            System.Console.ReadKey();
        }

        public static void ReadSometing()
        {
            if (rw.LockRead())
            {

                System.Console.WriteLine("---Read Lock-----");
                Thread.Sleep(500);
                rw.ReleaseRead();
                System.Console.WriteLine("---Read Lock release-----");
            }
        }

        public static void WriteSomething()
        {
            if (rw.LockWrite())
            {
                System.Console.WriteLine("****Write Lock*******");
                Thread.Sleep(600);
                rw.ReleaseWrite();
                System.Console.WriteLine("****Write Lock release*******");
            }
        }
    }
}
