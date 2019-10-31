using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            double litres = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double gas = litres * 2.10;
            double guide = 100;
            double total = gas + guide;

            if(day == "Saturday")
            {
                total = total * 0.90;
            }
            else if(day == "Sunday")
            {
                total = total * 0.80;
            }
            double left = budget - total;
            double need = total - budget;

            if(budget >=total)
            {
                Console.WriteLine("Safari time! Money left: {0:f2} lv.", left);
            }
            else if(total > budget)
            {
                Console.WriteLine("Not enough money! Money needed: {0:f2} lv.", need);
            }

        }
    }
}
