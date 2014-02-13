using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    class G_010_LRU
    {
        /*
         * A linked list + hashtable of pointers to the linked list nodes is the usual way to implement LRU caches. This gives O(1) 
         * operations (assuming a decent hash). Advantage of this (being O(1)): you can do a multithreaded version by just locking 
         * the whole structure. You don't have to worry about granular locking etc.
         * Briefly, the way it works:
         * On an access of a value, you move the corresponding node in the linked list to the head. // here since move a single linklist node is not that easy. use a double linklist
            When you need to remove a value from the cache, you remove from the tail end.
            When you add a value to cache, you just place it at the head of the linked list.
         */

    }
}
