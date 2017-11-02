using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Quiz1
{
    class Triangle : Shape
    {
        public Triangle(int tbase, int theight)
        {
            this.TBase = tbase;
            this.THeight = theight;
        }
        public int TBase { get; set; }
        public int THeight { get; set; }
        public double TArea { get; set; }


        //What Jay Did
        public override double Area()
        {
            TArea = this.TBase * this.THeight / 2.0;
            return TArea;
        }
        //public override double Area()
        //{
        //    return (.5) * (TBase) * (THeight);
        //}
    }
}
