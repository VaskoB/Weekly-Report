using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {

            int chicken_menus = int.Parse(Console.ReadLine());
            int fish_menus = int.Parse(Console.ReadLine());
            int vegetarian_menus = int.Parse(Console.ReadLine());

            double cm = chicken_menus * 10.35;
            double fm = fish_menus * 12.40;
            double vm = vegetarian_menus * 8.15;

            double total = cm + fm + vm;
            double desert = total * 0.20;
            double grandtotal = total + desert + 2.50;

            Console.WriteLine("Total: {0:f2}", grandtotal);

        }
    }
}
