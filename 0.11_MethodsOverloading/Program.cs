using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_MethodsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Player class with 
            //1 Attack() methods that accepts 3 diff sets of parameters
            //For example) 
            //Attack(100) --> Attacked for 100
            //Attack(100, "weapon") --> Attacked with weapon for 100
            //Attack(100, "Weapon", #ofTimes) --> Attacked with weapon for 100 #ofTimes, dealing totalDamage.
            Player me = new Player();
            me.Attack(1000);
            me.Attack(100, "Lance");
            me.Attack(100, "GreatSword", 3);
            Console.ReadLine();


        }
    }
}
