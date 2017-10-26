using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals2
{
    class Program
    {
        static void Main(string[] args)
        {
            int bankAccount = 563;

            if(bankAccount < 1000)
            {
                Console.WriteLine("I am broke");
            }
            else
            {
                Console.WriteLine("I am doing really well");
            }
        }
    }
}
