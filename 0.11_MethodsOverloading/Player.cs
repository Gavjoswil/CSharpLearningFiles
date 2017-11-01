using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_MethodsOverloading
{
    class Player
    {
        //METHODS
        public void Attack(int damage)
        {
            Console.WriteLine($"Attacked for {damage}!");
        }
        public void Attack(int damage, string weapon)
        {
            Console.WriteLine($"Attacked with {weapon} for {damage}");
        }
        public void Attack(int damage, string weapon, int hitTimes)
        {
            int totalDamage = damage * hitTimes;
            Console.WriteLine($"Attacked with {weapon} {hitTimes} times for {totalDamage}!");
        }
    }
}
