using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_060_ClosestMNode
    {
        /*
         * Given N node BST, and a key K, find m (m < N) nodes in tree which are close tokey value？
         */
        // plan is have a size of m/2 queue. inorder travel the tree, at same time add traveled 
        // node to queue. if queue is full dequeue it before enqueue, untill we found the K. 
        // start a new queue with size of m- m/2) m might be an odd number. travel until the queue 
        // get to the size. the combination of 2 queue is the answer.

    }
}
