using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypesChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //BRONZE
            int luckyNumber;
            string firstName;
            string lastName = "Williams";
            bool isMarried = false;
            double Pi = 3.14;

            //SILVER
            string fullName = "Gavin " + lastName;
            Console.WriteLine(fullName);

            //GOLD
            string birthYear = "1997";
            int year = Convert.ToInt32(birthYear);

            Console.WriteLine("I was born in " + year);
            Console.ReadLine();

        }
    }
}
