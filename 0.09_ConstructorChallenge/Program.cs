using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_ConstructorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone newPhone = new MobilePhone("Google", "Pixel");

            
            MobilePhone gavinPhone = new MobilePhone("Google", "Pixel");
            MobilePhone michaelPhone = new MobilePhone("iPhone", "7");
            MobilePhone forrestPhone = new MobilePhone("iPhone", "6");


            Console.WriteLine($"I have a {newPhone.Make} {newPhone.Model}.");

            gavinPhone.PrintPhone();




            Console.ReadLine();
        }
    }
}
