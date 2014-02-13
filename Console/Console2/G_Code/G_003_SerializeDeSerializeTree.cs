using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.G_Code
{
    public class G_003_SerializeDeSerializeTree
    {
        /*
         * 给二叉树，每个节点含有一个string, 要求serialize 和deserialize
         */
        public string SerializeSting(TreeNode root)
        {
            StringBuilder sb = new StringBuilder();
            SerializerWorker(root, sb);
            return sb.ToString();
        }

        public void SerializerWorker(TreeNode root, StringBuilder sb)
        {
            if (root == null)
            {
                if (sb.Length != 0)
                {
                    sb.Append(',');
                }
                sb.Append('#');
                return ;
            }

            sb.Append(root.Value.ToString());
            SerializerWorker(root.LeftChild, sb);
            SerializerWorker(root.RightChild, sb);
        }


        /*
         * deserialize...
         */

        public TreeNode DeserializeString(string s, char seperator, char nullChar)
        {
            string[] input = s.Split(',');
            int startIndex = 0;
            TreeNode root = DeserializeWorker(input, ref startIndex, nullChar);
            return root;
        }

        public TreeNode DeserializeWorker(string[] input, ref int startIndex, char nullChar)
        {
            if (input[startIndex] == nullChar.ToString()) 
            {
                return null;
            }
            else
            {
                TreeNode root = new TreeNode(int.Parse(input[startIndex]));
                startIndex ++;
                root.LeftChild = DeserializeWorker(input, ref startIndex, nullChar);
                if(startIndex <input.Length)
                {
                    startIndex ++;
                    root.RightChild = DeserializeWorker(input, ref startIndex, nullChar);
                }
                return root;
            }
        }
    }
}
