using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_CollectionsDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> award = new Dictionary<string, string>()
            {
                { "2000", "Gladiator" },
                { "2001", "A Beautiful Mind" },
                { "2002", "Chicago"},
                { "2003", "The Lord of the Rings: Return of the King"},
                { "2004", "Million Dollar Baby"},
                { "2005", "Crash"}
            };

            foreach (var movie in award)
            {
                Console.WriteLine($"In {movie.Key} the winner was {movie.Value}");
            }



            var nominees = new Dictionary<string, string[]>()
            {
                {"2000", new string[]{"Gladiator", "Crouching Tiger: Hidden Dragon", "Traffic"} },
                {"2001", new string[]{"A Beautiful Mind", "The Lord of the Rings: The Fellowship of the Ring", "Moulin Rouge!"} },
                {"2002", new string[]{"Chicago", "The Pianist", "The Lord of the Rings: The Two Towers"} },

            };

            foreach (KeyValuePair<string, string[]> pair in nominees)
            {
                Console.WriteLine("{0}: {1}, {2}", pair.Key, pair.Value[0], pair.Value[1]);
            }


            


            Console.ReadLine();
        }
    }
}
