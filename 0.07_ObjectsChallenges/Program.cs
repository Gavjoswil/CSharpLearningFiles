using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Netflix tvShow = new Netflix();
            Netflix movie = new Netflix();
            Netflix documentary = new Netflix();

            tvShow.Name = "Dexter";
            tvShow.Genre = "Crime";
            tvShow.Rating = 5;

            movie.Name = "Death Note";
            movie.Genre = "Anime";
            movie.Rating = 2;

            documentary.Name = "Making a Murderer";
            documentary.Genre = "Crime";
            documentary.Rating = 4;

            Console.WriteLine(tvShow.Name);
            

            Console.ReadLine();
        }
    }
}
