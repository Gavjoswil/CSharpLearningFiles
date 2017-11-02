using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_OOP_Game
{
    class Player: Character
    {
        public Player()
        {
            Level = 1;
            Strength = 20;
            HitPoints = 100;

        }
        
        
        //ENUMS
        public enum Race
        {
            Nord = 1,
            DarkElf = 2,
            Khajiit = 3,
            Argonian = 4,
            Orc = 5,
            WoodElf = 6,
            Breton = 7,
            HighElf = 8,
            Imperial = 9,
            RedGuard = 10
        }
    }
}
