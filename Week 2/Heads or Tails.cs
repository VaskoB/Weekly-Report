using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heads_or_Tails
{
    class Program
    {
        static void Main(string[] args)
        {

            var rng = new Random();
            if(rng.NextDouble() < 0.5)
            {
                Console.WriteLine("Heads");
            }
            else
            {
                Console.WriteLine("Tails");
            }

        }
    }
}
