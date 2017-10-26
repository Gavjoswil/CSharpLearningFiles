using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //BRONZE
            string[] favFood = new string[3];
            favFood[0] = "Bacon";
            favFood[1] = "Biscuits and Gravy";
            favFood[2] = "Pizza";

            foreach (string fav in favFood)
            {
                Console.WriteLine(fav);
            }

            //SILVER
            int[] numbers1 = new int[5] { 3, 4, 4, 5, 5 };
            int[] numbers2 = new int[5] { 7, 2, 43, 2, 12 };

            int[] numbers3 = new int[5];

            for (int i = 0; i < numbers3.Length; i++)
            {
                numbers3[i] = numbers1[i] + numbers2[i];
            }

            foreach (int number in numbers3)
            {
                Console.WriteLine(number);
            }

            //GOLD
            int[] randomNumbers = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rnd.Next();
            }

            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);
            }




            Console.ReadLine();
        }
    }
}
