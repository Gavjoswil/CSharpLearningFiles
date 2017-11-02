using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle(5, 6);
            Triangle triangle2 = new Triangle(10, 15);
            Triangle triangle3 = new Triangle(10, 5);
            Triangle triangle4 = new Triangle(8, 6);
            Triangle triangle5 = new Triangle(113, 90);

            Console.WriteLine(triangle1.Area());
            Console.WriteLine(triangle2.Area());
            Console.WriteLine(triangle3.Area());
            Console.WriteLine(triangle4.Area());
            Console.WriteLine(triangle5.Area());

            Console.ReadLine();
        }
    }
}
