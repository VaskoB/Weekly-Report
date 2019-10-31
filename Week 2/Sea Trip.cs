using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_Trip
{
    class Program
    {
        static void Main(string[] args)
        {

            double food = double.Parse(Console.ReadLine());
            double souvenir = double.Parse(Console.ReadLine());
            double hotel = double.Parse(Console.ReadLine());

            int days = 3;
            int distance = 420;
            double litres = 29.4;
            double gas = 54.39;

            double days3 = 3 * food + souvenir * 3;

            double hoteld1 = hotel * 0.90;
            double hoteld2 = hotel * 0.85;
            double hoteld3 = hotel * 0.80;

            double total = gas + days3 + hoteld1 + hoteld2 + hoteld3;

            Console.WriteLine("Money needed: {0:f2}", total);
        }
    }
}
