using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_011_SimplifyPath
    {
        /*
         * 
            Unix file path化简，写code 
            例如 /a/./b/../../c/ ，化简为 /c/ 
            用stack或者d-queue，有些细节需要考虑，例如 /..//.. 还是输出 / 
         * it seem like a stack can handle this. when /a/ showup push it on to stack
         * when ../ show pop one out. what else left in stack is the right one.
         */
        /// <summary>
        /// 把字符串先用Split（'/') 分开。arr[i] == "" 表示多余的斜杠。arr[i] == ".."表示返回上一级，arr[i] == "." 可以忽略它。
        /// 要记住最后如果结果为空，要加"/"回到根目录。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string SimplifyPath(string s)
        {
            string[] arr = s.Split('/');
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "")
                {
                    if (arr[i] == "..")
                    {
                        if (stack.Count > 0)
                            stack.Pop();
                    }
                    else if (arr[i] == ".")
                    {
                    }
                    else
                    {
                        stack.Push(arr[i]);
                    }
                }
            }

            StringBuilder sb = new StringBuilder();

            while (stack.Count > 0)
            {
                sb.Insert(0, "/" + stack.Pop());
            }

            //solve corner case like "/../"
            if (sb.Length == 0)
                sb.Append("/");

            return sb.ToString();
        }
    }
}
