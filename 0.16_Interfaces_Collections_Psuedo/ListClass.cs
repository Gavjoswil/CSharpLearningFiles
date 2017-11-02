using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Interfaces_Collections_Psuedo
{
    class ListClass : IEnum, ICollect, IList
    {
        public void AddStuff()
        {
            Console.WriteLine("Added stuff to list");
        }

        public void CheckTheCapacity()
        {
            Console.WriteLine("Check the capacity of the list");
        }

        public void CheckTheCount()
        {
            Console.WriteLine("Check the count on the list");
        }

        public void IterateOverCollection()
        {
            Console.WriteLine("Iterating over list");
        }

        public void RemoveStuff()
        {
            Console.WriteLine("Removed stuff from the list");
        }
    }
}
