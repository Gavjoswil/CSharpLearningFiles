using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0._10_OOP_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Character myName = new Character();
            Player newHero = new Player();
            Weapon sword = new Weapon();
            Weapon dagger = new Weapon();
            Weapon heavySword = new Weapon();
            Armor shield = new Armor();
            Armor lightArmor = new Armor();
            Armor heavyArmor = new Armor();
            sword.Attack = 10;
            dagger.Attack = 7;
            heavySword.Attack = 13;
            shield.Defense = 5;
            heavyArmor.Defense = 10;
            lightArmor.Defense = 5;


            Console.WriteLine("You awaken riding in a carriage with your hands bound. \n" + "You come to a stop in an unfamiliar city.");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("You step out of the carriage and line up with other prisoners. \n" +
                "Guard: Captain this one is not on the list, what should we do with them? \n" +
                "Captain: Find out who they are! \n" + "Guard: By your order captain. I'm sorry friend, but who are you?");
            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine("ENTER CHARACTER NAME:");
            newHero.Name = Console.ReadLine();

            Console.WriteLine("Choose your race...\n" +
                "1: Nord\n" +
                "2: Dark Elf\n" +
                "3: Khajiit\n" +
                "4: Argonian\n" +
                "5: Orc\n" + 
                "6: Wood Elf\n" + 
                "7: Breton\n" + 
                "8: High Elf\n" + 
                "9: Imperial\n" + 
                "10: Redguard\n");
            int inputRace = Int32.Parse(Console.ReadLine());
            Player.Race inputR = (Player.Race)inputRace;

            Console.WriteLine($"Captain: Wait, {newHero.Name} the {inputR}? Guard relase the {inputR} at once!\n" + 
                $"They are a hero in their homeland! Sorry about the mixup {newHero.Name}...");





            Console.ReadLine();
        }
    }
}
