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
            Triangle triangle4 = new Triangle(9, 3);
            Triangle triangle5 = new Triangle(113, 90);

            triangle1.Area();
            triangle2.Area();
            triangle3.Area();
            triangle4.Area();
            triangle5.Area();


            IEnumerable<Triangle> triangles = new List<Triangle>
            {
                triangle1,
                triangle2,
                triangle3,
                triangle4,
                triangle5
            };
            IEnumerable<Triangle> query = from t in triangles
                                             where t.TArea > 20
                                             orderby t.TArea ascending
                                             select t;
            foreach (Triangle triangle in query)
            {
                Console.WriteLine(triangle.TArea);
            }


            Console.ReadLine();
        }
    }
}
