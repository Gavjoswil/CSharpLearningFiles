using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Quiz1
{
    class Triangle : Shape
    {
        public Triangle(int tBase, int tHeight)
        {
            this.TBase = tBase;
            this.THeight = tHeight;
        }
        public int TBase { get; set; }
        public int THeight { get; set; }

        public override double Area()
        {
            return (.5) * (TBase) * (THeight);
        }
    }
}
