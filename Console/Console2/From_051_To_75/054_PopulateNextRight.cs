using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_051_To_75
{

    /*
     * Given a binary tree 
        struct TreeLinkNode {
          TreeLinkNode *left;
          TreeLinkNode *right;
          TreeLinkNode *next;
        }
 

        Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to NULL.

        Initially, all next pointers are set to NULL.

             * Follow up for problem "Populating Next Right Pointers in Each Node".
 
        What if the given tree could be any binary tree? Would your previous solution still work?
 
        Note: 
        •You may only use constant extra space.
 

        For example,
         Given the following binary tree,
 
                 1
               /  \
              2    3
             / \    \
            4   5    7
 

        After calling your function, the tree should look like:
 
                 1 -> NULL
               /  \
              2 -> 3 -> NULL
             / \    \
            4-> 5 -> 7 -> NULL

     */
    public class _054_PopulateNextRight
    {
        public void NextRight(TreeNodeWithNext root)
        {
            Queue<TreeNodeWithNext> q = new Queue<TreeNodeWithNext>();
            q.Enqueue(root);
            q.Enqueue(null);
            TreeNodeWithNext prev = null;
            TreeNodeWithNext tmp = null;
            while (q.Count != 0)
            {
                tmp = q.Dequeue();
                if (prev != null)
                {
                    prev.Next = tmp;
                }
                prev = tmp;

                if (tmp == null && q.Count != 0)
                {
                    q.Enqueue(null);
                    continue;
                }

                if (tmp != null && tmp.LeftChild != null)
                {
                    q.Enqueue(tmp.LeftChild);
                }
                if (tmp != null && tmp.RightChild != null)
                {
                    q.Enqueue(tmp.RightChild);
                }
            }
        }
    }


    public class TreeNodeWithNext
    {
        public TreeNodeWithNext(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public TreeNodeWithNext LeftChild { get; set; }
        public TreeNodeWithNext RightChild { get; set; }
        public TreeNodeWithNext Next { get; set; }

    }
}
