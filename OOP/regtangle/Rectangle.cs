using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_Rectangle
{
    public class Rectangle
    {
        private int length;
        private int width;

        public int CalculateArea()
        {

            return length * width;
        }

        public int CalculateArea(int length, int width)
        {

            return length * width;
        }

        public void SetDimensions(int l, int w)
        {
            length = l;
            width = w;
        }
    }
}