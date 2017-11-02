using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_OOP_Game
{
    public abstract class Character
    {
        //CONSTANT
        const int Min_Health = 0;
        
        //PROPERTIES
        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public int Level { get; set; }
        public int HitPoints { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int OneHanded { get; set; }
        public int TwoHanded { get; set; }
        public int Armor { get; set; }


        //METHODS




    }
}
