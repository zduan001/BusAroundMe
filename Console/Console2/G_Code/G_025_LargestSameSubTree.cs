using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.G_Code
{
    public class G_025_LargestSameSubTree
    {
        /*
         * 找二叉树两个最大的相同子树。
         */
        /*
        basic idea: use a hash function to get a digest of a tree by hashing its 
        child subtrees' digests:

        digest(tree)=0 if tree is empty
        digest(tree)=hash(digest(LeftChildTree),digest(RightChildTree),rootVal)

        therefore, this problem can be solved by a post-order traversal. On the 
        traversal, all the subtrees are digested and registered. If a match occurs, 
        the roots of both trees and their size are compared and recorded.

        the hashTable_get/put functions need the tree digest (hash value) for quick 
        access, and also the tree root address to perform verification in the 
        unlikely case of collision.
         */
        public void FindLargestSameSubTree(TreeNode root)
        {

        }
    }
}
