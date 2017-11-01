using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_Override
{
    class Circle : Shape
    {
        public Circle(int radius)
        {
            int Radius = radius;
        }
        
        //Properties
        public int Radius { get; set; }
        //Methods
        public override double Area()
        {
            return Math.PI * (Math.Pow(this.Radius, 2));
        }
    }
}
