using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_ForLoopsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(i);
            }
            for (int f = 0; f <= 100; f+=5)
            {
                Console.WriteLine(f);
            }

            int n = 1;
            while (n++ < 100)
            {
                Console.WriteLine(n);
            }


            Console.ReadLine();
        }
    }
}
