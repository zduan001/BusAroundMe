using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _058_RotateImage
    {
        /// <summary>
        /// You are given an n x n 2D matrix representing an image.
        /// Rotate the image by 90 degrees (clockwise).
        /// Follow up:
        /// Could you do this in-place?
        /// </summary>
        /// <param name="image"></param>
        public void RotateImage(List<List<int>> image)
        {
            if (image.Count != image[0].Count) throw new ArgumentException(); // has to be a square mage
            int n = image.Count;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n - i; j++)
                {

                }
            }

        }
    }
}
