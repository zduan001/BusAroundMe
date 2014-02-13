using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_009_ReadFile
    {
        /*
         * 
            有个封装好的函数 int block_reader(char *buf) 
            内部有个静态文件指针，只能向文件末尾移动，不能rewind 
            每次只能读取4K的block到buf里，返回读取的字节数（除非到文件尾，否则总是4K） 
            要求实现 int anysize_reader(char *buf, int size) 
            从文件的当前位置读取任意大小的数据存入buf，并返回实际读到的数据字节数 
            白板写code 
            问题的关键在于anysize_reader会被多次调用，每次都可能不是4K对齐 
            所以需要自己维护一个4K的buffer
         */
        private int location = 0;
        private int total = 6000;
        private int readSize = 400;
        private string tmpBuf = string.Empty;

        public int BlockRead(ref string buf)
        {
            buf = string.Empty;
            int counter = 0;
            for (int i = location; i < location + readSize; i++)
            {
                buf += '1';
                counter++;
            }
            return counter;
        }

        /// <summary>
        /// Keep a long tmpBuf to store what left after the size.
        /// every time before actual read, append the tmpBuf to the
        /// buffer. 
        /// once have enough strings. use substring to get buf(need 
        /// return) and tmpBuf, return size.
        /// 
        /// the tmpbuf size > size, the main logic already covered this.
        /// but I have to take care read to the end of file. if block read 
        /// reach the end of the file, blockread size less standarSize
        /// just return whatever read so far.
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public int AnySizeRead(ref string buf, int size)
        {
            int counter = tmpBuf.Length;
            buf = tmpBuf;
            string tmp = string.Empty;
            while (counter < size)
            {
                int k = BlockRead(ref tmp);
                counter += k;
                buf += tmp;
                if (k < readSize)
                {
                    return counter;
                }
            }
            tmpBuf = buf.Substring(counter - size);
            buf = buf.Substring(0, size);
            return size;
        }
    }
}
