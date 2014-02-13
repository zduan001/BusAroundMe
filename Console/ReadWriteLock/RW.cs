using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadWriteLock
{
 
    
    class RW
    {
        private Mutex mutex;
        private Semaphore semaphore;
        private int concurrentReadCount;
        private bool lastisRead;

        public RW()
        {
            this.mutex = new Mutex();

            concurrentReadCount = 0;
        }

        public bool LockRead()
        {
            if (concurrentReadCount == 0)
            {
                mutex.WaitOne(0);
                lastisRead = true;
                concurrentReadCount++;
                return true;
            }
            else
            {
                concurrentReadCount++;
                return true;
            }
        }

        public bool ReleaseRead()
        {
            concurrentReadCount--;
            if (concurrentReadCount == 0 && lastisRead)
            {
                mutex.ReleaseMutex();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LockWrite()
        {
            if (mutex.WaitOne(0))
            {
                lastisRead = false;
                return true;
            }
            return false;
        }

        public bool ReleaseWrite()
        {
            if (!lastisRead)
            {
                mutex.ReleaseMutex();
                return true;
            }
            return false;
        }

    }
}
